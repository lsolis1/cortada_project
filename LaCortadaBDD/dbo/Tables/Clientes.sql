CREATE TABLE [dbo].[Clientes] (
    [id_cliente] INT           IDENTITY (1, 1) NOT NULL,
    [Tipo_Doc]   TINYINT       NOT NULL,
    [Nro_Doc]    BIGINT        NOT NULL,
    [Nombre]     NVARCHAR (20) NOT NULL,
    [Apellido]   NVARCHAR (15) NOT NULL,
    [Mail]       NVARCHAR (30) NULL,
    [Celular]    NVARCHAR (50) NOT NULL,
    [Domicilio]  NVARCHAR (20) NOT NULL,
    [Cod_Postal] SMALLINT      NOT NULL,
    CONSTRAINT [PK_Clientes_1] PRIMARY KEY CLUSTERED ([id_cliente] ASC),
    CONSTRAINT [FK_Clientes_Ciudades] FOREIGN KEY ([Cod_Postal]) REFERENCES [dbo].[Ciudades] ([Cod_Postal]),
    CONSTRAINT [FK_Clientes_Tipos_Documento] FOREIGN KEY ([Tipo_Doc]) REFERENCES [dbo].[Tipos_Documento] ([Tipo_Doc])
);

