CREATE TABLE [dbo].[Compras_Renglones] (
    [id_comprasRenglones] INT      IDENTITY (1, 1) NOT NULL,
    [id_compra]           INT      NOT NULL,
    [Cod_Producto]        INT      NOT NULL,
    [Nro_Linea_Producto]  SMALLINT NOT NULL,
    [Cantidad]            SMALLINT NOT NULL,
    [Porcentaje_Desc]     SMALLINT NULL,
    [Importe_Desc]        INT      NULL,
    [Porcentaje_IVA]      SMALLINT NOT NULL,
    [Importe_Total]       INT      NOT NULL,
    CONSTRAINT [PK_Compras_Renglones] PRIMARY KEY CLUSTERED ([id_comprasRenglones] ASC),
    CONSTRAINT [FK_Compras_Renglones_Compras] FOREIGN KEY ([id_compra]) REFERENCES [dbo].[Compras] ([id_compra]),
    CONSTRAINT [FK_Compras_Renglones_Productos] FOREIGN KEY ([Cod_Producto]) REFERENCES [dbo].[Productos] ([Cod_Producto])
);

