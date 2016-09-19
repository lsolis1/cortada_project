CREATE TABLE [dbo].[Turnos] (
    [id_turno]     INT      IDENTITY (1, 1) NOT NULL,
    [id_cliente]   INT      NOT NULL,
    [Nro_Empleado] TINYINT  NOT NULL,
    [Cod_Cancha]   TINYINT  NOT NULL,
    [Tipo_turno]   TINYINT  NOT NULL,
    [Fecha]        DATE     NOT NULL,
    [Hora]         TIME (7) NOT NULL,
    [Estado]       TINYINT  NOT NULL,
    CONSTRAINT [PK_Turnos_1] PRIMARY KEY CLUSTERED ([id_turno] ASC),
    CONSTRAINT [FK_Turnos_Canchas] FOREIGN KEY ([Cod_Cancha]) REFERENCES [dbo].[Canchas] ([Cod_Cancha]),
    CONSTRAINT [FK_Turnos_Clientes] FOREIGN KEY ([id_cliente]) REFERENCES [dbo].[Clientes] ([id_cliente]),
    CONSTRAINT [FK_Turnos_Empleados] FOREIGN KEY ([Nro_Empleado]) REFERENCES [dbo].[Empleados] ([Nro_Empleado]),
    CONSTRAINT [FK_Turnos_Estado_Turno] FOREIGN KEY ([Estado]) REFERENCES [dbo].[Estado_Turno] ([Estado]),
    CONSTRAINT [FK_Turnos_Tipos_Turno] FOREIGN KEY ([Tipo_turno]) REFERENCES [dbo].[Tipos_Turno] ([Tipo_turno])
);

