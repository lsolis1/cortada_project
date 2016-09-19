CREATE TABLE [dbo].[Tipo_Comprobante] (
    [Tipo_Comprobante] SMALLINT      IDENTITY (1, 1) NOT NULL,
    [Descripcion]      NVARCHAR (25) NOT NULL,
    CONSTRAINT [PK_Tipo_Comprobante] PRIMARY KEY CLUSTERED ([Tipo_Comprobante] ASC)
);

