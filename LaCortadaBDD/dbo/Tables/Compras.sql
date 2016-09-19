CREATE TABLE [dbo].[Compras] (
    [id_compra]            INT             IDENTITY (1, 1) NOT NULL,
    [id_proveedor]         INT             NOT NULL,
    [Tipo_Comprobante]     SMALLINT        NOT NULL,
    [Nro_Movimiento]       INT             NOT NULL,
    [Nro_Comprobante]      INT             NOT NULL,
    [Punto_Venta_Comp]     NVARCHAR (25)   NOT NULL,
    [Fecha]                DATE            NOT NULL,
    [Porcentaje_Descuento] SMALLINT        NOT NULL,
    [Importe_Descuento]    DECIMAL (10, 2) NOT NULL,
    [Importe_IVA]          DECIMAL (10, 2) NOT NULL,
    [Importe_Total]        DECIMAL (10, 2) NOT NULL,
    [Pagado]               BIT             NOT NULL,
    [Fecha_Pago]           DATE            NULL,
    CONSTRAINT [PK_Compras_1] PRIMARY KEY CLUSTERED ([id_compra] ASC),
    CONSTRAINT [FK_Compras_Cajas] FOREIGN KEY ([Nro_Movimiento]) REFERENCES [dbo].[Cajas] ([Nro_Movimiento]),
    CONSTRAINT [FK_Compras_Proveedores] FOREIGN KEY ([id_proveedor]) REFERENCES [dbo].[Proveedores] ([id_proveedor]),
    CONSTRAINT [FK_Compras_Tipo_Comprobante] FOREIGN KEY ([Tipo_Comprobante]) REFERENCES [dbo].[Tipo_Comprobante] ([Tipo_Comprobante])
);

