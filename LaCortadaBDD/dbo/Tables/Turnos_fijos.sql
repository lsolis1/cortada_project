CREATE TABLE [dbo].[Turnos_fijos] (
    [id_turno_fijo]    INT      IDENTITY (1, 1) NOT NULL,
    [Cod_Cancha]       TINYINT  NOT NULL,
    [Nro_Empleado]     TINYINT  NOT NULL,
    [id_cliente]       INT      NOT NULL,
    [hora]             TIME (7) NOT NULL,
    [dia]              TINYINT  NOT NULL,
    [Fecha_inicio]     DATE     NOT NULL,
    [Fecha_fin]        DATE     NULL,
    [id_configuracion] SMALLINT NOT NULL,
    CONSTRAINT [PK_Turnos_fijos] PRIMARY KEY CLUSTERED ([id_turno_fijo] ASC),
    CONSTRAINT [FK_Turnos_fijos_Configuracion] FOREIGN KEY ([id_configuracion]) REFERENCES [dbo].[Configuracion] ([id_configuracion])
);

