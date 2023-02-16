using WebAPI_securisee.Datas;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

#region add dbcontext with sqlServrer and local server to builder service

// Add services to the container.
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;
builder.Services.AddDbContext<DataDbContext>(options => options.UseSqlServer(connectionString));

#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

#region clé, authentication et autorisation

var key = Encoding.ASCII.GetBytes("clé très sécurisée: La pizza de la mama.");

// Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuerSigningKey = true, // utilisation d'une clé cryptée pour la sécurité du token
            IssuerSigningKey = new SymmetricSecurityKey(key), // clé cryptée en elle même
            ValidateLifetime = true, // vérification du temps d'expiration du Token
            ValidateAudience = true, // vérification de l'audience du token
            ValidAudience = "pizzacorp", // l'audience
            ValidateIssuer = true, // vérification du donneur du token
            ValidIssuer = "pizzacorp", // le donneur
            ClockSkew = TimeSpan.Zero // décallage possible de l'expiration du token
        };
    });

// Authorization
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy", police =>
    {
        police.RequireClaim(ClaimTypes.Role, "Admin");
    });
    options.AddPolicy("UserPolicy", police =>
    {
        police.RequireClaim(ClaimTypes.Role, "User");
        police.RequireClaim("EstUnPizzaiolo", "true");
    });
});

#endregion

//builder.Services.AddSwaggerGen();
#region swaggergen

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI_securisee", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme.",
        Name = "Authorization",
        Scheme = "Bearer",
        BearerFormat = "JWT",
        Type = SecuritySchemeType.Http
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme
            {
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
            }
            },
            new string[] { }
        }
    });
});

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

#region cors 

app.UseCors(option =>
{
    option.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
});

#endregion

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
