CREATE TABLE [dbo].[Aziende]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [RagioneSociale] NVARCHAR(50) NOT NULL, 
    [Indirizzo] NVARCHAR(50) NOT NULL, 
    [NCivico] NVARCHAR(50) NOT NULL, 
    [CAP] INT NOT NULL, 
    [Nazione] NVARCHAR(50) NOT NULL, 
    [Provincia] NVARCHAR(50) NULL, 
    [Citta] NVARCHAR(50) NOT NULL, 
    [Telefono] NVARCHAR(50) NOT NULL, 
    [Fax] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [SitoWeb] NVARCHAR(50) NULL, 
    [PartitaIVA] NVARCHAR(11) NOT NULL, 
    [CodiceFiscale] NVARCHAR(16) NULL
)
