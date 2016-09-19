CREATE TABLE [dbo].[Cajas] (
    [Nro_Movimiento] INT            IDENTITY (1, 1) NOT NULL,
    [Nro_Empleado]   TINYINT        NOT NULL,
    [Fecha]          DATE           NOT NULL,
    [Hora_Inicio]    TIME (7)       NOT NULL,
    [Hora_Fin]       TIME (7)       NULL,
    [Importe_Inicio] DECIMAL (8, 2) NOT NULL,
    [Importe_Retiro] DECIMAL (8, 2) NULL,
    CONSTRAINT [PK_Cajas] PRIMARY KEY CLUSTERED ([Nro_Movimiento] ASC),
    CONSTRAINT [FK_Cajas_Empleados] FOREIGN KEY ([Nro_Empleado]) REFERENCES [dbo].[Empleados] ([Nro_Empleado])
);

