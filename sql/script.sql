USE [master]
GO
/****** Object:  Database [LaCortada]    Script Date: 10/3/2016 1:34:08 PM ******/
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
/****** Object:  Table [dbo].[Cajas]    Script Date: 10/3/2016 1:34:08 PM ******/
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
/****** Object:  Table [dbo].[Canchas]    Script Date: 10/3/2016 1:34:08 PM ******/
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
/****** Object:  Table [dbo].[Ciudades]    Script Date: 10/3/2016 1:34:08 PM ******/
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
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/3/2016 1:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_Doc] [tinyint] NOT NULL,
	[Nro_Doc] [bigint] NOT NULL,
	[Nombre] [nvarchar](20) NOT NULL,
	[Apellido] [nvarchar](15) NOT NULL,
	[Mail] [nvarchar](30) NULL,
	[Celular] [nvarchar](50) NOT NULL,
	[Domicilio] [nvarchar](20) NOT NULL,
	[Cod_Postal] [smallint] NOT NULL,
	[Fecha_Baja] [datetime] NULL,
 CONSTRAINT [PK_Clientes_1] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UNIQUE_Clientes] UNIQUE NONCLUSTERED 
(
	[Tipo_Doc] ASC,
	[Nro_Doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Compras]    Script Date: 10/3/2016 1:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[id_compra] [int] IDENTITY(1,1) NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[Tipo_Comprobante] [smallint] NOT NULL,
	[Nro_Movimiento] [int] NOT NULL,
	[Nro_Comprobante] [int] NOT NULL,
	[Punto_Venta_Comp] [nvarchar](25) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Porcentaje_Descuento] [smallint] NOT NULL,
	[Importe_Descuento] [decimal](10, 2) NOT NULL,
	[Importe_IVA] [decimal](10, 2) NOT NULL,
	[Importe_Total] [decimal](10, 2) NOT NULL,
	[Pagado] [bit] NOT NULL,
	[Fecha_Pago] [date] NULL,
 CONSTRAINT [PK_Compras_1] PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UNIQUE_Compras] UNIQUE NONCLUSTERED 
