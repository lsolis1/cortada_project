CREATE TABLE [dbo].[Tipos_Turno] (
    [Tipo_turno]  TINYINT       IDENTITY (1, 1) NOT NULL,
    [Descripcion] NVARCHAR (15) NOT NULL,
    CONSTRAINT [PK_Tipos_Turno] PRIMARY KEY CLUSTERED ([Tipo_turno] ASC)
);

