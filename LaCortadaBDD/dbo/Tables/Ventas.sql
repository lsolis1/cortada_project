CREATE TABLE [dbo].[Ventas] (
    [id_venta]             INT      IDENTITY (1, 1) NOT NULL,
    [id_cliente]           INT      NOT NULL,
    [Tipo_Comprobante]     SMALLINT NOT NULL,
    [Nro_Comprobante]      INT      NOT NULL,
    [Nro_Movimiento]       INT      NOT NULL,
    [Fecha]                DATE     NOT NULL,
    [Porcentaje_Descuento] SMALLINT NULL,
    [Total_Descuento]      INT      NULL,
    [Total_General]        INT      NOT NULL,
    CONSTRAINT [PK_Ventas_1] PRIMARY KEY CLUSTERED ([id_venta] ASC),
    CONSTRAINT [FK_Ventas_Cajas] FOREIGN KEY ([Nro_Movimiento]) REFERENCES [dbo].[Cajas] ([Nro_Movimiento]),
    CONSTRAINT [FK_Ventas_Clientes] FOREIGN KEY ([id_cliente]) REFERENCES [dbo].[Clientes] ([id_cliente]),
    CONSTRAINT [FK_Ventas_Tipo_Comprobante] FOREIGN KEY ([Tipo_Comprobante]) REFERENCES [dbo].[Tipo_Comprobante] ([Tipo_Comprobante])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Ventas_1]
    ON [dbo].[Ventas]([Tipo_Comprobante] ASC, [Nro_Comprobante] ASC);

