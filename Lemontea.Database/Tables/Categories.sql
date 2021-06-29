CREATE TABLE [dbo].[Categories]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [Description] TEXT NOT NULL, 
    [DisplayOrder] INT NOT NULL
)
