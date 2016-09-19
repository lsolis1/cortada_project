CREATE TABLE [dbo].[Productos] (
    [Cod_Producto]     INT            IDENTITY (1, 1) NOT NULL,
    [id_proveedor]     INT            NOT NULL,
    [Cod_Marca]        INT            NOT NULL,
    [Nombre]           NVARCHAR (30)  NOT NULL,
    [Precio_Venta]     DECIMAL (8, 2) NULL,
    [Precio_Mayorista] DECIMAL (8, 2) NOT NULL,
    [Stock]            INT            NOT NULL,
    [Stock_minimo]     SMALLINT       NULL,
    CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED ([Cod_Producto] ASC),
    CONSTRAINT [FK_Productos_Marcas] FOREIGN KEY ([Cod_Marca]) REFERENCES [dbo].[Marcas] ([Cod_Marca]),
    CONSTRAINT [FK_Productos_Proveedores] FOREIGN KEY ([id_proveedor]) REFERENCES [dbo].[Proveedores] ([id_proveedor])
);

