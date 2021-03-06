USE [master]
GO
/****** Object:  Database [eventtest]    Script Date: 01-Dec-19 5:54:04 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[checkTicketAvailable]    Script Date: 01-Dec-19 5:54:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[checkTicketAvailable]
(
    @nbPris INT,
    @idEvent INT
)
RETURNS INT
AS 
BEGIN 
DECLARE @index INT
DECLARE @ticketValable INT
DECLARE @ticketTaken INT
SET @ticketValable = (SELECT t_available FROM TICKETSTOCK WHERE id_evticket = @idEvent)
SET @ticketTaken = (SELECT t_taken FROM TICKETSTOCK WHERE id_evticket = @idEvent)
if(@ticketValable <= (@nbPris + @ticketTaken))
BEGIN 
SET @index = 0
END
ELSE SET @index = 1
RETURN @index
END
GO
/****** Object:  UserDefinedFunction [dbo].[id_loc]    Script Date: 01-Dec-19 5:54:04 PM ******/
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
/****** Object:  Table [dbo].[Admin]    Script Date: 01-Dec-19 5:54:04 PM ******/
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
/****** Object:  Table [dbo].[EV_USER]    Script Date: 01-Dec-19 5:54:04 PM ******/
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
/****** Object:  Table [dbo].[EVENEMENT]    Script Date: 01-Dec-19 5:54:04 PM ******/
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
/****** Object:  Table [dbo].[Historique]    Script Date: 01-Dec-19 5:54:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historique](
	[id_Event] [int] NOT NULL,
	[nomEvent] [varchar](50) NULL,
	[typeEvent] [varchar](50) NULL,
 CONSTRAINT [PK_Historique] PRIMARY KEY CLUSTERED 
(
	[id_Event] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LIKES]    Script Date: 01-Dec-19 5:54:04 PM ******/
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
/****** Object:  Table [dbo].[LOCALISATION]    Script Date: 01-Dec-19 5:54:04 PM ******/
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
/****** Object:  Table [dbo].[NOTIFICATION]    Script Date: 01-Dec-19 5:54:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NOTIFICATION](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[message] [varchar](max) NULL,
	[ntfID] [int] NULL,
 CONSTRAINT [PK_NOTIFICATION] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PURCHAS]    Script Date: 01-Dec-19 5:54:04 PM ******/
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
/****** Object:  Table [dbo].[TICKETSTOCK]    Script Date: 01-Dec-19 5:54:04 PM ******/
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
ALTER TABLE [dbo].[EVENEMENT]  WITH CHECK ADD  CONSTRAINT [FK__EVENEMENT__id_lo__3B75D760] FOREIGN KEY([id_localisation])
REFERENCES [dbo].[LOCALISATION] ([id_city])
GO
ALTER TABLE [dbo].[EVENEMENT] CHECK CONSTRAINT [FK__EVENEMENT__id_lo__3B75D760]
GO
ALTER TABLE [dbo].[Historique]  WITH CHECK ADD  CONSTRAINT [FK_Historique_EVENEMENT] FOREIGN KEY([id_Event])
REFERENCES [dbo].[EVENEMENT] ([id_ev])
GO
ALTER TABLE [dbo].[Historique] CHECK CONSTRAINT [FK_Historique_EVENEMENT]
GO
ALTER TABLE [dbo].[LIKES]  WITH CHECK ADD  CONSTRAINT [FK_LIKES_EV_USER] FOREIGN KEY([userID])
REFERENCES [dbo].[EV_USER] ([id_user])
GO
ALTER TABLE [dbo].[LIKES] CHECK CONSTRAINT [FK_LIKES_EV_USER]
GO
ALTER TABLE [dbo].[LIKES]  WITH CHECK ADD  CONSTRAINT [FK_LIKES_EVENEMENT] FOREIGN KEY([eventID])
REFERENCES [dbo].[EVENEMENT] ([id_ev])
GO
ALTER TABLE [dbo].[LIKES] CHECK CONSTRAINT [FK_LIKES_EVENEMENT]
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
/****** Object:  StoredProcedure [dbo].[checkEvent]    Script Date: 01-Dec-19 5:54:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[checkEvent]
AS 
BEGIN 
DECLARE @eventCount INT
SET @eventCount = (SELECT COUNT(id_ev) FROM EVENEMENT);
if @eventCount < 2
BEGIN 
INSERT INTO NOTIFICATION (message,ntfID) VALUES('Le nombre des evenements est inferieure a 2',2)
END
END
GO
/****** Object:  StoredProcedure [dbo].[checkEventDate]    Script Date: 01-Dec-19 5:54:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedure check event start date
CREATE PROCEDURE [dbo].[checkEventDate]
AS 
BEGIN 
DECLARE @idEvent INT
DECLARE @startDate DATE
DECLARE CUR1 CURSOR FOR SELECT id_ev,startDate FROM EVENEMENT
OPEN CUR1
FETCH NEXT FROM CUR1 INTO @idEvent,@startDate
WHILE @@FETCH_STATUS = 0
BEGIN 
if(@startDate > GETDATE())
BEGIN 
INSERT INTO NOTIFICATION (message,ntfID) VALUES('L''evenement '+ CONVERT(CHAR(1),@idEvent) + 'a passer !',3)
DELETE FROM EVENEMENT WHERE id_ev = @idEvent
END
FETCH NEXT FROM CUR1 INTO @idEvent,@startDate
END
CLOSE CUR1
DEALLOCATE CUR1
END
GO
/****** Object:  StoredProcedure [dbo].[checkTicketStock]    Script Date: 01-Dec-19 5:54:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedure check ticket stock
CREATE PROCEDURE [dbo].[checkTicketStock]
AS 
BEGIN 
DECLARE @idEvTicket INT
DECLARE @available INT
DECLARE CUR2 CURSOR FOR SELECT id_evticket,t_available FROM TICKETSTOCK
OPEN CUR2 
FETCH NEXT FROM CUR2 INTO @idEvTicket,@available 
WHILE @@FETCH_STATUS = 0
BEGIN 
IF @available < 1
BEGIN
INSERT INTO NOTIFICATION(message,ntfID) VALUES('Les tickets de L''evenement '+ CONVERT(CHAR(1),@idEvTicket) + 'sont epuiser !',1);
END
FETCH NEXT FROM CUR2 INTO @idEvTicket,@available 
END
CLOSE CUR2
DEALLOCATE CUR2
END
GO
/****** Object:  StoredProcedure [dbo].[getProche]    Script Date: 01-Dec-19 5:54:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getProche]
AS
BEGIN
SELECT * FROM EVENEMENT WHERE (DATEDIFF(DAY,endDate,GETDATE()) < 3)
END
GO
/****** Object:  StoredProcedure [dbo].[getTickets]    Script Date: 01-Dec-19 5:54:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getTickets]
AS 
BEGIN 
SELECT * FROM EVENEMENT WHERE id_ev IN (SELECT id_evticket FROM TICKETSTOCK WHERE t_available < 10)
END
GO
USE [master]
GO
ALTER DATABASE [eventtest] SET  READ_WRITE 
GO
