DROP TABLE PERSON

CREATE TABLE [dbo].[PERSON] (
    [Id]        INT IDENTITY(1,1) NOT NULL,
    [NOM]       VARCHAR (50) NULL,
    [EMAIL]     VARCHAR (50) NULL,
    [TELEPHONE] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO [dbo].[PERSON] ([NOM], [EMAIL], [TELEPHONE]) VALUES (N'Titi', N'titi@yahoo.fr', N'+33 6 12 34 56 78')
INSERT INTO [dbo].[PERSON] ([NOM], [EMAIL], [TELEPHONE]) VALUES (N'Jojo', N'jojo@yahoo.fr', N'+33 6 12 34 56 78')
INSERT INTO [dbo].[PERSON] ([NOM], [EMAIL], [TELEPHONE]) VALUES (N'Tata', N'tata@yahoo.fr', N'+33 6 12 34 56 78')
INSERT INTO [dbo].[PERSON] ([NOM], [EMAIL], [TELEPHONE]) VALUES (N'Bebe', N'bebe@yahoo.fr', N'+33 6 12 34 56 78')
INSERT INTO [dbo].[PERSON] ([NOM], [EMAIL], [TELEPHONE]) VALUES (N'Zeze', N'zeze@yahoo.fr', N'+33 6 12 34 56 78')
INSERT INTO [dbo].[PERSON] ([NOM], [EMAIL], [TELEPHONE]) VALUES (N'Lala', N'lala@yahoo.fr', N'+33 6 12 34 56 78')
INSERT INTO [dbo].[PERSON] ([NOM], [EMAIL], [TELEPHONE]) VALUES (N'Po', N'po@yahoo.fr', N'+33 6 12 34 56 78')
INSERT INTO [dbo].[PERSON] ([NOM], [EMAIL], [TELEPHONE]) VALUES (N'Toto', N'toto@yahoo.fr', N'+33 6 12 34 56 78')
