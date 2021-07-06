CREATE TABLE [dbo].[Contatti]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [Nome] NVARCHAR(50) NOT NULL, 
    [Cognome] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Telefono] NVARCHAR(50) NULL, 
    [Cellulare] NVARCHAR(50) NULL, 
    [AziendaId] INT NOT NULL, 
    CONSTRAINT [FK_Contatti_Aziende] FOREIGN KEY ([AziendaId]) REFERENCES [Aziende]([Id])
)
