string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
int i = 10;
foreach ( string month in months)
{
    Console.WriteLine($"{month.PadLeft(i, ' ')}");
    i += 10;
}