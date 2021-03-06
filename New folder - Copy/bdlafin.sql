USE [master]
GO
/****** Object:  Database [eventtest]    Script Date: 30-Nov-19 5:06:40 PM ******/
CREATE DATABASE [eventtest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'eventtest', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\eventtest.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'eventtest_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\eventtest_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [eventtest] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [eventtest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [eventtest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [eventtest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [eventtest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [eventtest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [eventtest] SET ARITHABORT OFF 
GO
ALTER DATABASE [eventtest] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [eventtest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [eventtest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [eventtest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [eventtest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [eventtest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [eventtest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [eventtest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [eventtest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [eventtest] SET  ENABLE_BROKER 
GO
ALTER DATABASE [eventtest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [eventtest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [eventtest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [eventtest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [eventtest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [eventtest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [eventtest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [eventtest] SET RECOVERY FULL 
GO
ALTER DATABASE [eventtest] SET  MULTI_USER 
GO
ALTER DATABASE [eventtest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [eventtest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [eventtest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [eventtest] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [eventtest] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'eventtest', N'ON'
GO
ALTER DATABASE [eventtest] SET QUERY_STORE = OFF
GO
USE [eventtest]
GO
/****** Object:  UserDefinedFunction [dbo].[id_loc]    Script Date: 30-Nov-19 5:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[id_loc]( @n varchar )
returns varchar
as
begin

 declare @c  varchar(30)
  select @c ='select id_localisation from LOCALISATION where LOCALISATION.city='+@n
  return @c
end
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 30-Nov-19 5:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[id_admin] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](50) NULL,
	[prenom] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[imgLocation] [varchar](200) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[id_admin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EV_USER]    Script Date: 30-Nov-19 5:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EV_USER](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](30) NULL,
	[prenom] [varchar](30) NULL,
	[email] [varchar](50) NULL,
	[numerotel] [varchar](50) NULL,
	[interests] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[cin] [varchar](50) NULL,
	[zipCode] [int] NULL,
 CONSTRAINT [PK__EV_USER__D2D146370546C12C] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EVENEMENT]    Script Date: 30-Nov-19 5:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EVENEMENT](
	[id_ev] [int] IDENTITY(1,1) NOT NULL,
	[id_localisation] [int] NULL,
	[organisateur] [varchar](max) NULL,
	[startDate] [datetime] NULL,
	[endDate] [datetime] NULL,
	[description] [varchar](max) NULL,
	[image] [image] NULL,
	[nom_Ev] [varchar](50) NULL,
	[type_Ev] [varchar](50) NULL,
	[imglocation] [varchar](200) NULL,
	[event_approve] [bit] NULL,
	[event_Status] [varchar](50) NULL,
 CONSTRAINT [PK__EVENEMEN__00B7CEACBF7278DC] PRIMARY KEY CLUSTERED 
(
	[id_ev] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Historique]    Script Date: 30-Nov-19 5:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historique](
	[id_Event] [int] NULL,
	[nomEvent] [varchar](50) NULL,
	[typeEvent] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LIKES]    Script Date: 30-Nov-19 5:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LIKES](
	[userID] [int] NULL,
	[eventID] [int] NULL,
	[nb] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_LIKES] PRIMARY KEY CLUSTERED 
(
	[nb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOCALISATION]    Script Date: 30-Nov-19 5:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOCALISATION](
	[id_city] [int] IDENTITY(1,1) NOT NULL,
	[city] [varchar](max) NULL,
	[adress] [varchar](max) NULL,
	[codepostal] [varchar](50) NULL,
 CONSTRAINT [PK__LOCALISA__6AEC3C613AB00F69] PRIMARY KEY CLUSTERED 
(
	[id_city] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PURCHAS]    Script Date: 30-Nov-19 5:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PURCHAS](
	[id_chaire] [int] IDENTITY(1,1) NOT NULL,
	[id_user] [int] NULL,
	[id_ev] [int] NULL,
 CONSTRAINT [PK_PURCHAS] PRIMARY KEY CLUSTERED 
(
	[id_chaire] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TICKETSTOCK]    Script Date: 30-Nov-19 5:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TICKETSTOCK](
	[id_evticket] [int] NOT NULL,
	[t_available] [varchar](50) NULL,
	[t_taken] [varchar](50) NULL,
	[Prix_ticket] [varchar](50) NULL,
 CONSTRAINT [PK__TICKETST__95B7BF8AE490BE13] PRIMARY KEY CLUSTERED 
(
	[id_evticket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([id_admin], [nom], [prenom], [email], [password], [imgLocation]) VALUES (1, NULL, NULL, N'Enter UserName', N'Enter UserName', NULL)
INSERT [dbo].[Admin] ([id_admin], [nom], [prenom], [email], [password], [imgLocation]) VALUES (2, N'oussama', N'ouardini', N'ouss.ouardini@gmail.com', N'ouss.ouardini@gmail.com', NULL)
SET IDENTITY_INSERT [dbo].[Admin] OFF
SET IDENTITY_INSERT [dbo].[EV_USER] ON 

INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (48, N'', N'', N'', N'', N'', N'', N'', 6)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (49, N'', N'', N'6by', N'', N'', N'', N'6', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (50, N'', N'', N'6cby', N'', N'', N'', N'6', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (51, N'entrer votre nom', N'entrer votre Prenom', N'entrer votre adresse Email', N'entrer votre tel', N'e-commerce', N'entrer votre mot de passe', N'entrer votre cin', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (52, N'entrer votre nom', N'entrer votre Prenom', N'vfdcsvd', N'entrer votre tel', N'e-commerce', N'entrer votre mot de passe', N'entrer votre cin', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (53, N'ouardini', N'oussama', N'ouss.ouardini@gmail.com', N'0668987480', N'e-commerce', N'ouss.ouardini@gmail.com', N'3645569', 86150)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (54, N'oussama', N'ouardini', N'invent.succes@gmail.com', N'58962xs', N'Music', N'668985321', N'8962', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (55, N'qzcscqs', N'cqszcqs', N'czscs', N'ccqsqc', N'Conférences de presse', N'cccc', N'962', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (56, N'rscd', N'cse', N'csdcd', N'cdcd', N'Conférences de presse', N'cdcd', N'cdcddc', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (57, N'gvdfc ', N'vdfgc x', N'vsfdcx', N'vsfdvsd', N'Conférences de presse', N'vfsdxc', N'vfsd', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (58, N'cqscq', N'qc', N'cqs', N'cqs', N'Conférences de presse', N'cqs', N'cqqcs', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (59, N'gvdfcx', N'vsdf', N'vsd', N'vsd', N'Conférences de presse', N'vsd', N'vsd', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (60, N'fecd', N'ced', N'cedscsd', N'cdcddc', N'Conférences de presse', N'cscs', N'csdcds', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (61, N'oussama', N'ouardini', N'tatawi@gmail.com', N'+212637688866', N'Conférences de sports', N'2001', N'jy36120', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (62, N'oussama', N'ouardini', N'tatawiv@gmail.com', N'+212637688866', N'Conférences de sports', N'2001', N'jy36120', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (63, N'fsd', N'frfr', N'frerf', N'frrf', N'Conférences de presse', N'Enter votrfrfre', N'frf', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (64, N'fd', N'ffdd', N'sss', N'ffd', N'Conférences de presse', N'csf', N'fdf', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (65, N'dzs', N'frerf', N'oussama.ouardini@gmail.com', N'sdvdfs', N'Conférences de presse', N'vdf', N'sdfs', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (66, N'vsdf', N'dscd', N'cdsdc', N'cscdcsd', N'Conférences de presse', N'Enter csddcvotre', N'csdds', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (67, N'a', N'a', N'huhuisd@gmail.com', N'a', N'Conférences de presse', N'Enter votre', N'a', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (68, N'cds', N'csd', N'invent@gmail.com', N'csd', N'Conférences de presse', N'Enter vocdtre', N'cds', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (69, N'xs', N'xqs', N'xqs@gmail.com', N'xqq', N'Conférences de presse', N'Enterxq votre', N'xq', 0)
INSERT [dbo].[EV_USER] ([id_user], [nom], [prenom], [email], [numerotel], [interests], [password], [cin], [zipCode]) VALUES (70, N'sd', N'cds', N'csddc@gmail.com', N'dc', N'Conférences de presse', N'Enter votreddd', N'ddd', 0)
SET IDENTITY_INSERT [dbo].[EV_USER] OFF
SET IDENTITY_INSERT [dbo].[EVENEMENT] ON 

INSERT [dbo].[EVENEMENT] ([id_ev], [id_localisation], [organisateur], [startDate], [endDate], [description], [image], [nom_Ev], [type_Ev], [imglocation], [event_approve], [event_Status]) VALUES (470, 67, N'State', CAST(N'2019-11-22T21:46:26.000' AS DateTime), CAST(N'2019-11-25T21:46:00.000' AS DateTime), N'', 0x40696D61676573, N'Enter the event name', N'Music', N'F:\oussama\Coffre\oussama\famille\20150824_104844.jpg', 1, NULL)
INSERT [dbo].[EVENEMENT] ([id_ev], [id_localisation], [organisateur], [startDate], [endDate], [description], [image], [nom_Ev], [type_Ev], [imglocation], [event_approve], [event_Status]) VALUES (471, 68, N'State', CAST(N'2019-11-22T21:46:26.000' AS DateTime), CAST(N'2019-11-25T21:46:00.000' AS DateTime), N'', 0x40696D61676573, N'Enter the event name', N'Music', N'F:\oussama\Coffre\oussama\famille\20150824_104844.jpg', 1, NULL)
INSERT [dbo].[EVENEMENT] ([id_ev], [id_localisation], [organisateur], [startDate], [endDate], [description], [image], [nom_Ev], [type_Ev], [imglocation], [event_approve], [event_Status]) VALUES (472, 69, N'State', CAST(N'2019-11-22T21:46:26.000' AS DateTime), CAST(N'2019-11-25T21:46:00.000' AS DateTime), N'', 0x40696D61676573, N'Enter the event name', N'Music', N'F:\oussama\Coffre\oussama\famille\20150824_104844.jpg', 1, NULL)
INSERT [dbo].[EVENEMENT] ([id_ev], [id_localisation], [organisateur], [startDate], [endDate], [description], [image], [nom_Ev], [type_Ev], [imglocation], [event_approve], [event_Status]) VALUES (473, 70, N'State', CAST(N'2019-11-22T21:46:26.000' AS DateTime), CAST(N'2019-11-25T21:46:00.000' AS DateTime), N'', 0x40696D61676573, N'Enter the event name', N'Music', N'F:\oussama\Coffre\oussama\famille\20150824_104844.jpg', 1, NULL)
INSERT [dbo].[EVENEMENT] ([id_ev], [id_localisation], [organisateur], [startDate], [endDate], [description], [image], [nom_Ev], [type_Ev], [imglocation], [event_approve], [event_Status]) VALUES (474, 71, N'State', CAST(N'2019-11-22T21:46:26.000' AS DateTime), CAST(N'2019-11-25T21:46:00.000' AS DateTime), N'dazqc', 0x40696D61676573, N'Enter the event name', N'Music', N'F:\oussama\Coffre\oussama\famille\20150824_104844.jpg', 1, NULL)
INSERT [dbo].[EVENEMENT] ([id_ev], [id_localisation], [organisateur], [startDate], [endDate], [description], [image], [nom_Ev], [type_Ev], [imglocation], [event_approve], [event_Status]) VALUES (475, 72, N'Organisateur', CAST(N'2019-11-22T21:46:26.000' AS DateTime), CAST(N'2019-11-25T21:46:00.000' AS DateTime), N'', 0x40696D61676573, N'', N'', N'C:\Users\oussama ouardini\Desktop\S3\ds\GL\ecc710e5-1301-4d98-a6f9-955c5e746846.jpg', 1, NULL)
INSERT [dbo].[EVENEMENT] ([id_ev], [id_localisation], [organisateur], [startDate], [endDate], [description], [image], [nom_Ev], [type_Ev], [imglocation], [event_approve], [event_Status]) VALUES (476, 73, N'Organisateur', CAST(N'2019-11-22T21:46:26.000' AS DateTime), CAST(N'2019-11-25T21:46:00.000' AS DateTime), N'', 0x40696D61676573, N'', N'', N'C:\Users\oussama ouardini\Desktop\S3\ds\GL\ecc710e5-1301-4d98-a6f9-955c5e746846.jpg', 1, NULL)
INSERT [dbo].[EVENEMENT] ([id_ev], [id_localisation], [organisateur], [startDate], [endDate], [description], [image], [nom_Ev], [type_Ev], [imglocation], [event_approve], [event_Status]) VALUES (477, 74, N'Organisateur', CAST(N'2019-11-22T21:46:26.000' AS DateTime), CAST(N'2019-11-25T21:46:00.000' AS DateTime), N'', 0x40696D61676573, N'', N'', N'C:\Users\oussama ouardini\Desktop\S3\ds\GL\ecc710e5-1301-4d98-a6f9-955c5e746846.jpg', 1, NULL)
INSERT [dbo].[EVENEMENT] ([id_ev], [id_localisation], [organisateur], [startDate], [endDate], [description], [image], [nom_Ev], [type_Ev], [imglocation], [event_approve], [event_Status]) VALUES (478, 75, N'orange', CAST(N'2019-11-22T21:46:26.000' AS DateTime), CAST(N'2019-11-25T21:46:00.000' AS DateTime), N'Bunifu.Framework.UI.BunifuMetroTextbox', 0x40696D61676573, N'oussama', N'Événements familiaux', N'C:\Users\oussama ouardini\Desktop\S3\est.jpg', 1, NULL)
INSERT [dbo].[EVENEMENT] ([id_ev], [id_localisation], [organisateur], [startDate], [endDate], [description], [image], [nom_Ev], [type_Ev], [imglocation], [event_approve], [event_Status]) VALUES (479, 76, N'csd', CAST(N'2019-11-22T21:46:26.000' AS DateTime), CAST(N'2019-11-25T21:46:00.000' AS DateTime), N'Bunifu.Framework.UI.BunifuMetroTextbox', 0x40696D61676573, N'za', N'Anniversaires', N'C:\Users\oussama ouardini\Desktop\S3\ds\571ddc49-e3de-48f7-8f0b-ec402718815b.jpg', 0, N'public')
SET IDENTITY_INSERT [dbo].[EVENEMENT] OFF
INSERT [dbo].[Historique] ([id_Event], [nomEvent], [typeEvent]) VALUES (469, N'Enter the event name', N'Music')
SET IDENTITY_INSERT [dbo].[LIKES] ON 

INSERT [dbo].[LIKES] ([userID], [eventID], [nb]) VALUES (53, 476, 4)
INSERT [dbo].[LIKES] ([userID], [eventID], [nb]) VALUES (53, 4578, 10)
INSERT [dbo].[LIKES] ([userID], [eventID], [nb]) VALUES (53, 477, 14)
INSERT [dbo].[LIKES] ([userID], [eventID], [nb]) VALUES (53, 478, 15)
SET IDENTITY_INSERT [dbo].[LIKES] OFF
SET IDENTITY_INSERT [dbo].[LOCALISATION] ON 

INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (1, N'agadir', N'tata', NULL)
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (2, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (3, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (4, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (5, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (6, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (7, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (8, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (9, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (10, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (11, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (12, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (13, N'kesh', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (14, N'agadir', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (15, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (16, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (17, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (18, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (19, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (20, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (21, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (22, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (23, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (24, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (25, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (26, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (27, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (28, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (29, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (30, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (31, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (32, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (33, N'agadir', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (34, N'agadir', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (35, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (36, N'agadir', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (37, N'agadir', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (38, N'agadir', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (39, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (40, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (41, N'tanger', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (42, N't', N'csd', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (43, N'cdwxqs', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (44, N'qefsdxfbcvCity', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (45, N'Agadir', N'Agadir,Aourir,Tamawanza', N'80000')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (46, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (47, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (48, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (49, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (50, N'vcxwx', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (51, N'azae', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (52, N'bvCity', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (53, N', nh,jbnCity', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (54, N'ijdfvioojdfviojfviojiovjio', N'oicdkfvjojvdijiodfvjioj', N'jcfiodjijdfvijioj')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (55, N'jcdojifj', N'ijdfvjio', N'jifcjdpj')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (56, N'jcdojifj', N'ijdfvjio', N'jifcjdpj')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (57, N'Citybbbbbb', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (58, N'Citywwwxxwwxw', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (59, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (60, N'City xwxx', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (61, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (62, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (63, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (64, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (65, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (66, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (67, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (68, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (69, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (70, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (71, N'City', N'Address', N'ZIP Code')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (72, N'Ville', N'Adresse', N'Code postal')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (73, N'Ville', N'Adresse', N'Code postal')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (74, N'Ville', N'Adresse', N'Code postal')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (75, N'tata', N'tata', N'86784')
INSERT [dbo].[LOCALISATION] ([id_city], [city], [adress], [codepostal]) VALUES (76, N'cdf', N'cd', N'csd')
SET IDENTITY_INSERT [dbo].[LOCALISATION] OFF
SET IDENTITY_INSERT [dbo].[PURCHAS] ON 

INSERT [dbo].[PURCHAS] ([id_chaire], [id_user], [id_ev]) VALUES (1, 53, 478)
INSERT [dbo].[PURCHAS] ([id_chaire], [id_user], [id_ev]) VALUES (2, 53, 478)
INSERT [dbo].[PURCHAS] ([id_chaire], [id_user], [id_ev]) VALUES (3, 53, 478)
SET IDENTITY_INSERT [dbo].[PURCHAS] OFF
INSERT [dbo].[TICKETSTOCK] ([id_evticket], [t_available], [t_taken], [Prix_ticket]) VALUES (477, N'0', N'0', NULL)
INSERT [dbo].[TICKETSTOCK] ([id_evticket], [t_available], [t_taken], [Prix_ticket]) VALUES (478, N'482', N'10', N'300')
INSERT [dbo].[TICKETSTOCK] ([id_evticket], [t_available], [t_taken], [Prix_ticket]) VALUES (479, N'0', N'0', N'0')
ALTER TABLE [dbo].[EVENEMENT]  WITH CHECK ADD  CONSTRAINT [FK__EVENEMENT__id_lo__3B75D760] FOREIGN KEY([id_localisation])
REFERENCES [dbo].[LOCALISATION] ([id_city])
GO
ALTER TABLE [dbo].[EVENEMENT] CHECK CONSTRAINT [FK__EVENEMENT__id_lo__3B75D760]
GO
ALTER TABLE [dbo].[PURCHAS]  WITH CHECK ADD  CONSTRAINT [FK_PURCHAS_EV_USER] FOREIGN KEY([id_user])
REFERENCES [dbo].[EV_USER] ([id_user])
GO
ALTER TABLE [dbo].[PURCHAS] CHECK CONSTRAINT [FK_PURCHAS_EV_USER]
GO
ALTER TABLE [dbo].[PURCHAS]  WITH CHECK ADD  CONSTRAINT [FK_PURCHAS_TICKETSTOCK] FOREIGN KEY([id_ev])
REFERENCES [dbo].[TICKETSTOCK] ([id_evticket])
GO
ALTER TABLE [dbo].[PURCHAS] CHECK CONSTRAINT [FK_PURCHAS_TICKETSTOCK]
GO
ALTER TABLE [dbo].[TICKETSTOCK]  WITH CHECK ADD  CONSTRAINT [FK__TICKETSTO__id_ev__44FF419A] FOREIGN KEY([id_evticket])
REFERENCES [dbo].[EVENEMENT] ([id_ev])
GO
ALTER TABLE [dbo].[TICKETSTOCK] CHECK CONSTRAINT [FK__TICKETSTO__id_ev__44FF419A]
GO
USE [master]
GO
ALTER DATABASE [eventtest] SET  READ_WRITE 
GO
