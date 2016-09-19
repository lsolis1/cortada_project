CREATE TABLE [dbo].[Lista_Espera] (
    [id_listaEspera] INT      IDENTITY (1, 1) NOT NULL,
    [id_cliente]     INT      NOT NULL,
    [Nro_Movimiento] INT      NOT NULL,
    [Fecha]          DATE     NOT NULL,
    [Hora]           TIME (7) NOT NULL,
    [Fecha_baja]     DATETIME NULL,
    CONSTRAINT [PK_Lista_Espera_1] PRIMARY KEY CLUSTERED ([id_listaEspera] ASC),
    CONSTRAINT [FK_Lista_Espera_Cajas] FOREIGN KEY ([Nro_Movimiento]) REFERENCES [dbo].[Cajas] ([Nro_Movimiento]),
    CONSTRAINT [FK_Lista_Espera_Clientes] FOREIGN KEY ([id_cliente]) REFERENCES [dbo].[Clientes] ([id_cliente])
);

