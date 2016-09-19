CREATE TABLE [dbo].[Marcas] (
    [Cod_Marca] INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]    NVARCHAR (30) NOT NULL,
    CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED ([Cod_Marca] ASC)
);

