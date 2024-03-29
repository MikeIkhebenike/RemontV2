USE [master]
GO
/****** Object:  Database [Service_Center]    Script Date: 27.05.2022 13:10:53 ******/
CREATE DATABASE [Service_Center]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Service_Center', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Service_Center.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Service_Center_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Service_Center_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Service_Center] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Service_Center].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Service_Center] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Service_Center] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Service_Center] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Service_Center] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Service_Center] SET ARITHABORT OFF 
GO
ALTER DATABASE [Service_Center] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Service_Center] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Service_Center] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Service_Center] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Service_Center] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Service_Center] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Service_Center] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Service_Center] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Service_Center] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Service_Center] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Service_Center] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Service_Center] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Service_Center] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Service_Center] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Service_Center] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Service_Center] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Service_Center] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Service_Center] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Service_Center] SET  MULTI_USER 
GO
ALTER DATABASE [Service_Center] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Service_Center] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Service_Center] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Service_Center] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Service_Center] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Service_Center] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Service_Center] SET QUERY_STORE = OFF
GO
USE [Service_Center]
GO
/****** Object:  Table [dbo].[Авторизация]    Script Date: 27.05.2022 13:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Авторизация](
	[ID_auth] [int] IDENTITY(1,1) NOT NULL,
	[Логин] [nvarchar](50) NOT NULL,
	[Пароль] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Авторизация] PRIMARY KEY CLUSTERED 
(
	[Логин] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Договор]    Script Date: 27.05.2022 13:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Договор](
	[ID_договора] [int] IDENTITY(1,1) NOT NULL,
	[ФИО_клиента] [nvarchar](50) NOT NULL,
	[ID_заявки] [int] NOT NULL,
	[ID_сотрудника] [int] NOT NULL,
	[ID_работы] [int] NOT NULL,
	[ЭлектроныйДокум] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Договор] PRIMARY KEY CLUSTERED 
(
	[ID_договора] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Доставка]    Script Date: 27.05.2022 13:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Доставка](
	[ID_доставки] [int] IDENTITY(1,1) NOT NULL,
	[ID_сотрудника] [int] NOT NULL,
	[ID_договора] [int] NOT NULL,
	[ФИО_клиента] [nvarchar](50) NOT NULL,
	[Контактный_телефон] [nvarchar](50) NOT NULL,
	[Адрес_клиента] [nvarchar](50) NOT NULL,
	[Способо_доставки] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Доставка] PRIMARY KEY CLUSTERED 
(
	[ID_доставки] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Заявка]    Script Date: 27.05.2022 13:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Заявка](
	[ID_заявки] [int] IDENTITY(1,1) NOT NULL,
	[ФИО_клиента] [nvarchar](50) NOT NULL,
	[Адрес_клиента] [nvarchar](50) NOT NULL,
	[Описание_проблемы] [nvarchar](50) NOT NULL,
	[Техника_клиента] [nvarchar](50) NOT NULL,
	[Количество] [int] NOT NULL,
	[Контактный_номер] [nvarchar](50) NOT NULL,
	[ДатаОткр] [nvarchar](50) NOT NULL,
	[ДатаЗакр] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Заявка] PRIMARY KEY CLUSTERED 
(
	[ID_заявки] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ЗаявкаНаПоставку]    Script Date: 27.05.2022 13:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ЗаявкаНаПоставку](
	[ID_заявНаПост] [int] IDENTITY(1,1) NOT NULL,
	[Наименование] [nvarchar](50) NOT NULL,
	[Количество] [int] NOT NULL,
	[Дата_создания] [nvarchar](50) NOT NULL,
	[Дата_закрытия] [nvarchar](50) NOT NULL,
	[ID_поставщика] [int] NOT NULL,
	[ID_сотрудника] [int] NOT NULL,
 CONSTRAINT [PK_ЗаявкаНаПоставку] PRIMARY KEY CLUSTERED 
(
	[ID_заявНаПост] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Комплектующее]    Script Date: 27.05.2022 13:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Комплектующее](
	[ID_комплектующего] [int] IDENTITY(1,1) NOT NULL,
	[ID_поставщика] [int] NOT NULL,
	[Наименование] [nvarchar](50) NOT NULL,
	[КоличествоВналич] [int] NOT NULL,
	[СтоимостьШт] [nvarchar](50) NOT NULL,
	[Изображение] [nvarchar](50) NULL,
 CONSTRAINT [PK_Комплектующее] PRIMARY KEY CLUSTERED 
(
	[ID_комплектующего] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Поставка]    Script Date: 27.05.2022 13:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Поставка](
	[ID_поставки] [int] IDENTITY(1,1) NOT NULL,
	[Дата_поставки] [nvarchar](50) NOT NULL,
	[ID_поставщика] [int] NOT NULL,
	[ID_сотрудника] [int] NOT NULL,
	[Стоимость_поставки] [nvarchar](50) NOT NULL,
	[ID_заявНаПост] [int] NOT NULL,
 CONSTRAINT [PK_Поставка] PRIMARY KEY CLUSTERED 
(
	[ID_поставки] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Поставщик]    Script Date: 27.05.2022 13:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Поставщик](
	[ID_поставщика] [int] IDENTITY(1,1) NOT NULL,
	[Наименование] [nvarchar](50) NOT NULL,
	[Адрес] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Поставщик] PRIMARY KEY CLUSTERED 
(
	[ID_поставщика] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ремонт]    Script Date: 27.05.2022 13:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ремонт](
	[ID_работы] [int] IDENTITY(1,1) NOT NULL,
	[ID_заявки] [int] NOT NULL,
	[Характер_ремонта] [nvarchar](50) NOT NULL,
	[ID_сотрудника] [int] NOT NULL,
	[ДатаНач] [nvarchar](50) NOT NULL,
	[ДатаЗаверш] [nvarchar](50) NOT NULL,
	[ID_статуса] [int] NOT NULL,
	[ID_услуги] [int] NOT NULL,
	[ID_комплектующего] [int] NOT NULL,
 CONSTRAINT [PK_Ремонт] PRIMARY KEY CLUSTERED 
(
	[ID_работы] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Роль]    Script Date: 27.05.2022 13:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Роль](
	[ID_роли] [int] IDENTITY(1,1) NOT NULL,
	[Наименование] [nvarchar](50) NOT NULL,
	[Должность] [nvarchar](50) NULL,
 CONSTRAINT [PK_Роль] PRIMARY KEY CLUSTERED 
(
	[ID_роли] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Сотрудник]    Script Date: 27.05.2022 13:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Сотрудник](
	[ID_сотрудника] [int] IDENTITY(1,1) NOT NULL,
	[ID_роли] [int] NOT NULL,
	[ФИО] [nvarchar](50) NOT NULL,
	[Пол] [nvarchar](10) NULL,
	[Должность] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Контактный_телефон] [nvarchar](50) NOT NULL,
	[Фото] [nvarchar](50) NULL,
 CONSTRAINT [PK_Cjnhelybr] PRIMARY KEY CLUSTERED 
(
	[ID_сотрудника] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[СтатусРабот]    Script Date: 27.05.2022 13:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[СтатусРабот](
	[ID_статуса] [int] IDENTITY(1,1) NOT NULL,
	[Наименование] [nvarchar](50) NULL,
 CONSTRAINT [PK_СтатусРабот] PRIMARY KEY CLUSTERED 
(
	[ID_статуса] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Услуга]    Script Date: 27.05.2022 13:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Услуга](
	[ID_услуги] [int] IDENTITY(1,1) NOT NULL,
	[Наименование] [nvarchar](50) NOT NULL,
	[Стоимость] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Услуга] PRIMARY KEY CLUSTERED 
(
	[ID_услуги] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Авторизация] ON 

INSERT [dbo].[Авторизация] ([ID_auth], [Логин], [Пароль]) VALUES (1, N'admin', N'admin1')
INSERT [dbo].[Авторизация] ([ID_auth], [Логин], [Пароль]) VALUES (3, N'engineer', N'engineer102')
INSERT [dbo].[Авторизация] ([ID_auth], [Логин], [Пароль]) VALUES (2, N'manager', N'manager101')
SET IDENTITY_INSERT [dbo].[Авторизация] OFF
GO
SET IDENTITY_INSERT [dbo].[Заявка] ON 

INSERT [dbo].[Заявка] ([ID_заявки], [ФИО_клиента], [Адрес_клиента], [Описание_проблемы], [Техника_клиента], [Количество], [Контактный_номер], [ДатаОткр], [ДатаЗакр]) VALUES (1, N'Иванов А.П.', N'Москва ул. Пушкина', N'Не работает видеокарта', N'Видеокарта NVIDIA GTX 1050 Ti', 1, N'71009991010', N'20.11.2021', N'23 ноября 2021 г.')
INSERT [dbo].[Заявка] ([ID_заявки], [ФИО_клиента], [Адрес_клиента], [Описание_проблемы], [Техника_клиента], [Количество], [Контактный_номер], [ДатаОткр], [ДатаЗакр]) VALUES (3, N'Сидоров Ю.Ю', N'Москва ул. Каховская', N'Греется процессор', N'Процессор Intel i7 7700k', 1, N'71118881144', N'15.11.2021', N'23 ноября 2021 г.')
INSERT [dbo].[Заявка] ([ID_заявки], [ФИО_клиента], [Адрес_клиента], [Описание_проблемы], [Техника_клиента], [Количество], [Контактный_номер], [ДатаОткр], [ДатаЗакр]) VALUES (4, N'Котелков В.В.', N'Москва ул. Северная д.8', N'Нет изображения на мониторе', N'Монитор hp 24fw', 1, N'87771112233', N'12.12.2021', N'22 декабря 2021 г.')
SET IDENTITY_INSERT [dbo].[Заявка] OFF
GO
SET IDENTITY_INSERT [dbo].[ЗаявкаНаПоставку] ON 

INSERT [dbo].[ЗаявкаНаПоставку] ([ID_заявНаПост], [Наименование], [Количество], [Дата_создания], [Дата_закрытия], [ID_поставщика], [ID_сотрудника]) VALUES (1, N'Термопрокладки 60х60', 100, N'21.08.2021', N'21.09.2021', 1, 2)
INSERT [dbo].[ЗаявкаНаПоставку] ([ID_заявНаПост], [Наименование], [Количество], [Дата_создания], [Дата_закрытия], [ID_поставщика], [ID_сотрудника]) VALUES (3, N'Термопаста', 100, N'30.10.2021', N'15.11.2021', 2, 3)
INSERT [dbo].[ЗаявкаНаПоставку] ([ID_заявНаПост], [Наименование], [Количество], [Дата_создания], [Дата_закрытия], [ID_поставщика], [ID_сотрудника]) VALUES (4, N'Корпусный вентилятор 120х120', 20, N'13.01.2022', N'27.01.2022', 1, 2)
INSERT [dbo].[ЗаявкаНаПоставку] ([ID_заявНаПост], [Наименование], [Количество], [Дата_создания], [Дата_закрытия], [ID_поставщика], [ID_сотрудника]) VALUES (1002, N'Транзистор IRF540', 25, N'02.05.2022', N'15 мая 2022 г.', 3, 3)
SET IDENTITY_INSERT [dbo].[ЗаявкаНаПоставку] OFF
GO
SET IDENTITY_INSERT [dbo].[Комплектующее] ON 

INSERT [dbo].[Комплектующее] ([ID_комплектующего], [ID_поставщика], [Наименование], [КоличествоВналич], [СтоимостьШт], [Изображение]) VALUES (1, 1, N'Процессор Intel i5 10400f', 11, N'15000', NULL)
INSERT [dbo].[Комплектующее] ([ID_комплектующего], [ID_поставщика], [Наименование], [КоличествоВналич], [СтоимостьШт], [Изображение]) VALUES (2, 1, N'Процессор Intel 3 10300', 21, N'9000', N'Accessories\intel10300.jpg')
INSERT [dbo].[Комплектующее] ([ID_комплектующего], [ID_поставщика], [Наименование], [КоличествоВналич], [СтоимостьШт], [Изображение]) VALUES (3, 2, N'Процессор Intel i7 10700kf', 13, N'21000', N'Accessories\i7-10700kf.jpg')
INSERT [dbo].[Комплектующее] ([ID_комплектующего], [ID_поставщика], [Наименование], [КоличествоВналич], [СтоимостьШт], [Изображение]) VALUES (4, 3, N'Процессор Intel i7 11700', 8, N'27500', N'Accessories\intel11700.jpg')
INSERT [dbo].[Комплектующее] ([ID_комплектующего], [ID_поставщика], [Наименование], [КоличествоВналич], [СтоимостьШт], [Изображение]) VALUES (5, 3, N'Процессор AMD Ryzen 5 3600', 30, N'16000', N'Accessories\ryzen3600.jpg')
INSERT [dbo].[Комплектующее] ([ID_комплектующего], [ID_поставщика], [Наименование], [КоличествоВналич], [СтоимостьШт], [Изображение]) VALUES (6, 2, N'Процессор AMD Ryzen 7 3700X', 12, N'19400', N'Accessories\ryzen3700x.jpg')
INSERT [dbo].[Комплектующее] ([ID_комплектующего], [ID_поставщика], [Наименование], [КоличествоВналич], [СтоимостьШт], [Изображение]) VALUES (7, 3, N'Процессор AMD Ryzen 5 5600X', 15, N'22000', N'Accessories\ryzen5600x.jpg')
INSERT [dbo].[Комплектующее] ([ID_комплектующего], [ID_поставщика], [Наименование], [КоличествоВналич], [СтоимостьШт], [Изображение]) VALUES (8, 3, N'Процессор AMD Ryzen 7 5800X', 9, N'28000', N'Accessories\ryzen5800x.jpg')
INSERT [dbo].[Комплектующее] ([ID_комплектующего], [ID_поставщика], [Наименование], [КоличествоВналич], [СтоимостьШт], [Изображение]) VALUES (9, 2, N'Видеокарта NVIDIA GTX 1060 6Gb', 28, N'28000', N'Accessories\gtx1060.jpg')
INSERT [dbo].[Комплектующее] ([ID_комплектующего], [ID_поставщика], [Наименование], [КоличествоВналич], [СтоимостьШт], [Изображение]) VALUES (10, 2, N'Видеокарта NVIDIA GTX 1660 6Gb', 10, N'45000', N'Accessories\gtx1660.png')
INSERT [dbo].[Комплектующее] ([ID_комплектующего], [ID_поставщика], [Наименование], [КоличествоВналич], [СтоимостьШт], [Изображение]) VALUES (11, 2, N'Видеокарта NVIDIA RTX 3080 10Gb', 8, N'120000', N'Accessories\rtx3080.jpg')
INSERT [dbo].[Комплектующее] ([ID_комплектующего], [ID_поставщика], [Наименование], [КоличествоВналич], [СтоимостьШт], [Изображение]) VALUES (12, 1, N'Видеокарта AMD RX 5600 XT 8Gb', 16, N'48000', N'Accessories\rx5600xt.jpg')
INSERT [dbo].[Комплектующее] ([ID_комплектующего], [ID_поставщика], [Наименование], [КоличествоВналич], [СтоимостьШт], [Изображение]) VALUES (13, 1, N'Видеокарта AMD RX 580 8Gb', 32, N'36000', N'Accessories\rx580msi.jpg')
INSERT [dbo].[Комплектующее] ([ID_комплектующего], [ID_поставщика], [Наименование], [КоличествоВналич], [СтоимостьШт], [Изображение]) VALUES (14, 3, N'Видеокарта AMD RX 5700 XT 8Gb', 9, N'78000', N'Accessories\rx5700xt.jpg')
INSERT [dbo].[Комплектующее] ([ID_комплектующего], [ID_поставщика], [Наименование], [КоличествоВналич], [СтоимостьШт], [Изображение]) VALUES (1001, 2, N'Видеокарта AMD RX 470 4Gb', 31, N'16000', N'Accessories\picture.png')
INSERT [dbo].[Комплектующее] ([ID_комплектующего], [ID_поставщика], [Наименование], [КоличествоВналич], [СтоимостьШт], [Изображение]) VALUES (1002, 1, N'GTX 1050 Ti', 13, N'22000', N'Accessories\picture.png')
INSERT [dbo].[Комплектующее] ([ID_комплектующего], [ID_поставщика], [Наименование], [КоличествоВналич], [СтоимостьШт], [Изображение]) VALUES (1003, 1002, N'Не было установлено', 0, N'0', N'Accessories\picture.png')
SET IDENTITY_INSERT [dbo].[Комплектующее] OFF
GO
SET IDENTITY_INSERT [dbo].[Поставка] ON 

INSERT [dbo].[Поставка] ([ID_поставки], [Дата_поставки], [ID_поставщика], [ID_сотрудника], [Стоимость_поставки], [ID_заявНаПост]) VALUES (1, N'19.09.2021', 1, 2, N'21000', 1)
INSERT [dbo].[Поставка] ([ID_поставки], [Дата_поставки], [ID_поставщика], [ID_сотрудника], [Стоимость_поставки], [ID_заявНаПост]) VALUES (3, N'12.11.2021', 2, 3, N'50000', 3)
SET IDENTITY_INSERT [dbo].[Поставка] OFF
GO
SET IDENTITY_INSERT [dbo].[Поставщик] ON 

INSERT [dbo].[Поставщик] ([ID_поставщика], [Наименование], [Адрес]) VALUES (1, N'Ситилинк', N'Москва')
INSERT [dbo].[Поставщик] ([ID_поставщика], [Наименование], [Адрес]) VALUES (2, N'Ситилинк', N'Москва')
INSERT [dbo].[Поставщик] ([ID_поставщика], [Наименование], [Адрес]) VALUES (3, N'TopComputer', N'Московская область')
INSERT [dbo].[Поставщик] ([ID_поставщика], [Наименование], [Адрес]) VALUES (1002, N'Сервисный центр', N'Москва')
SET IDENTITY_INSERT [dbo].[Поставщик] OFF
GO
SET IDENTITY_INSERT [dbo].[Ремонт] ON 

INSERT [dbo].[Ремонт] ([ID_работы], [ID_заявки], [Характер_ремонта], [ID_сотрудника], [ДатаНач], [ДатаЗаверш], [ID_статуса], [ID_услуги], [ID_комплектующего]) VALUES (1, 1, N'Починка/Замена видеокарты', 1, N'30.11.2021', N'18.12.2021', 1, 1, 1)
INSERT [dbo].[Ремонт] ([ID_работы], [ID_заявки], [Характер_ремонта], [ID_сотрудника], [ДатаНач], [ДатаЗаверш], [ID_статуса], [ID_услуги], [ID_комплектующего]) VALUES (12, 3, N'Починка/Замена процессора', 3, N'15.11.2021', N'11.12.2021', 3, 1002, 3)
INSERT [dbo].[Ремонт] ([ID_работы], [ID_заявки], [Характер_ремонта], [ID_сотрудника], [ДатаНач], [ДатаЗаверш], [ID_статуса], [ID_услуги], [ID_комплектующего]) VALUES (13, 4, N'Установка драйвера/Ремонт монитора', 4, N'12.12.2021', N'16.12.2021', 2, 2, 1003)
SET IDENTITY_INSERT [dbo].[Ремонт] OFF
GO
SET IDENTITY_INSERT [dbo].[Роль] ON 

INSERT [dbo].[Роль] ([ID_роли], [Наименование], [Должность]) VALUES (1, N'Администратор', N'Директор')
INSERT [dbo].[Роль] ([ID_роли], [Наименование], [Должность]) VALUES (2, N'Менеджер', N'Работник зала')
INSERT [dbo].[Роль] ([ID_роли], [Наименование], [Должность]) VALUES (3, N'Инженер', N'Аппаратный инженер')
SET IDENTITY_INSERT [dbo].[Роль] OFF
GO
SET IDENTITY_INSERT [dbo].[Сотрудник] ON 

INSERT [dbo].[Сотрудник] ([ID_сотрудника], [ID_роли], [ФИО], [Пол], [Должность], [Email], [Контактный_телефон], [Фото]) VALUES (1, 1, N'Петров В.А.', N'М', N'Директор', N'pertrov@gmail.com', N'79999999999', N'сотрудники\сотрудник1.png')
INSERT [dbo].[Сотрудник] ([ID_сотрудника], [ID_роли], [ФИО], [Пол], [Должность], [Email], [Контактный_телефон], [Фото]) VALUES (2, 2, N'Васильчук Ю.П.', N'М', N'Работник зала', N'vasilchuk@gmail.com', N'78888888888', N'сотрудники\сотрудник2.png')
INSERT [dbo].[Сотрудник] ([ID_сотрудника], [ID_роли], [ФИО], [Пол], [Должность], [Email], [Контактный_телефон], [Фото]) VALUES (3, 1, N'Попов Ю. А.', N'М', N'Главный администратор', N'popov1@gmail.com', N'77777777777', N'сотрудники\сотрудник.png')
INSERT [dbo].[Сотрудник] ([ID_сотрудника], [ID_роли], [ФИО], [Пол], [Должность], [Email], [Контактный_телефон], [Фото]) VALUES (4, 2, N'Соловьёв П.А.', N'М', N'Помощник инженера', N'solovey@gmail.com', N'79099991111', N'сотрудники\сотрудник2.png')
SET IDENTITY_INSERT [dbo].[Сотрудник] OFF
GO
SET IDENTITY_INSERT [dbo].[СтатусРабот] ON 

INSERT [dbo].[СтатусРабот] ([ID_статуса], [Наименование]) VALUES (1, N'Принята специалистом')
INSERT [dbo].[СтатусРабот] ([ID_статуса], [Наименование]) VALUES (2, N'В работе')
INSERT [dbo].[СтатусРабот] ([ID_статуса], [Наименование]) VALUES (3, N'Завершена')
SET IDENTITY_INSERT [dbo].[СтатусРабот] OFF
GO
SET IDENTITY_INSERT [dbo].[Услуга] ON 

INSERT [dbo].[Услуга] ([ID_услуги], [Наименование], [Стоимость]) VALUES (1, N'Диагностика', N'бесплатно')
INSERT [dbo].[Услуга] ([ID_услуги], [Наименование], [Стоимость]) VALUES (2, N'Установка драйверов', N'50р 1шт')
INSERT [dbo].[Услуга] ([ID_услуги], [Наименование], [Стоимость]) VALUES (3, N'Установка дополнительного модуля памяти ОЗУ', N'100р')
INSERT [dbo].[Услуга] ([ID_услуги], [Наименование], [Стоимость]) VALUES (4, N'Сборка компьютера', N'500р')
INSERT [dbo].[Услуга] ([ID_услуги], [Наименование], [Стоимость]) VALUES (1002, N'Замена комплектующего', N'Стоимость комплектующего')
SET IDENTITY_INSERT [dbo].[Услуга] OFF
GO
ALTER TABLE [dbo].[Авторизация]  WITH CHECK ADD  CONSTRAINT [FK_Авторизация_Сотрудник] FOREIGN KEY([ID_auth])
REFERENCES [dbo].[Сотрудник] ([ID_сотрудника])
GO
ALTER TABLE [dbo].[Авторизация] CHECK CONSTRAINT [FK_Авторизация_Сотрудник]
GO
ALTER TABLE [dbo].[Договор]  WITH CHECK ADD  CONSTRAINT [FK_Договор_Заявка] FOREIGN KEY([ID_заявки])
REFERENCES [dbo].[Заявка] ([ID_заявки])
GO
ALTER TABLE [dbo].[Договор] CHECK CONSTRAINT [FK_Договор_Заявка]
GO
ALTER TABLE [dbo].[Договор]  WITH CHECK ADD  CONSTRAINT [FK_Договор_Ремонт] FOREIGN KEY([ID_работы])
REFERENCES [dbo].[Ремонт] ([ID_работы])
GO
ALTER TABLE [dbo].[Договор] CHECK CONSTRAINT [FK_Договор_Ремонт]
GO
ALTER TABLE [dbo].[Договор]  WITH CHECK ADD  CONSTRAINT [FK_Договор_Сотрудник] FOREIGN KEY([ID_сотрудника])
REFERENCES [dbo].[Сотрудник] ([ID_сотрудника])
GO
ALTER TABLE [dbo].[Договор] CHECK CONSTRAINT [FK_Договор_Сотрудник]
GO
ALTER TABLE [dbo].[Доставка]  WITH CHECK ADD  CONSTRAINT [FK_Доставка_Договор] FOREIGN KEY([ID_договора])
REFERENCES [dbo].[Договор] ([ID_договора])
GO
ALTER TABLE [dbo].[Доставка] CHECK CONSTRAINT [FK_Доставка_Договор]
GO
ALTER TABLE [dbo].[Доставка]  WITH CHECK ADD  CONSTRAINT [FK_Доставка_Сотрудник] FOREIGN KEY([ID_сотрудника])
REFERENCES [dbo].[Сотрудник] ([ID_сотрудника])
GO
ALTER TABLE [dbo].[Доставка] CHECK CONSTRAINT [FK_Доставка_Сотрудник]
GO
ALTER TABLE [dbo].[ЗаявкаНаПоставку]  WITH CHECK ADD  CONSTRAINT [FK_ЗаявкаНаПоставку_Поставщик] FOREIGN KEY([ID_поставщика])
REFERENCES [dbo].[Поставщик] ([ID_поставщика])
GO
ALTER TABLE [dbo].[ЗаявкаНаПоставку] CHECK CONSTRAINT [FK_ЗаявкаНаПоставку_Поставщик]
GO
ALTER TABLE [dbo].[ЗаявкаНаПоставку]  WITH CHECK ADD  CONSTRAINT [FK_ЗаявкаНаПоставку_Сотрудник] FOREIGN KEY([ID_сотрудника])
REFERENCES [dbo].[Сотрудник] ([ID_сотрудника])
GO
ALTER TABLE [dbo].[ЗаявкаНаПоставку] CHECK CONSTRAINT [FK_ЗаявкаНаПоставку_Сотрудник]
GO
ALTER TABLE [dbo].[Комплектующее]  WITH CHECK ADD  CONSTRAINT [FK_Комплектующее_Поставщик] FOREIGN KEY([ID_поставщика])
REFERENCES [dbo].[Поставщик] ([ID_поставщика])
GO
ALTER TABLE [dbo].[Комплектующее] CHECK CONSTRAINT [FK_Комплектующее_Поставщик]
GO
ALTER TABLE [dbo].[Поставка]  WITH CHECK ADD  CONSTRAINT [FK_Поставка_ЗаявкаНаПоставку] FOREIGN KEY([ID_заявНаПост])
REFERENCES [dbo].[ЗаявкаНаПоставку] ([ID_заявНаПост])
GO
ALTER TABLE [dbo].[Поставка] CHECK CONSTRAINT [FK_Поставка_ЗаявкаНаПоставку]
GO
ALTER TABLE [dbo].[Поставка]  WITH CHECK ADD  CONSTRAINT [FK_Поставка_Поставщик] FOREIGN KEY([ID_поставщика])
REFERENCES [dbo].[Поставщик] ([ID_поставщика])
GO
ALTER TABLE [dbo].[Поставка] CHECK CONSTRAINT [FK_Поставка_Поставщик]
GO
ALTER TABLE [dbo].[Поставка]  WITH CHECK ADD  CONSTRAINT [FK_Поставка_Сотрудник] FOREIGN KEY([ID_сотрудника])
REFERENCES [dbo].[Сотрудник] ([ID_сотрудника])
GO
ALTER TABLE [dbo].[Поставка] CHECK CONSTRAINT [FK_Поставка_Сотрудник]
GO
ALTER TABLE [dbo].[Ремонт]  WITH CHECK ADD  CONSTRAINT [FK_Ремонт_Заявка] FOREIGN KEY([ID_заявки])
REFERENCES [dbo].[Заявка] ([ID_заявки])
GO
ALTER TABLE [dbo].[Ремонт] CHECK CONSTRAINT [FK_Ремонт_Заявка]
GO
ALTER TABLE [dbo].[Ремонт]  WITH CHECK ADD  CONSTRAINT [FK_Ремонт_Комплектующее] FOREIGN KEY([ID_комплектующего])
REFERENCES [dbo].[Комплектующее] ([ID_комплектующего])
GO
ALTER TABLE [dbo].[Ремонт] CHECK CONSTRAINT [FK_Ремонт_Комплектующее]
GO
ALTER TABLE [dbo].[Ремонт]  WITH CHECK ADD  CONSTRAINT [FK_Ремонт_Сотрудник] FOREIGN KEY([ID_сотрудника])
REFERENCES [dbo].[Сотрудник] ([ID_сотрудника])
GO
ALTER TABLE [dbo].[Ремонт] CHECK CONSTRAINT [FK_Ремонт_Сотрудник]
GO
ALTER TABLE [dbo].[Ремонт]  WITH CHECK ADD  CONSTRAINT [FK_Ремонт_СтатусРабот] FOREIGN KEY([ID_статуса])
REFERENCES [dbo].[СтатусРабот] ([ID_статуса])
GO
ALTER TABLE [dbo].[Ремонт] CHECK CONSTRAINT [FK_Ремонт_СтатусРабот]
GO
ALTER TABLE [dbo].[Ремонт]  WITH CHECK ADD  CONSTRAINT [FK_Ремонт_Услуга] FOREIGN KEY([ID_услуги])
REFERENCES [dbo].[Услуга] ([ID_услуги])
GO
ALTER TABLE [dbo].[Ремонт] CHECK CONSTRAINT [FK_Ремонт_Услуга]
GO
ALTER TABLE [dbo].[Сотрудник]  WITH CHECK ADD  CONSTRAINT [FK_Сотрудник_Роль] FOREIGN KEY([ID_роли])
REFERENCES [dbo].[Роль] ([ID_роли])
GO
ALTER TABLE [dbo].[Сотрудник] CHECK CONSTRAINT [FK_Сотрудник_Роль]
GO
USE [master]
GO
ALTER DATABASE [Service_Center] SET  READ_WRITE 
GO
