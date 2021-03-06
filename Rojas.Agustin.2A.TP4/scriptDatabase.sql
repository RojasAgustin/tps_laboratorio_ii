USE [master]
GO
/****** Object:  Database [TP_04]    Script Date: 15/06/2022 06:39:45 p. m. ******/
CREATE DATABASE [TP_04]
 
GO
ALTER DATABASE [TP_04] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP_04].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP_04] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP_04] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP_04] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP_04] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP_04] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP_04] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP_04] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP_04] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP_04] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP_04] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP_04] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP_04] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP_04] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP_04] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP_04] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP_04] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP_04] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP_04] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP_04] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP_04] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP_04] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP_04] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP_04] SET RECOVERY FULL 
GO
ALTER DATABASE [TP_04] SET  MULTI_USER 
GO
ALTER DATABASE [TP_04] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP_04] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP_04] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP_04] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP_04] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP_04] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TP_04', N'ON'
GO
ALTER DATABASE [TP_04] SET QUERY_STORE = OFF
GO
USE [TP_04]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 15/06/2022 06:39:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Codigo] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[PrecioCompra] [float] NOT NULL,
	[TituloCompra] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [Correo], [Direccion], [Telefono], [PrecioCompra], [TituloCompra]) VALUES (42848, N'Lisandro', N'Martinez', N'l1sandro@yahoo.com', N'Doctor Angel Rotta 132', N'155125124', 32, N'Meditaciones')
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [Correo], [Direccion], [Telefono], [PrecioCompra], [TituloCompra]) VALUES (56316, N'Gonzalo', N'Martinez', N'pitym@hotmail.com', N'Gorriti Gral Jose Ignacio 878', N'1557332218', 160, N'Dragon Ball Vol. 3')
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [Correo], [Direccion], [Telefono], [PrecioCompra], [TituloCompra]) VALUES (60813, N'Torres', N'Ferran', N'fdeT@gmail.com', N'F Ameghino 1159', N'2184812412', 75, N'Harry Potter y la piedra filosofal')
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [Correo], [Direccion], [Telefono], [PrecioCompra], [TituloCompra]) VALUES (67989, N'Willian', N'Dumais', N'wildoumai@yahoo.com', N'Bv. Pedro Ignacio Castro Barros 817', N'113171742', 64, N'Yo sé por qué canta el pájaro enjaulado')
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [Correo], [Direccion], [Telefono], [PrecioCompra], [TituloCompra]) VALUES (75839, N'Jesus', N'Corona', N'vc4881@gmail.com', N'Av. Almafuerte 677', N'518582414', 75, N'El principito')
GO
USE [master]
GO
ALTER DATABASE [TP_04] SET  READ_WRITE 
GO
