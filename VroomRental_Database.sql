USE [master]
GO
/****** Object:  Database [VroomRental]    Script Date: 3.01.2025 11:29:20 ******/
CREATE DATABASE [VroomRental]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VroomRental', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\VroomRental.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VroomRental_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\VroomRental_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [VroomRental] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VroomRental].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VroomRental] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VroomRental] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VroomRental] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VroomRental] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VroomRental] SET ARITHABORT OFF 
GO
ALTER DATABASE [VroomRental] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [VroomRental] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VroomRental] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VroomRental] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VroomRental] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VroomRental] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VroomRental] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VroomRental] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VroomRental] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VroomRental] SET  ENABLE_BROKER 
GO
ALTER DATABASE [VroomRental] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VroomRental] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VroomRental] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VroomRental] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VroomRental] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VroomRental] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VroomRental] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VroomRental] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VroomRental] SET  MULTI_USER 
GO
ALTER DATABASE [VroomRental] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VroomRental] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VroomRental] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VroomRental] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VroomRental] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VroomRental] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [VroomRental] SET QUERY_STORE = ON
GO
ALTER DATABASE [VroomRental] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [VroomRental]
GO
/****** Object:  Table [dbo].[tbl_Additional_Options]    Script Date: 3.01.2025 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Additional_Options](
	[Option_Id] [int] IDENTITY(1,1) NOT NULL,
	[Option_Name] [nvarchar](100) NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Option_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Addresses]    Script Date: 3.01.2025 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Addresses](
	[Customer_Id] [int] NOT NULL,
	[Street] [nvarchar](100) NOT NULL,
	[Home_Number] [nvarchar](10) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Zip_Code] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Customer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Car_Reservations]    Script Date: 3.01.2025 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Car_Reservations](
	[Reservation_Id] [int] IDENTITY(1,1) NOT NULL,
	[Customer_Id] [int] NOT NULL,
	[Car_Id] [int] NOT NULL,
	[Start_Date] [date] NOT NULL,
	[Planned_End_Date] [date] NOT NULL,
	[Actual_End_Date] [date] NULL,
	[Status] [int] NOT NULL,
	[Employee_Id] [int] NOT NULL,
	[DailyMileagePackage_Id] [int] NULL,
	[Traveled_Kilometers] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Reservation_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Car_Statuses]    Script Date: 3.01.2025 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Car_Statuses](
	[Status_Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Status_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Cars]    Script Date: 3.01.2025 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Cars](
	[Car_Id] [int] IDENTITY(1,1) NOT NULL,
	[Brand] [nvarchar](50) NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[Production_Year] [nvarchar](4) NOT NULL,
	[Body_Type] [nvarchar](50) NULL,
	[Color] [nvarchar](50) NULL,
	[Mileage] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[Price_Per_Day] [decimal](10, 2) NOT NULL,
	[Last_Inspection_Date] [date] NOT NULL,
	[Fuel_Type] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Car_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Customers]    Script Date: 3.01.2025 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Customers](
	[Customer_Id] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [nvarchar](50) NOT NULL,
	[Last_Name] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Driver_Licence_Number] [nvarchar](20) NOT NULL,
	[Registration_Date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Customer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_DailyMileagePackages]    Script Date: 3.01.2025 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_DailyMileagePackages](
	[Package_Id] [int] IDENTITY(1,1) NOT NULL,
	[Package_Name] [nvarchar](100) NOT NULL,
	[Max_Kilometers_Per_Day] [int] NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Package_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Employees]    Script Date: 3.01.2025 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Employees](
	[Employee_Id] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [nvarchar](50) NOT NULL,
	[Last_Name] [nvarchar](50) NOT NULL,
	[Role] [int] NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [varbinary](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Employee_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Payment_Methods]    Script Date: 3.01.2025 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Payment_Methods](
	[Method_Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Method_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Payments]    Script Date: 3.01.2025 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Payments](
	[Reservation_Id] [int] NOT NULL,
	[Amount] [decimal](10, 2) NOT NULL,
	[Payment_Date] [datetime] NOT NULL,
	[Payment_Method] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Reservation_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Repair_Statuses]    Script Date: 3.01.2025 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Repair_Statuses](
	[Status_Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Status_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Repairs]    Script Date: 3.01.2025 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Repairs](
	[Repair_Id] [int] IDENTITY(1,1) NOT NULL,
	[Car_Id] [int] NOT NULL,
	[Report_Date] [datetime] NOT NULL,
	[Description] [nvarchar](255) NOT NULL,
	[Status] [int] NOT NULL,
	[End_Date] [datetime] NULL,
	[Employee_Id] [int] NOT NULL,
	[Cost] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Repair_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Reservation_Options]    Script Date: 3.01.2025 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Reservation_Options](
	[Reservation_Id] [int] NOT NULL,
	[Option_Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Reservation_Id] ASC,
	[Option_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Reservation_Statuses]    Script Date: 3.01.2025 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Reservation_Statuses](
	[Status_Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Status_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Roles]    Script Date: 3.01.2025 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Roles](
	[Position_Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Position_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_Additional_Options] ON 

INSERT [dbo].[tbl_Additional_Options] ([Option_Id], [Option_Name], [Price]) VALUES (1, N'Bagażnik na rowery', CAST(15.00 AS Decimal(10, 2)))
INSERT [dbo].[tbl_Additional_Options] ([Option_Id], [Option_Name], [Price]) VALUES (2, N'Fotelik dziecięcy', CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[tbl_Additional_Options] ([Option_Id], [Option_Name], [Price]) VALUES (3, N'Dodatkowe ubezpieczenie', CAST(25.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[tbl_Additional_Options] OFF
GO
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (1, N'Warszawska', N'12', N'Warszawa', N'00-001')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (2, N'Krakowska', N'22', N'Kraków', N'30-001')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (3, N'Poznańska', N'5', N'Poznań', N'60-001')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (4, N'Wrocławska', N'8', N'Wrocław', N'50-001')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (5, N'Gdańska', N'14', N'Gdańsk', N'80-001')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (6, N'Szczecińska', N'10', N'Szczecin', N'70-001')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (7, N'Lódzka', N'3', N'Łódź', N'90-001')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (8, N'Lubliniecka', N'6', N'Lublin', N'20-001')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (9, N'Katowicka', N'7', N'Katowice', N'40-001')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (10, N'Północna', N'15', N'Radom', N'26-001')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (11, N'Południowa', N'19', N'Gdynia', N'81-001')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (12, N'Zachodnia', N'20', N'Opole', N'45-001')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (13, N'Wschodnia', N'25', N'Zamość', N'22-400')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (14, N'Leśna', N'30', N'Suwałki', N'16-400')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (15, N'Sportowa', N'5', N'Warszawa', N'01-123')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (16, N'Leśna', N'12', N'Kraków', N'30-432')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (17, N'Słoneczna', N'7', N'Poznań', N'60-456')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (18, N'Nowa', N'9', N'Wrocław', N'50-789')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (19, N'Polna', N'11', N'Gdańsk', N'80-321')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (20, N'Tęczowa', N'6', N'Szczecin', N'70-234')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (21, N'Dębowa', N'8', N'Łódź', N'90-345')
INSERT [dbo].[tbl_Addresses] ([Customer_Id], [Street], [Home_Number], [City], [Zip_Code]) VALUES (22, N'Kwiatowa', N'4', N'Lublin', N'20-567')
GO
SET IDENTITY_INSERT [dbo].[tbl_Car_Reservations] ON 

INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (1, 1, 1, CAST(N'2024-11-01' AS Date), CAST(N'2024-11-07' AS Date), CAST(N'2024-11-06' AS Date), 2, 2, 2, 400)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (2, 2, 2, CAST(N'2024-11-08' AS Date), CAST(N'2024-11-20' AS Date), NULL, 1, 1, 1, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (3, 1, 3, CAST(N'2024-11-10' AS Date), CAST(N'2024-11-15' AS Date), CAST(N'2024-11-14' AS Date), 2, 2, 1, 250)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (4, 12, 14, CAST(N'2024-11-12' AS Date), CAST(N'2024-11-15' AS Date), CAST(N'2024-11-14' AS Date), 2, 3, 1, 150)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (5, 3, 24, CAST(N'2024-12-01' AS Date), CAST(N'2024-12-05' AS Date), CAST(N'2024-12-05' AS Date), 2, 1, 2, 350)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (6, 15, 15, CAST(N'2024-12-02' AS Date), CAST(N'2024-12-07' AS Date), CAST(N'2024-12-06' AS Date), 2, 2, 2, 300)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (7, 3, 5, CAST(N'2024-12-03' AS Date), CAST(N'2024-12-06' AS Date), CAST(N'2024-12-05' AS Date), 2, 1, 3, 200)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (8, 4, 3, CAST(N'2024-12-08' AS Date), CAST(N'2024-12-15' AS Date), CAST(N'2024-12-14' AS Date), 2, 3, 3, 500)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (9, 4, 6, CAST(N'2024-12-09' AS Date), CAST(N'2024-12-12' AS Date), CAST(N'2024-12-11' AS Date), 2, 3, 1, 300)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (10, 16, 21, CAST(N'2024-12-10' AS Date), CAST(N'2024-12-16' AS Date), CAST(N'2024-12-11' AS Date), 2, 3, 3, 450)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (11, 6, 21, CAST(N'2024-12-11' AS Date), CAST(N'2024-12-10' AS Date), CAST(N'2024-12-09' AS Date), 2, 2, 2, 450)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (12, 7, 3, CAST(N'2024-12-12' AS Date), CAST(N'2024-12-19' AS Date), NULL, 1, 3, 1, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (13, 17, 4, CAST(N'2024-12-13' AS Date), CAST(N'2024-12-20' AS Date), NULL, 1, 1, 2, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (14, 5, 7, CAST(N'2024-12-14' AS Date), CAST(N'2024-12-20' AS Date), NULL, 1, 1, 2, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (15, 8, 8, CAST(N'2024-12-15' AS Date), CAST(N'2024-12-22' AS Date), CAST(N'2024-12-18' AS Date), 2, 2, 2, 300)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (16, 18, 21, CAST(N'2024-12-16' AS Date), CAST(N'2024-12-24' AS Date), CAST(N'2024-12-23' AS Date), 2, 2, 1, 350)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (17, 9, 6, CAST(N'2024-12-18' AS Date), CAST(N'2024-12-25' AS Date), NULL, 1, 3, 1, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (18, 6, 8, CAST(N'2024-12-19' AS Date), CAST(N'2024-12-24' AS Date), CAST(N'2024-12-23' AS Date), 2, 2, 3, 400)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (19, 19, 8, CAST(N'2024-12-20' AS Date), CAST(N'2024-12-26' AS Date), NULL, 1, 3, 2, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (20, 10, 29, CAST(N'2024-12-20' AS Date), CAST(N'2024-12-27' AS Date), CAST(N'2024-12-26' AS Date), 2, 1, 2, 700)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (21, 20, 20, CAST(N'2024-12-22' AS Date), CAST(N'2024-12-28' AS Date), CAST(N'2024-12-27' AS Date), 2, 1, 1, 300)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (22, 7, 9, CAST(N'2024-12-22' AS Date), CAST(N'2024-12-28' AS Date), NULL, 1, 3, 1, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (23, 11, 21, CAST(N'2024-12-23' AS Date), CAST(N'2024-12-29' AS Date), NULL, 1, 2, 3, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (24, 12, 25, CAST(N'2024-12-23' AS Date), CAST(N'2024-12-30' AS Date), NULL, 1, 1, 1, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (25, 8, 27, CAST(N'2024-12-25' AS Date), CAST(N'2025-01-01' AS Date), NULL, 1, 1, 2, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (26, 21, 1, CAST(N'2024-12-26' AS Date), CAST(N'2025-01-02' AS Date), NULL, 1, 2, 3, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (27, 1, 5, CAST(N'2024-12-28' AS Date), CAST(N'2025-01-04' AS Date), NULL, 1, 2, 3, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (28, 15, 13, CAST(N'2024-12-28' AS Date), CAST(N'2025-01-10' AS Date), NULL, 1, 2, 1, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (29, 9, 11, CAST(N'2024-12-29' AS Date), CAST(N'2025-01-05' AS Date), NULL, 1, 2, 3, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (30, 16, 14, CAST(N'2024-12-30' AS Date), CAST(N'2025-01-15' AS Date), CAST(N'2025-01-02' AS Date), 2, 3, 2, 300)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (31, 17, 15, CAST(N'2025-01-01' AS Date), CAST(N'2025-01-20' AS Date), NULL, 1, 1, 3, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (32, 10, 12, CAST(N'2025-01-01' AS Date), CAST(N'2025-01-10' AS Date), NULL, 1, 3, 1, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (33, 18, 28, CAST(N'2025-01-01' AS Date), CAST(N'2025-01-25' AS Date), CAST(N'2025-01-02' AS Date), 2, 2, 1, 400)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (34, 19, 17, CAST(N'2025-01-01' AS Date), CAST(N'2025-02-01' AS Date), NULL, 1, 3, 2, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (35, 11, 23, CAST(N'2025-01-01' AS Date), CAST(N'2025-01-12' AS Date), NULL, 1, 1, 2, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (36, 20, 26, CAST(N'2025-01-01' AS Date), CAST(N'2025-02-06' AS Date), CAST(N'2025-01-02' AS Date), 2, 1, 3, 500)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (37, 21, 19, CAST(N'2025-01-01' AS Date), CAST(N'2025-02-10' AS Date), NULL, 1, 2, 2, NULL)
INSERT [dbo].[tbl_Car_Reservations] ([Reservation_Id], [Customer_Id], [Car_Id], [Start_Date], [Planned_End_Date], [Actual_End_Date], [Status], [Employee_Id], [DailyMileagePackage_Id], [Traveled_Kilometers]) VALUES (38, 22, 20, CAST(N'2025-01-01' AS Date), CAST(N'2025-02-15' AS Date), CAST(N'2025-01-02' AS Date), 2, 3, 1, 350)
SET IDENTITY_INSERT [dbo].[tbl_Car_Reservations] OFF
GO
INSERT [dbo].[tbl_Car_Statuses] ([Status_Id], [Name]) VALUES (1, N'Available')
INSERT [dbo].[tbl_Car_Statuses] ([Status_Id], [Name]) VALUES (2, N'Rented')
INSERT [dbo].[tbl_Car_Statuses] ([Status_Id], [Name]) VALUES (3, N'In repair')
GO
SET IDENTITY_INSERT [dbo].[tbl_Cars] ON 

INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (1, N'Audi', N'A4', N'2018', N'Sedan', N'Blue', 80000, 1, CAST(60.00 AS Decimal(10, 2)), CAST(N'2023-08-15' AS Date), N'Diesel')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (2, N'Mercedes', N'CLA', N'2021', N'Coupe', N'Black', 30000, 2, CAST(80.00 AS Decimal(10, 2)), CAST(N'2023-09-10' AS Date), N'Petrol')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (3, N'Volkswagen', N'Passat', N'2017', N'Sedan', N'Silver', 95000, 1, CAST(55.00 AS Decimal(10, 2)), CAST(N'2023-07-20' AS Date), N'Diesel')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (4, N'Kia', N'Sportage', N'2020', N'SUV', N'Red', 40000, 1, CAST(70.00 AS Decimal(10, 2)), CAST(N'2023-06-15' AS Date), N'Petrol')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (5, N'Tesla', N'Model 3', N'2022', N'Sedan', N'White', 15000, 2, CAST(100.00 AS Decimal(10, 2)), CAST(N'2023-10-05' AS Date), N'Electric')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (6, N'Hyundai', N'Tucson', N'2019', N'SUV', N'Gray', 55000, 2, CAST(65.00 AS Decimal(10, 2)), CAST(N'2023-08-25' AS Date), N'Diesel')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (7, N'Skoda', N'Octavia', N'2016', N'Sedan', N'Black', 120000, 1, CAST(50.00 AS Decimal(10, 2)), CAST(N'2023-07-05' AS Date), N'Petrol')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (8, N'Peugeot', N'208', N'2020', N'Hatchback', N'Blue', 30000, 2, CAST(45.00 AS Decimal(10, 2)), CAST(N'2023-09-10' AS Date), N'Diesel')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (9, N'Ford', N'Fiesta', N'2018', N'Hatchback', N'Red', 70000, 2, CAST(40.00 AS Decimal(10, 2)), CAST(N'2023-07-15' AS Date), N'Petrol')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (10, N'BMW', N'Series 3', N'2019', N'Sedan', N'Gray', 60000, 3, CAST(85.00 AS Decimal(10, 2)), CAST(N'2023-06-01' AS Date), N'Diesel')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (11, N'Volvo', N'XC60', N'2021', N'SUV', N'Black', 20000, 1, CAST(120.00 AS Decimal(10, 2)), CAST(N'2023-05-10' AS Date), N'Electric')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (12, N'Mazda', N'CX-5', N'2020', N'SUV', N'Blue', 45000, 2, CAST(75.00 AS Decimal(10, 2)), CAST(N'2023-06-15' AS Date), N'Petrol')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (13, N'Opel', N'Corsa', N'2015', N'Hatchback', N'Silver', 90000, 2, CAST(35.00 AS Decimal(10, 2)), CAST(N'2023-06-15' AS Date), N'Diesel')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (14, N'Honda', N'CR-V', N'2021', N'SUV', N'White', 25000, 2, CAST(90.00 AS Decimal(10, 2)), CAST(N'2023-07-20' AS Date), N'Petrol')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (15, N'Fiat', N'500', N'2018', N'Hatchback', N'Red', 50000, 2, CAST(40.00 AS Decimal(10, 2)), CAST(N'2023-05-15' AS Date), N'Petrol')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (16, N'Alfa Romeo', N'Giulia', N'2020', N'Sedan', N'Blue', 35000, 3, CAST(85.00 AS Decimal(10, 2)), CAST(N'2023-08-10' AS Date), N'Diesel')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (17, N'Seat', N'Arona', N'2022', N'SUV', N'Gray', 20000, 2, CAST(75.00 AS Decimal(10, 2)), CAST(N'2023-10-25' AS Date), N'Petrol')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (18, N'Dacia', N'Duster', N'2019', N'SUV', N'Brown', 60000, 3, CAST(60.00 AS Decimal(10, 2)), CAST(N'2023-07-05' AS Date), N'Diesel')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (19, N'Toyota', N'RAV4', N'2022', N'SUV', N'Green', 15000, 2, CAST(100.00 AS Decimal(10, 2)), CAST(N'2023-09-15' AS Date), N'Hybrid')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (20, N'Hyundai', N'i30', N'2020', N'Hatchback', N'Blue', 40000, 2, CAST(50.00 AS Decimal(10, 2)), CAST(N'2023-06-20' AS Date), N'Petrol')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (21, N'Nissan', N'Qashqai', N'2021', N'SUV', N'Gray', 25000, 2, CAST(80.00 AS Decimal(10, 2)), CAST(N'2023-08-30' AS Date), N'Petrol')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (22, N'Chevrolet', N'Camaro', N'2020', N'Coupe', N'Yellow', 15000, 1, CAST(110.00 AS Decimal(10, 2)), CAST(N'2023-09-15' AS Date), N'Petrol')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (23, N'Mitsubishi', N'Outlander', N'2022', N'SUV', N'White', 20000, 2, CAST(85.00 AS Decimal(10, 2)), CAST(N'2023-10-01' AS Date), N'Hybrid')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (24, N'Citroën', N'C5 Aircross', N'2020', N'SUV', N'Blue', 30000, 1, CAST(75.00 AS Decimal(10, 2)), CAST(N'2023-07-15' AS Date), N'Diesel')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (25, N'Jeep', N'Wrangler', N'2021', N'SUV', N'Black', 15000, 2, CAST(120.00 AS Decimal(10, 2)), CAST(N'2023-09-10' AS Date), N'Petrol')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (26, N'Kia', N'Ceed', N'2019', N'Hatchback', N'Silver', 40000, 2, CAST(55.00 AS Decimal(10, 2)), CAST(N'2023-06-20' AS Date), N'Diesel')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (27, N'Suzuki', N'Vitara', N'2021', N'SUV', N'Red', 20000, 2, CAST(70.00 AS Decimal(10, 2)), CAST(N'2023-08-15' AS Date), N'Petrol')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (28, N'BMW', N'X1', N'2022', N'SUV', N'White', 15000, 2, CAST(100.00 AS Decimal(10, 2)), CAST(N'2023-10-05' AS Date), N'Diesel')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (29, N'Toyota', N'Corolla', N'2021', N'Sedan', N'Blue', 30000, 2, CAST(65.00 AS Decimal(10, 2)), CAST(N'2023-07-25' AS Date), N'Hybrid')
INSERT [dbo].[tbl_Cars] ([Car_Id], [Brand], [Model], [Production_Year], [Body_Type], [Color], [Mileage], [Status], [Price_Per_Day], [Last_Inspection_Date], [Fuel_Type]) VALUES (30, N'Ford', N'Focus', N'2020', N'Hatchback', N'Gray', 35000, 1, CAST(60.00 AS Decimal(10, 2)), CAST(N'2023-06-30' AS Date), N'Petrol')
SET IDENTITY_INSERT [dbo].[tbl_Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Customers] ON 

INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (1, N'Anna', N'Kowalska', N'+48123123123', N'anna.kowalska@example.com', N'DL1234567893', CAST(N'2024-02-15' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (2, N'Jan', N'Nowak', N'+48567856789', N'jan.nowak@example.com', N'DL1234567894', CAST(N'2024-03-10' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (3, N'Piotr', N'Szewczyk', N'+48221133123', N'piotr.szewczyk@example.com', N'DL1234567895', CAST(N'2024-04-12' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (4, N'Zofia', N'Wiśniewska', N'+48223344556', N'zofia.wisniewska@example.com', N'DL1234567896', CAST(N'2024-05-08' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (5, N'Marek', N'Sobczak', N'+48225566778', N'marek.sobczak@example.com', N'DL1234567897', CAST(N'2024-06-22' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (6, N'Agnieszka', N'Król', N'+48662211333', N'agnieszka.krol@example.com', N'DL1234567898', CAST(N'2024-07-10' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (7, N'Karol', N'Włodarczyk', N'+48662222333', N'karol.wlodarczyk@example.com', N'DL1234567899', CAST(N'2024-08-05' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (8, N'Elżbieta', N'Nowicka', N'+48662233444', N'elzbieta.nowicka@example.com', N'DL1234567800', CAST(N'2024-09-15' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (9, N'Wojciech', N'Adamczyk', N'+48662244555', N'wojciech.adamczyk@example.com', N'DL1234567801', CAST(N'2024-10-01' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (10, N'Dominik', N'Czerwiński', N'+48678901234', N'dominik.czerwinski@example.com', N'DL1234567802', CAST(N'2024-11-01' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (11, N'Natalia', N'Jankowska', N'+48712345678', N'natalia.jankowska@example.com', N'DL1234567803', CAST(N'2024-12-01' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (12, N'Bartłomiej', N'Wysocki', N'+48675432109', N'bartlomiej.wysocki@example.com', N'DL1234567804', CAST(N'2024-12-15' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (13, N'Sylwia', N'Leśniak', N'+48765432101', N'sylwia.lesniak@example.com', N'DL1234567805', CAST(N'2024-12-20' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (14, N'Krzysztof', N'Borkowski', N'+48787654321', N'krzysztof.borkowski@example.com', N'DL1234567806', CAST(N'2025-01-01' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (15, N'Monika', N'Kaczmarek', N'+48123456789', N'monika.kaczmarek@example.com', N'DL1234567807', CAST(N'2025-01-05' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (16, N'Tomasz', N'Majewski', N'+48234567890', N'tomasz.majewski@example.com', N'DL1234567808', CAST(N'2025-01-10' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (17, N'Marta', N'Kamińska', N'+48345678901', N'marta.kaminska@example.com', N'DL1234567809', CAST(N'2025-01-15' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (18, N'Adrian', N'Wiśniewski', N'+48456789012', N'adrian.wisniewski@example.com', N'DL1234567810', CAST(N'2025-01-20' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (19, N'Dorota', N'Zielińska', N'+48567890123', N'dorota.zielinska@example.com', N'DL1234567811', CAST(N'2025-01-25' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (20, N'Grzegorz', N'Pawlak', N'+48678901234', N'grzegorz.pawlak@example.com', N'DL1234567812', CAST(N'2025-01-30' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (21, N'Aleksandra', N'Stępień', N'+48789012345', N'aleksandra.stepien@example.com', N'DL1234567813', CAST(N'2025-02-01' AS Date))
INSERT [dbo].[tbl_Customers] ([Customer_Id], [First_Name], [Last_Name], [Phone], [Email], [Driver_Licence_Number], [Registration_Date]) VALUES (22, N'Paweł', N'Adamczak', N'+48890123456', N'pawel.adamczak@example.com', N'DL1234567814', CAST(N'2025-02-05' AS Date))
SET IDENTITY_INSERT [dbo].[tbl_Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_DailyMileagePackages] ON 

INSERT [dbo].[tbl_DailyMileagePackages] ([Package_Id], [Package_Name], [Max_Kilometers_Per_Day], [Price]) VALUES (1, N'Basic Package', 100, CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[tbl_DailyMileagePackages] ([Package_Id], [Package_Name], [Max_Kilometers_Per_Day], [Price]) VALUES (2, N'Standard Package', 200, CAST(15.00 AS Decimal(10, 2)))
INSERT [dbo].[tbl_DailyMileagePackages] ([Package_Id], [Package_Name], [Max_Kilometers_Per_Day], [Price]) VALUES (3, N'Premium Package', 300, CAST(20.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[tbl_DailyMileagePackages] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Employees] ON 

INSERT [dbo].[tbl_Employees] ([Employee_Id], [First_Name], [Last_Name], [Role], [Login], [Password]) VALUES (1, N'John', N'Doe', 1, N'jdoe', 0x25f43b1486ad95a1398e3eeb3d83bc4010015fcc9bedb35b432e00298d5021f7)
INSERT [dbo].[tbl_Employees] ([Employee_Id], [First_Name], [Last_Name], [Role], [Login], [Password]) VALUES (2, N'Jane', N'Smith', 2, N'jsmith', 0xd45acc07cf93a1c5c133b39ca648d402feb4f48a6e3ffaa90106d88e5dbe1e84)
INSERT [dbo].[tbl_Employees] ([Employee_Id], [First_Name], [Last_Name], [Role], [Login], [Password]) VALUES (3, N'Bob', N'Brown', 3, N'bbrown', 0xffa8add1d021f6733a5ee5e26d524c00ae411d32551fe0ca0d733038eae6d564)
SET IDENTITY_INSERT [dbo].[tbl_Employees] OFF
GO
INSERT [dbo].[tbl_Payment_Methods] ([Method_Id], [Name]) VALUES (1, N'Card')
INSERT [dbo].[tbl_Payment_Methods] ([Method_Id], [Name]) VALUES (2, N'Cash')
INSERT [dbo].[tbl_Payment_Methods] ([Method_Id], [Name]) VALUES (3, N'Bank transfer')
GO
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (1, CAST(360.00 AS Decimal(10, 2)), CAST(N'2024-11-06T10:00:00.000' AS DateTime), 1)
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (3, CAST(400.00 AS Decimal(10, 2)), CAST(N'2024-12-05T14:30:00.000' AS DateTime), 1)
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (4, CAST(550.00 AS Decimal(10, 2)), CAST(N'2024-12-14T12:00:00.000' AS DateTime), 3)
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (5, CAST(490.00 AS Decimal(10, 2)), CAST(N'2024-12-20T16:00:00.000' AS DateTime), 2)
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (6, CAST(700.00 AS Decimal(10, 2)), CAST(N'2024-12-09T14:00:00.000' AS DateTime), 1)
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (7, CAST(400.00 AS Decimal(10, 2)), CAST(N'2024-12-10T11:00:00.000' AS DateTime), 3)
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (9, CAST(300.00 AS Decimal(10, 2)), CAST(N'2024-12-21T10:00:00.000' AS DateTime), 1)
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (10, CAST(450.00 AS Decimal(10, 2)), CAST(N'2024-12-25T18:00:00.000' AS DateTime), 3)
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (11, CAST(600.00 AS Decimal(10, 2)), CAST(N'2024-12-26T09:00:00.000' AS DateTime), 1)
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (15, CAST(300.00 AS Decimal(10, 2)), CAST(N'2024-12-21T14:00:00.000' AS DateTime), 2)
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (16, CAST(350.00 AS Decimal(10, 2)), CAST(N'2024-12-24T15:00:00.000' AS DateTime), 1)
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (18, CAST(400.00 AS Decimal(10, 2)), CAST(N'2024-12-23T16:00:00.000' AS DateTime), 3)
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (20, CAST(700.00 AS Decimal(10, 2)), CAST(N'2024-12-26T17:00:00.000' AS DateTime), 1)
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (21, CAST(300.00 AS Decimal(10, 2)), CAST(N'2024-12-27T18:00:00.000' AS DateTime), 2)
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (30, CAST(300.00 AS Decimal(10, 2)), CAST(N'2025-01-02T12:00:00.000' AS DateTime), 2)
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (33, CAST(400.00 AS Decimal(10, 2)), CAST(N'2025-01-02T14:00:00.000' AS DateTime), 1)
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (36, CAST(500.00 AS Decimal(10, 2)), CAST(N'2025-01-02T16:00:00.000' AS DateTime), 3)
INSERT [dbo].[tbl_Payments] ([Reservation_Id], [Amount], [Payment_Date], [Payment_Method]) VALUES (38, CAST(350.00 AS Decimal(10, 2)), CAST(N'2025-01-02T18:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[tbl_Repair_Statuses] ([Status_Id], [Name]) VALUES (1, N'Reported')
INSERT [dbo].[tbl_Repair_Statuses] ([Status_Id], [Name]) VALUES (2, N'In repair')
INSERT [dbo].[tbl_Repair_Statuses] ([Status_Id], [Name]) VALUES (3, N'Done')
GO
SET IDENTITY_INSERT [dbo].[tbl_Repairs] ON 

INSERT [dbo].[tbl_Repairs] ([Repair_Id], [Car_Id], [Report_Date], [Description], [Status], [End_Date], [Employee_Id], [Cost]) VALUES (1, 1, CAST(N'2024-12-05T00:00:00.000' AS DateTime), N'Brake replacement', 3, CAST(N'2024-12-06T00:00:00.000' AS DateTime), 2, CAST(150.00 AS Decimal(10, 2)))
INSERT [dbo].[tbl_Repairs] ([Repair_Id], [Car_Id], [Report_Date], [Description], [Status], [End_Date], [Employee_Id], [Cost]) VALUES (2, 3, CAST(N'2024-12-14T00:00:00.000' AS DateTime), N'Oil change', 3, CAST(N'2024-12-16T00:00:00.000' AS DateTime), 1, CAST(120.00 AS Decimal(10, 2)))
INSERT [dbo].[tbl_Repairs] ([Repair_Id], [Car_Id], [Report_Date], [Description], [Status], [End_Date], [Employee_Id], [Cost]) VALUES (3, 6, CAST(N'2024-12-09T00:00:00.000' AS DateTime), N'Tire replacement', 3, CAST(N'2024-12-11T00:00:00.000' AS DateTime), 3, CAST(100.00 AS Decimal(10, 2)))
INSERT [dbo].[tbl_Repairs] ([Repair_Id], [Car_Id], [Report_Date], [Description], [Status], [End_Date], [Employee_Id], [Cost]) VALUES (4, 15, CAST(N'2024-12-06T00:00:00.000' AS DateTime), N'Battery replacement', 3, CAST(N'2024-12-10T00:00:00.000' AS DateTime), 1, CAST(200.00 AS Decimal(10, 2)))
INSERT [dbo].[tbl_Repairs] ([Repair_Id], [Car_Id], [Report_Date], [Description], [Status], [End_Date], [Employee_Id], [Cost]) VALUES (5, 8, CAST(N'2024-12-23T00:00:00.000' AS DateTime), N'Engine diagnostics', 3, CAST(N'2024-12-28T00:00:00.000' AS DateTime), 2, CAST(250.00 AS Decimal(10, 2)))
INSERT [dbo].[tbl_Repairs] ([Repair_Id], [Car_Id], [Report_Date], [Description], [Status], [End_Date], [Employee_Id], [Cost]) VALUES (6, 10, CAST(N'2024-12-26T00:00:00.000' AS DateTime), N'Suspension repair', 1, NULL, 3, CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[tbl_Repairs] ([Repair_Id], [Car_Id], [Report_Date], [Description], [Status], [End_Date], [Employee_Id], [Cost]) VALUES (7, 14, CAST(N'2025-01-02T00:00:00.000' AS DateTime), N'Brake repair', 3, CAST(N'2025-01-05T00:00:00.000' AS DateTime), 2, CAST(400.00 AS Decimal(10, 2)))
INSERT [dbo].[tbl_Repairs] ([Repair_Id], [Car_Id], [Report_Date], [Description], [Status], [End_Date], [Employee_Id], [Cost]) VALUES (8, 16, CAST(N'2025-01-02T00:00:00.000' AS DateTime), N'Oil leak repair', 1, NULL, 1, CAST(350.00 AS Decimal(10, 2)))
INSERT [dbo].[tbl_Repairs] ([Repair_Id], [Car_Id], [Report_Date], [Description], [Status], [End_Date], [Employee_Id], [Cost]) VALUES (9, 18, CAST(N'2025-01-02T00:00:00.000' AS DateTime), N'Engine diagnostics', 3, CAST(N'2025-01-10T00:00:00.000' AS DateTime), 3, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[tbl_Repairs] ([Repair_Id], [Car_Id], [Report_Date], [Description], [Status], [End_Date], [Employee_Id], [Cost]) VALUES (10, 20, CAST(N'2025-01-02T00:00:00.000' AS DateTime), N'Software update', 1, NULL, 1, CAST(100.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[tbl_Repairs] OFF
GO
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (1, 1)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (1, 2)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (2, 3)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (3, 1)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (3, 3)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (4, 2)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (5, 3)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (6, 1)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (6, 2)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (7, 3)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (8, 1)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (9, 2)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (10, 3)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (14, 1)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (15, 2)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (16, 3)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (17, 1)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (18, 2)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (19, 3)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (20, 1)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (21, 2)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (30, 1)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (33, 2)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (36, 3)
INSERT [dbo].[tbl_Reservation_Options] ([Reservation_Id], [Option_Id]) VALUES (38, 1)
GO
INSERT [dbo].[tbl_Reservation_Statuses] ([Status_Id], [Name]) VALUES (1, N'Active')
INSERT [dbo].[tbl_Reservation_Statuses] ([Status_Id], [Name]) VALUES (2, N'Ended')
INSERT [dbo].[tbl_Reservation_Statuses] ([Status_Id], [Name]) VALUES (3, N'Canceled')
GO
INSERT [dbo].[tbl_Roles] ([Position_Id], [Name]) VALUES (1, N'Admin')
INSERT [dbo].[tbl_Roles] ([Position_Id], [Name]) VALUES (2, N'Customer Service')
INSERT [dbo].[tbl_Roles] ([Position_Id], [Name]) VALUES (3, N'Repairs')
GO
/****** Object:  Index [IX_Customer_Id]    Script Date: 3.01.2025 11:29:21 ******/
CREATE NONCLUSTERED INDEX [IX_Customer_Id] ON [dbo].[tbl_Car_Reservations]
(
	[Customer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Car_Id]    Script Date: 3.01.2025 11:29:21 ******/
CREATE NONCLUSTERED INDEX [IX_Car_Id] ON [dbo].[tbl_Repairs]
(
	[Car_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_Customers] ADD  DEFAULT ('2024-01-01') FOR [Registration_Date]
GO
ALTER TABLE [dbo].[tbl_Repairs] ADD  DEFAULT ((100.00)) FOR [Cost]
GO
ALTER TABLE [dbo].[tbl_Addresses]  WITH CHECK ADD FOREIGN KEY([Customer_Id])
REFERENCES [dbo].[tbl_Customers] ([Customer_Id])
GO
ALTER TABLE [dbo].[tbl_Car_Reservations]  WITH CHECK ADD FOREIGN KEY([Car_Id])
REFERENCES [dbo].[tbl_Cars] ([Car_Id])
GO
ALTER TABLE [dbo].[tbl_Car_Reservations]  WITH CHECK ADD FOREIGN KEY([Customer_Id])
REFERENCES [dbo].[tbl_Customers] ([Customer_Id])
GO
ALTER TABLE [dbo].[tbl_Car_Reservations]  WITH CHECK ADD FOREIGN KEY([Employee_Id])
REFERENCES [dbo].[tbl_Employees] ([Employee_Id])
GO
ALTER TABLE [dbo].[tbl_Car_Reservations]  WITH CHECK ADD  CONSTRAINT [FK_DailyMileagePackage] FOREIGN KEY([DailyMileagePackage_Id])
REFERENCES [dbo].[tbl_DailyMileagePackages] ([Package_Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tbl_Car_Reservations] CHECK CONSTRAINT [FK_DailyMileagePackage]
GO
ALTER TABLE [dbo].[tbl_Payments]  WITH CHECK ADD FOREIGN KEY([Reservation_Id])
REFERENCES [dbo].[tbl_Car_Reservations] ([Reservation_Id])
GO
ALTER TABLE [dbo].[tbl_Repairs]  WITH CHECK ADD FOREIGN KEY([Car_Id])
REFERENCES [dbo].[tbl_Cars] ([Car_Id])
GO
ALTER TABLE [dbo].[tbl_Repairs]  WITH CHECK ADD FOREIGN KEY([Employee_Id])
REFERENCES [dbo].[tbl_Employees] ([Employee_Id])
GO
ALTER TABLE [dbo].[tbl_Reservation_Options]  WITH CHECK ADD FOREIGN KEY([Option_Id])
REFERENCES [dbo].[tbl_Additional_Options] ([Option_Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Reservation_Options]  WITH CHECK ADD FOREIGN KEY([Reservation_Id])
REFERENCES [dbo].[tbl_Car_Reservations] ([Reservation_Id])
ON DELETE CASCADE
GO
USE [master]
GO
ALTER DATABASE [VroomRental] SET  READ_WRITE 
GO
