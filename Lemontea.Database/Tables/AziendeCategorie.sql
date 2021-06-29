CREATE TABLE [dbo].[AziendeCategorie]
(
	[AziendeId] int NOT NULL,
	[CategorieId] UNIQUEIDENTIFIER NOT NULL,
	CONSTRAINT [PK_AziendeCategorie] PRIMARY KEY ([AziendeId], [CategorieId]),
	CONSTRAINT [FK_AziendeCategorie_AziendaId] FOREIGN KEY ([AziendeId]) REFERENCES [Aziende] ([Id]),
	CONSTRAINT [FK_AziendeCategorie_CategoriaId] FOREIGN KEY ([CategorieId]) REFERENCES [Categories] ([Id])
);
