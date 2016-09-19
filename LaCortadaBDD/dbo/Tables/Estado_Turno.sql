CREATE TABLE [dbo].[Estado_Turno] (
    [Estado]      TINYINT       IDENTITY (1, 1) NOT NULL,
    [Descripcion] NVARCHAR (15) NOT NULL,
    CONSTRAINT [PK_Estado_Turno] PRIMARY KEY CLUSTERED ([Estado] ASC)
);

