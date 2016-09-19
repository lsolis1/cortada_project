CREATE TABLE [dbo].[Ciudades] (
    [Cod_Postal]    SMALLINT      NOT NULL,
    [Cod_Provincia] TINYINT       NOT NULL,
    [Nombre]        NVARCHAR (25) NOT NULL,
    CONSTRAINT [PK_Ciudades] PRIMARY KEY CLUSTERED ([Cod_Postal] ASC),
    CONSTRAINT [FK_Ciudades_Provincias] FOREIGN KEY ([Cod_Provincia]) REFERENCES [dbo].[Provincias] ([Cod_Provincia])
);