(
	[Tipo_Comprobante] ASC,
	[Nro_Comprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Compras_Renglones]    Script Date: 10/3/2016 1:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras_Renglones](
	[id_comprasRenglones] [int] IDENTITY(1,1) NOT NULL,
	[id_compra] [int] NOT NULL,
	[Cod_Producto] [int] NOT NULL,
	[Nro_Linea_Producto] [smallint] NOT NULL,
	[Cantidad] [smallint] NOT NULL,
	[Porcentaje_Desc] [smallint] NULL,
	[Importe_Desc] [int] NULL,
	[Porcentaje_IVA] [smallint] NOT NULL,
	[Importe_Total] [int] NOT NULL,
 CONSTRAINT [PK_Compras_Renglones] PRIMARY KEY CLUSTERED 
(
	[id_comprasRenglones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Configuracion]    Script Date: 10/3/2016 1:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Configuracion](
	[id_configuracion] [smallint] NOT NULL,
	[nombre_compejo] [nvarchar](30) NOT NULL,
	[direccion] [nvarchar](40) NOT NULL,
	[telefono] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_Configuracion] PRIMARY KEY CLUSTERED 
(
	[id_configuracion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dias_atencion]    Script Date: 10/3/2016 1:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dias_atencion](
	[id_dia] [tinyint] IDENTITY(1,1) NOT NULL,
	[nombre_dia] [nvarchar](25) NOT NULL,
	[hora_mañana] [time](0) NULL,
	[fin_hora_mañana] [time](0) NULL,
	[hora_tarde] [time](0) NOT NULL,
	[fin_hora_tarde] [time](0) NOT NULL,
 CONSTRAINT [PK_Dias_atencion] PRIMARY KEY CLUSTERED 
(
	[id_dia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dias_cancelados]    Script Date: 10/3/2016 1:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dias_cancelados](
	[id_feriado] [int] IDENTITY(1,1) NOT NULL,
	[fecha_feriado] [date] NOT NULL,
	[motivo] [nvarchar](300) NOT NULL,
	[cancelar] [datetime] NULL,
 CONSTRAINT [PK_Dias_cancelados] PRIMARY KEY CLUSTERED 
(
	[id_feriado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 10/3/2016 1:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Nro_Empleado] [tinyint] IDENTITY(2,1) NOT NULL,
	[Nro_Doc] [bigint] NOT NULL,
	[Tipo_Doc] [tinyint] NOT NULL,
	[Nombre] [nvarchar](15) NOT NULL,
	[Apellido] [nvarchar](15) NOT NULL,
	[Telefono] [nvarchar](50) NULL,
	[Celular] [nvarchar](50) NULL,
	[Mail] [nvarchar](35) NULL,
	[Domicilio] [nvarchar](20) NOT NULL,
	[Cod_Postal] [smallint] NOT NULL,
	[Fecha_Baja] [datetime] NULL,
 CONSTRAINT [PK_Empleados_1] PRIMARY KEY CLUSTERED 
(
	[Nro_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Estado_Turno]    Script Date: 10/3/2016 1:34:08 PM ******/
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
/****** Object:  Table [dbo].[Lista_Espera]    Script Date: 10/3/2016 1:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lista_Espera](
	[id_listaEspera] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[Nro_Movimiento] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Hora] [time](7) NOT NULL,
	[Fecha_baja] [datetime] NULL,
 CONSTRAINT [PK_Lista_Espera_1] PRIMARY KEY CLUSTERED 
(
	[id_listaEspera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: 10/3/2016 1:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[id_login] [int] IDENTITY(1,1) NOT NULL,
	[Nro_Empleado] [tinyint] NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Login_1] PRIMARY KEY CLUSTERED 
(
	[id_login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 10/3/2016 1:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[Cod_Marca] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[Cod_Marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Productos]    Script Date: 10/3/2016 1:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Cod_Producto] [int] IDENTITY(1,1) NOT NULL,
	[id_proveedor] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Proveedores]    Script Date: 10/3/2016 1:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[CUIT_Proveedor] [nvarchar](13) NOT NULL,
	[Nombre] [nvarchar](25) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[Mail] [nvarchar](30) NULL,
	[Domicilio] [nvarchar](20) NULL,
	[Cod_Postal] [smallint] NOT NULL,
 CONSTRAINT [PK_Proveedores_1] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UNIQUE_Proveedores] UNIQUE NONCLUSTERED 
(
	[CUIT_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 10/3/2016 1:34:08 PM ******/
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
/****** Object:  Table [dbo].[Tipo_Comprobante]    Script Date: 10/3/2016 1:34:08 PM ******/
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
/****** Object:  Table [dbo].[Tipos_Documento]    Script Date: 10/3/2016 1:34:08 PM ******/
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
/****** Object:  Table [dbo].[Tipos_Turno]    Script Date: 10/3/2016 1:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos_Turno](
	[Tipo_turno] [tinyint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Tipos_Turno] PRIMARY KEY CLUSTERED 
(
	[Tipo_turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Turnos]    Script Date: 10/3/2016 1:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turnos](
	[id_turno] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[Nro_Empleado] [tinyint] NOT NULL,
	[Cod_Cancha] [tinyint] NOT NULL,
	[Tipo_turno] [tinyint] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Hora] [time](7) NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_Turnos_1] PRIMARY KEY CLUSTERED 
(
	[id_turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UNIQUE_Turnos] UNIQUE NONCLUSTERED 
(
	[Fecha] ASC,
	[Hora] ASC,
	[Cod_Cancha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Turnos_fijos]    Script Date: 10/3/2016 1:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turnos_fijos](
	[id_turno_fijo] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Cancha] [tinyint] NOT NULL,
	[Nro_Empleado] [tinyint] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_dia] [tinyint] NOT NULL,
	[hora] [time](7) NOT NULL,
	[Fecha_inicio] [date] NOT NULL,
	[Fecha_fin] [date] NULL,
 CONSTRAINT [PK_Turnos_fijos] PRIMARY KEY CLUSTERED 
(
	[id_turno_fijo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 10/3/2016 1:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[Tipo_Comprobante] [smallint] NOT NULL,
	[Nro_Comprobante] [int] NOT NULL,
	[Nro_Movimiento] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Porcentaje_Descuento] [smallint] NULL,
	[Total_Descuento] [int] NULL,
	[Total_General] [int] NOT NULL,
 CONSTRAINT [PK_Ventas_1] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UNIQUE_Ventas] UNIQUE NONCLUSTERED 
(
	[Nro_Comprobante] ASC,
	[Tipo_Comprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ventas_Lineas]    Script Date: 10/3/2016 1:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas_Lineas](
	[id_ventasLineas] [int] IDENTITY(1,1) NOT NULL,
	[id_venta] [int] NOT NULL,
	[Nro_Linea] [smallint] NOT NULL,
	[Cod_Producto] [int] NOT NULL,
	[Cantidad] [smallint] NOT NULL,
	[Porcentaje_Descuento] [smallint] NULL,
	[Importe_Descuento] [int] NULL,
	[Importe_Total] [int] NOT NULL,
 CONSTRAINT [PK_Ventas_Lineas_1] PRIMARY KEY CLUSTERED 
(
	[id_ventasLineas] ASC
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
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Proveedores] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[Proveedores] ([id_proveedor])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Proveedores]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Tipo_Comprobante] FOREIGN KEY([Tipo_Comprobante])
REFERENCES [dbo].[Tipo_Comprobante] ([Tipo_Comprobante])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Tipo_Comprobante]
GO
ALTER TABLE [dbo].[Compras_Renglones]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Renglones_Compras] FOREIGN KEY([id_compra])
REFERENCES [dbo].[Compras] ([id_compra])
GO
ALTER TABLE [dbo].[Compras_Renglones] CHECK CONSTRAINT [FK_Compras_Renglones_Compras]
GO
ALTER TABLE [dbo].[Compras_Renglones]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Renglones_Productos] FOREIGN KEY([Cod_Producto])
REFERENCES [dbo].[Productos] ([Cod_Producto])
GO
ALTER TABLE [dbo].[Compras_Renglones] CHECK CONSTRAINT [FK_Compras_Renglones_Productos]
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
ALTER TABLE [dbo].[Lista_Espera]  WITH CHECK ADD  CONSTRAINT [FK_Lista_Espera_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[Lista_Espera] CHECK CONSTRAINT [FK_Lista_Espera_Clientes]
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [FK_Login_Empleados] FOREIGN KEY([Nro_Empleado])
REFERENCES [dbo].[Empleados] ([Nro_Empleado])
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK_Login_Empleados]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Marcas] FOREIGN KEY([Cod_Marca])
REFERENCES [dbo].[Marcas] ([Cod_Marca])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Marcas]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Proveedores] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[Proveedores] ([id_proveedor])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Proveedores]
GO
ALTER TABLE [dbo].[Proveedores]  WITH CHECK ADD  CONSTRAINT [FK_Proveedores_Ciudades] FOREIGN KEY([Cod_Postal])
REFERENCES [dbo].[Ciudades] ([Cod_Postal])
GO
ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_Proveedores_Ciudades]
GO
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Canchas] FOREIGN KEY([Cod_Cancha])
REFERENCES [dbo].[Canchas] ([Cod_Cancha])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Canchas]
GO
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
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
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Tipos_Turno] FOREIGN KEY([Tipo_turno])
REFERENCES [dbo].[Tipos_Turno] ([Tipo_turno])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Tipos_Turno]
GO
ALTER TABLE [dbo].[Turnos_fijos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_fijos_Canchas] FOREIGN KEY([Cod_Cancha])
REFERENCES [dbo].[Canchas] ([Cod_Cancha])
GO
ALTER TABLE [dbo].[Turnos_fijos] CHECK CONSTRAINT [FK_Turnos_fijos_Canchas]
GO
ALTER TABLE [dbo].[Turnos_fijos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_fijos_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[Turnos_fijos] CHECK CONSTRAINT [FK_Turnos_fijos_Clientes]
GO
ALTER TABLE [dbo].[Turnos_fijos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_fijos_Dias_atencion] FOREIGN KEY([id_dia])
REFERENCES [dbo].[Dias_atencion] ([id_dia])
GO
ALTER TABLE [dbo].[Turnos_fijos] CHECK CONSTRAINT [FK_Turnos_fijos_Dias_atencion]
GO
ALTER TABLE [dbo].[Turnos_fijos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_fijos_Empleados] FOREIGN KEY([Nro_Empleado])
REFERENCES [dbo].[Empleados] ([Nro_Empleado])
GO
ALTER TABLE [dbo].[Turnos_fijos] CHECK CONSTRAINT [FK_Turnos_fijos_Empleados]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Cajas] FOREIGN KEY([Nro_Movimiento])
REFERENCES [dbo].[Cajas] ([Nro_Movimiento])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Cajas]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
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
ALTER TABLE [dbo].[Ventas_Lineas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Lineas_Ventas] FOREIGN KEY([id_venta])
REFERENCES [dbo].[Ventas] ([id_venta])
GO
ALTER TABLE [dbo].[Ventas_Lineas] CHECK CONSTRAINT [FK_Ventas_Lineas_Ventas]
GO
ALTER TABLE [dbo].[Dias_atencion]  WITH CHECK ADD  CONSTRAINT [CHK_DIAS_ATENCION] CHECK  (([id_dia]>(0) AND [id_dia]<(8)))
GO
ALTER TABLE [dbo].[Dias_atencion] CHECK CONSTRAINT [CHK_DIAS_ATENCION]
GO
USE [master]
GO
ALTER DATABASE [LaCortada] SET  READ_WRITE 
GO
