CREATE TABLE [dbo].[Ventas_Lineas] (
    [id_ventasLineas]      INT      IDENTITY (1, 1) NOT NULL,
    [id_venta]             INT      NOT NULL,
    [Nro_Linea]            SMALLINT NOT NULL,
    [Cod_Producto]         INT      NOT NULL,
    [Cantidad]             SMALLINT NOT NULL,
    [Porcentaje_Descuento] SMALLINT NULL,
    [Importe_Descuento]    INT      NULL,
    [Importe_Total]        INT      NOT NULL,
    CONSTRAINT [PK_Ventas_Lineas_1] PRIMARY KEY CLUSTERED ([id_ventasLineas] ASC),
    CONSTRAINT [FK_Ventas_Lineas_Productos] FOREIGN KEY ([Cod_Producto]) REFERENCES [dbo].[Productos] ([Cod_Producto]),
    CONSTRAINT [FK_Ventas_Lineas_Ventas] FOREIGN KEY ([id_venta]) REFERENCES [dbo].[Ventas] ([id_venta])
);

