CREATE TABLE [dbo].[Login] (
    [id_login]     INT           IDENTITY (1, 1) NOT NULL,
    [Nro_Empleado] TINYINT       NOT NULL,
    [username]     NVARCHAR (50) NOT NULL,
    [password]     NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Login_1] PRIMARY KEY CLUSTERED ([id_login] ASC),
    CONSTRAINT [FK_Login_Empleados] FOREIGN KEY ([Nro_Empleado]) REFERENCES [dbo].[Empleados] ([Nro_Empleado])
);

