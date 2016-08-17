USE [master]
GO
/****** Object:  Database [LaCortada]    Script Date: 8/17/2016 1:32:21 PM ******/
CREATE DATABASE [LaCortada]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LaCortada', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LaCortada.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LaCortada_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LaCortada_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LaCortada] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LaCortada].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LaCortada] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LaCortada] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LaCortada] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LaCortada] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LaCortada] SET ARITHABORT OFF 
GO
ALTER DATABASE [LaCortada] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LaCortada] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LaCortada] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LaCortada] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LaCortada] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LaCortada] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LaCortada] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LaCortada] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LaCortada] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LaCortada] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LaCortada] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LaCortada] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LaCortada] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LaCortada] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LaCortada] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LaCortada] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LaCortada] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LaCortada] SET RECOVERY FULL 
GO
ALTER DATABASE [LaCortada] SET  MULTI_USER 
GO
ALTER DATABASE [LaCortada] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LaCortada] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LaCortada] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LaCortada] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [LaCortada] SET DELAYED_DURABILITY = DISABLED 
GO
USE [LaCortada]
GO
/****** Object:  Table [dbo].[Cajas]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cajas](
	[Nro_Movimiento] [int] IDENTITY(1,1) NOT NULL,
	[Nro_Empleado] [tinyint] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Hora_Inicio] [time](7) NOT NULL,
	[Hora_Fin] [time](7) NULL,
	[Importe_Inicio] [decimal](8, 2) NOT NULL,
	[Importe_Retiro] [decimal](8, 2) NULL,
 CONSTRAINT [PK_Cajas] PRIMARY KEY CLUSTERED 
(
	[Nro_Movimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Canchas]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Canchas](
	[Cod_Cancha] [tinyint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_CANCHAS] PRIMARY KEY CLUSTERED 
(
	[Cod_Cancha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ciudades]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudades](
	[Cod_Postal] [smallint] NOT NULL,
	[Cod_Provincia] [tinyint] NOT NULL,
	[Nombre] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Ciudades] PRIMARY KEY CLUSTERED 
(
	[Cod_Postal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Tipo_Doc] [tinyint] NOT NULL,
	[Nro_Doc] [int] NOT NULL,
	[Nombre] [nvarchar](20) NOT NULL,
	[Apellido] [nvarchar](15) NOT NULL,
	[Mail] [nvarchar](30) NULL,
	[Celular] [int] NOT NULL,
	[Domicilio] [nvarchar](20) NOT NULL,
	[Cod_Postal] [smallint] NOT NULL,
	[Cod_Provincia] [tinyint] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Tipo_Doc] ASC,
	[Nro_Doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Compras]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[CUIT_Proveedor] [nvarchar](13) NOT NULL,
	[Nro_Comprobante] [int] NOT NULL,
	[Tipo_Comprobante] [smallint] NOT NULL,
	[Punto_Venta_Comp] [nvarchar](25) NOT NULL,
	[Nro_Movimiento] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Porcentaje_Descuento] [smallint] NOT NULL,
	[Importe_Descuento] [decimal](10, 2) NOT NULL,
	[Importe_IVA] [decimal](10, 2) NOT NULL,
	[Importe_Total] [decimal](10, 2) NOT NULL,
	[Pagado] [bit] NOT NULL,
	[Fecha_Pago] [date] NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[CUIT_Proveedor] ASC,
	[Nro_Comprobante] ASC,
	[Tipo_Comprobante] ASC,
	[Punto_Venta_Comp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Compras_Renglones]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras_Renglones](
	[Nro_Comprobante] [int] NOT NULL,
	[Tipo_Comprobante] [smallint] NOT NULL,
	[CUIT_Proveedor] [nvarchar](13) NOT NULL,
	[Punto_Venta_Comp] [nvarchar](25) NOT NULL,
	[Nro_Linea_Producto] [smallint] NOT NULL,
	[Cod_Producto] [int] NOT NULL,
	[Cantidad] [smallint] NOT NULL,
	[Porcentaje_Desc] [smallint] NULL,
	[Importe_Desc] [int] NULL,
	[Porcentaje_IVA] [smallint] NOT NULL,
	[Importe_Total] [int] NOT NULL,
 CONSTRAINT [PK_Compras_Renglones] PRIMARY KEY CLUSTERED 
(
	[Nro_Comprobante] ASC,
	[Tipo_Comprobante] ASC,
	[CUIT_Proveedor] ASC,
	[Punto_Venta_Comp] ASC,
	[Nro_Linea_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Nro_Empleado] [tinyint] IDENTITY(2,1) NOT NULL,
	[Nro_Doc] [int] NOT NULL,
	[Tipo_Doc] [tinyint] NOT NULL,
	[Nombre] [nvarchar](15) NOT NULL,
	[Apellido] [nvarchar](15) NOT NULL,
	[Telefono] [int] NULL,
	[Celular] [int] NULL,
	[Mail] [nvarchar](25) NULL,
	[Domicilio] [nvarchar](20) NOT NULL,
	[Cod_Provincia] [tinyint] NOT NULL,
	[Cod_Postal] [smallint] NOT NULL,
 CONSTRAINT [PK_Empleados_1] PRIMARY KEY CLUSTERED 
(
	[Nro_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Estado_Turno]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_Turno](
	[Estado] [tinyint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Estado_Turno] PRIMARY KEY CLUSTERED 
(
	[Estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lista_Espera]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lista_Espera](
	[Tipo_Doc] [tinyint] NOT NULL,
	[Nro_Doc] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Hora] [time](7) NOT NULL,
	[Nro_Movimiento] [int] NOT NULL,
	[Fecha_baja] [datetime] NULL,
 CONSTRAINT [PK_Lista_Espera] PRIMARY KEY CLUSTERED 
(
	[Tipo_Doc] ASC,
	[Nro_Doc] ASC,
	[Fecha] ASC,
	[Hora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[Cod_Marca] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[Cod_Marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Productos]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Cod_Producto] [int] IDENTITY(1,1) NOT NULL,
	[CUIT_Proveedor] [nvarchar](13) NOT NULL,
	[Cod_Marca] [int] NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
	[Precio_Venta] [decimal](8, 2) NULL,
	[Precio_Mayorista] [decimal](8, 2) NOT NULL,
	[Stock] [int] NOT NULL,
	[Stock_minimo] [smallint] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[Cod_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[CUIT_Proveedor] [nvarchar](13) NOT NULL,
	[Nombre] [nvarchar](25) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Mail] [nvarchar](30) NULL,
	[Domicilio] [nvarchar](20) NULL,
	[Cod_Postal] [smallint] NOT NULL,
	[Cod_Provincnia] [tinyint] NOT NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[CUIT_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[Cod_Provincia] [tinyint] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED 
(
	[Cod_Provincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Temas]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temas](
	[Fecha] [datetime] NOT NULL,
	[Nro_Empleado] [tinyint] NOT NULL,
	[id_tema] [tinyint] NOT NULL,
 CONSTRAINT [PK_Temas] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[Nro_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tipo_Comprobante]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Comprobante](
	[Tipo_Comprobante] [smallint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Tipo_Comprobante] PRIMARY KEY CLUSTERED 
(
	[Tipo_Comprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tipos_Documento]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos_Documento](
	[Tipo_Doc] [tinyint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Tipos_Documento] PRIMARY KEY CLUSTERED 
(
	[Tipo_Doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tipos_Turno]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos_Turno](
	[Tipo_turno] [tinyint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Tipos_Turno] PRIMARY KEY CLUSTERED 
(
	[Tipo_turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Turnos]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turnos](
	[Tipo_Doc] [tinyint] NOT NULL,
	[Nro_Doc] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Hora] [time](7) NOT NULL,
	[Nro_Empleado] [tinyint] NOT NULL,
	[Cod_Cancha] [tinyint] NOT NULL,
	[Tipo_turno] [tinyint] NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_Turnos] PRIMARY KEY CLUSTERED 
(
	[Tipo_Doc] ASC,
	[Nro_Doc] ASC,
	[Fecha] ASC,
	[Hora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[Tipo_Comprobante] [smallint] NOT NULL,
	[Nro_Comprobante] [int] IDENTITY(1,1) NOT NULL,
	[Nro_Movimiento] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Tipo_Doc] [tinyint] NOT NULL,
	[Nro_Doc] [int] NOT NULL,
	[Porcentaje_Descuento] [smallint] NULL,
	[Total_Descuento] [int] NULL,
	[Total_General] [int] NOT NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[Tipo_Comprobante] ASC,
	[Nro_Comprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ventas_Lineas]    Script Date: 8/17/2016 1:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas_Lineas](
	[Nro_Comprobante] [int] NOT NULL,
	[Tipo_Comprobante] [smallint] NOT NULL,
	[Nro_Linea] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Producto] [int] NOT NULL,
	[Cantidad] [smallint] NOT NULL,
	[Porcentaje_Descuento] [smallint] NULL,
	[Importe_Descuento] [int] NULL,
	[Importe_Total] [int] NOT NULL,
 CONSTRAINT [PK_Ventas_Lineas] PRIMARY KEY CLUSTERED 
(
	[Nro_Comprobante] ASC,
	[Tipo_Comprobante] ASC,
	[Nro_Linea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Cajas]  WITH CHECK ADD  CONSTRAINT [FK_Cajas_Empleados] FOREIGN KEY([Nro_Empleado])
REFERENCES [dbo].[Empleados] ([Nro_Empleado])
GO
ALTER TABLE [dbo].[Cajas] CHECK CONSTRAINT [FK_Cajas_Empleados]
GO
ALTER TABLE [dbo].[Ciudades]  WITH CHECK ADD  CONSTRAINT [FK_Ciudades_Provincias] FOREIGN KEY([Cod_Provincia])
REFERENCES [dbo].[Provincias] ([Cod_Provincia])
GO
ALTER TABLE [dbo].[Ciudades] CHECK CONSTRAINT [FK_Ciudades_Provincias]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Ciudades] FOREIGN KEY([Cod_Postal])
REFERENCES [dbo].[Ciudades] ([Cod_Postal])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Ciudades]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Tipos_Documento] FOREIGN KEY([Tipo_Doc])
REFERENCES [dbo].[Tipos_Documento] ([Tipo_Doc])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Tipos_Documento]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Cajas] FOREIGN KEY([Nro_Movimiento])
REFERENCES [dbo].[Cajas] ([Nro_Movimiento])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Cajas]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Proveedores] FOREIGN KEY([CUIT_Proveedor])
REFERENCES [dbo].[Proveedores] ([CUIT_Proveedor])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Proveedores]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Tipo_Comprobante] FOREIGN KEY([Tipo_Comprobante])
REFERENCES [dbo].[Tipo_Comprobante] ([Tipo_Comprobante])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Tipo_Comprobante]
GO
ALTER TABLE [dbo].[Compras_Renglones]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Renglones_Compras] FOREIGN KEY([CUIT_Proveedor], [Nro_Comprobante], [Tipo_Comprobante], [Punto_Venta_Comp])
REFERENCES [dbo].[Compras] ([CUIT_Proveedor], [Nro_Comprobante], [Tipo_Comprobante], [Punto_Venta_Comp])
GO
ALTER TABLE [dbo].[Compras_Renglones] CHECK CONSTRAINT [FK_Compras_Renglones_Compras]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Ciudades] FOREIGN KEY([Cod_Postal])
REFERENCES [dbo].[Ciudades] ([Cod_Postal])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Ciudades]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Tipos_Documento] FOREIGN KEY([Tipo_Doc])
REFERENCES [dbo].[Tipos_Documento] ([Tipo_Doc])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Tipos_Documento]
GO
ALTER TABLE [dbo].[Lista_Espera]  WITH CHECK ADD  CONSTRAINT [FK_Lista_Espera_Cajas] FOREIGN KEY([Nro_Movimiento])
REFERENCES [dbo].[Cajas] ([Nro_Movimiento])
GO
ALTER TABLE [dbo].[Lista_Espera] CHECK CONSTRAINT [FK_Lista_Espera_Cajas]
GO
ALTER TABLE [dbo].[Lista_Espera]  WITH CHECK ADD  CONSTRAINT [FK_Lista_Espera_Clientes] FOREIGN KEY([Tipo_Doc], [Nro_Doc])
REFERENCES [dbo].[Clientes] ([Tipo_Doc], [Nro_Doc])
GO
ALTER TABLE [dbo].[Lista_Espera] CHECK CONSTRAINT [FK_Lista_Espera_Clientes]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Marcas] FOREIGN KEY([Cod_Marca])
REFERENCES [dbo].[Marcas] ([Cod_Marca])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Marcas]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Proveedores] FOREIGN KEY([CUIT_Proveedor])
REFERENCES [dbo].[Proveedores] ([CUIT_Proveedor])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Proveedores]
GO
ALTER TABLE [dbo].[Temas]  WITH CHECK ADD  CONSTRAINT [FK_Temas_Empleados] FOREIGN KEY([Nro_Empleado])
REFERENCES [dbo].[Empleados] ([Nro_Empleado])
GO
ALTER TABLE [dbo].[Temas] CHECK CONSTRAINT [FK_Temas_Empleados]
GO
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Canchas] FOREIGN KEY([Cod_Cancha])
REFERENCES [dbo].[Canchas] ([Cod_Cancha])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Canchas]
GO
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Clientes] FOREIGN KEY([Tipo_Doc], [Nro_Doc])
REFERENCES [dbo].[Clientes] ([Tipo_Doc], [Nro_Doc])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Clientes]
GO
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Empleados] FOREIGN KEY([Nro_Empleado])
REFERENCES [dbo].[Empleados] ([Nro_Empleado])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Empleados]
GO
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Estado_Turno] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado_Turno] ([Estado])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Estado_Turno]
GO
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Tipos_Documento] FOREIGN KEY([Tipo_turno])
REFERENCES [dbo].[Tipos_Documento] ([Tipo_Doc])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Tipos_Documento]
GO
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Tipos_Turno] FOREIGN KEY([Tipo_turno])
REFERENCES [dbo].[Tipos_Turno] ([Tipo_turno])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Tipos_Turno]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Cajas] FOREIGN KEY([Nro_Movimiento])
REFERENCES [dbo].[Cajas] ([Nro_Movimiento])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Cajas]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Clientes] FOREIGN KEY([Tipo_Doc], [Nro_Doc])
REFERENCES [dbo].[Clientes] ([Tipo_Doc], [Nro_Doc])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Clientes]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Tipo_Comprobante] FOREIGN KEY([Tipo_Comprobante])
REFERENCES [dbo].[Tipo_Comprobante] ([Tipo_Comprobante])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Tipo_Comprobante]
GO
ALTER TABLE [dbo].[Ventas_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Lineas_Productos] FOREIGN KEY([Cod_Producto])
REFERENCES [dbo].[Productos] ([Cod_Producto])
GO
ALTER TABLE [dbo].[Ventas_Lineas] CHECK CONSTRAINT [FK_Ventas_Lineas_Productos]
GO
ALTER TABLE [dbo].[Ventas_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Lineas_Ventas] FOREIGN KEY([Tipo_Comprobante], [Nro_Comprobante])
REFERENCES [dbo].[Ventas] ([Tipo_Comprobante], [Nro_Comprobante])
GO
ALTER TABLE [dbo].[Ventas_Lineas] CHECK CONSTRAINT [FK_Ventas_Lineas_Ventas]
GO
USE [master]
GO
ALTER DATABASE [LaCortada] SET  READ_WRITE 
GO
