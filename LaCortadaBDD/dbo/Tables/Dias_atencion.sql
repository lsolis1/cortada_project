CREATE TABLE [dbo].[Dias_atencion] (
    [id_dia]           TINYINT       IDENTITY (1, 1) NOT NULL,
    [nombre_dia]       NVARCHAR (25) NOT NULL,
    [hora_mañana]      TIME (7)      NULL,
    [fin_hora_mañana]  TIME (7)      NULL,
    [hora_tarde]       TIME (7)      NOT NULL,
    [fin_hora_tarde]   TIME (7)      NOT NULL,
    [id_configuracion] SMALLINT      NOT NULL,
    CONSTRAINT [PK_Dias_atencion] PRIMARY KEY CLUSTERED ([id_dia] ASC),
    CONSTRAINT [FK_Dias_atencion_Configuracion] FOREIGN KEY ([id_configuracion]) REFERENCES [dbo].[Configuracion] ([id_configuracion])
);

