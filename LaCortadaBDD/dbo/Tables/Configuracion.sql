CREATE TABLE [dbo].[Configuracion] (
    [id_configuracion] SMALLINT      NOT NULL,
    [id_dia]           TINYINT       NOT NULL,
    [id_feriado]       INT           NOT NULL,
    [nombre_compejo]   NVARCHAR (30) NOT NULL,
    [direccion]        NVARCHAR (40) NOT NULL,
    [telefono]         NVARCHAR (40) NOT NULL,
    CONSTRAINT [PK_Configuracion] PRIMARY KEY CLUSTERED ([id_configuracion] ASC)
);

