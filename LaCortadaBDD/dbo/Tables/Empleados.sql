CREATE TABLE [dbo].[Empleados] (
    [Nro_Empleado] TINYINT       IDENTITY (2, 1) NOT NULL,
    [Nro_Doc]      BIGINT        NOT NULL,
    [Tipo_Doc]     TINYINT       NOT NULL,
    [Nombre]       NVARCHAR (15) NOT NULL,
    [Apellido]     NVARCHAR (15) NOT NULL,
    [Telefono]     NVARCHAR (50) NULL,
    [Celular]      NVARCHAR (50) NULL,
    [Mail]         NVARCHAR (35) NULL,
    [Domicilio]    NVARCHAR (20) NOT NULL,
    [Cod_Postal]   SMALLINT      NOT NULL,
    CONSTRAINT [PK_Empleados_1] PRIMARY KEY CLUSTERED ([Nro_Empleado] ASC),
    CONSTRAINT [FK_Empleados_Ciudades] FOREIGN KEY ([Cod_Postal]) REFERENCES [dbo].[Ciudades] ([Cod_Postal]),
    CONSTRAINT [FK_Empleados_Tipos_Documento] FOREIGN KEY ([Tipo_Doc]) REFERENCES [dbo].[Tipos_Documento] ([Tipo_Doc])
);

