CREATE TABLE [dbo].[Dias_cancelados] (
    [id_feriado]       INT            IDENTITY (1, 1) NOT NULL,
    [fecha_feriado]    DATE           NOT NULL,
    [motivo]           NVARCHAR (100) NOT NULL,
    [cancelar]         DATETIME       NULL,
    [id_configuracion] SMALLINT       NOT NULL,
    CONSTRAINT [PK_Dias_cancelados] PRIMARY KEY CLUSTERED ([id_feriado] ASC),
    CONSTRAINT [FK_Dias_cancelados_Configuracion] FOREIGN KEY ([id_configuracion]) REFERENCES [dbo].[Configuracion] ([id_configuracion])
);

