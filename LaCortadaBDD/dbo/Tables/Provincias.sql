CREATE TABLE [dbo].[Provincias] (
    [Cod_Provincia] TINYINT       IDENTITY (1, 1) NOT NULL,
    [Nombre]        NVARCHAR (25) NOT NULL,
    CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED ([Cod_Provincia] ASC)
);

