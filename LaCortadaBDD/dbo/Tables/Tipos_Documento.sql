CREATE TABLE [dbo].[Tipos_Documento] (
    [Tipo_Doc]    TINYINT       IDENTITY (1, 1) NOT NULL,
    [Descripcion] NVARCHAR (15) NOT NULL,
    CONSTRAINT [PK_Tipos_Documento] PRIMARY KEY CLUSTERED ([Tipo_Doc] ASC)
);

