CREATE TABLE [dbo].[Proveedores] (
    [id_proveedor]   INT           IDENTITY (1, 1) NOT NULL,
    [CUIT_Proveedor] NVARCHAR (13) NOT NULL,
    [Nombre]         NVARCHAR (25) NOT NULL,
    [Telefono]       NVARCHAR (50) NOT NULL,
    [Mail]           NVARCHAR (30) NULL,
    [Domicilio]      NVARCHAR (20) NULL,
    [Cod_Postal]     SMALLINT      NOT NULL,
    CONSTRAINT [PK_Proveedores_1] PRIMARY KEY CLUSTERED ([id_proveedor] ASC),
    CONSTRAINT [FK_Proveedores_Ciudades] FOREIGN KEY ([Cod_Postal]) REFERENCES [dbo].[Ciudades] ([Cod_Postal])
);

