CREATE TABLE [dbo].[Canchas] (
    [Cod_Cancha]  TINYINT       IDENTITY (1, 1) NOT NULL,
    [Descripcion] NVARCHAR (15) NOT NULL,
    CONSTRAINT [PK_CANCHAS] PRIMARY KEY CLUSTERED ([Cod_Cancha] ASC)
);

