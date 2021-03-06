USE [master]
GO
/****** Object:  Database [Student_System]    Script Date: 15-May-14 11:15:08 AM ******/
CREATE DATABASE [Student_System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Student_System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Student_System.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Student_System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Student_System_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Student_System] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Student_System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Student_System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Student_System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Student_System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Student_System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Student_System] SET ARITHABORT OFF 
GO
ALTER DATABASE [Student_System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Student_System] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Student_System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Student_System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Student_System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Student_System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Student_System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Student_System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Student_System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Student_System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Student_System] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Student_System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Student_System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Student_System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Student_System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Student_System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Student_System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Student_System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Student_System] SET RECOVERY FULL 
GO
ALTER DATABASE [Student_System] SET  MULTI_USER 
GO
ALTER DATABASE [Student_System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Student_System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Student_System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Student_System] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Student_System', N'ON'
GO
USE [Student_System]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 15-May-14 11:15:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Exams]    Script Date: 15-May-14 11:15:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exams](
	[ExamDate] [date] NOT NULL,
	[StudentID] [int] NOT NULL,
	[ProfessorID] [int] NOT NULL,
	[Grade] [numeric](3, 2) NOT NULL,
 CONSTRAINT [PK_Exams] PRIMARY KEY CLUSTERED 
(
	[ExamDate] ASC,
	[StudentID] ASC,
	[ProfessorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professors]    Script Date: 15-May-14 11:15:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professors](
	[ProfessorID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[CourseID] [int] NOT NULL,
 CONSTRAINT [PK_Professors] PRIMARY KEY CLUSTERED 
(
	[ProfessorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rank]    Script Date: 15-May-14 11:15:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ranks](
	[RankID] [int] IDENTITY(1,1) NOT NULL,
	[RankType] [nvarchar](12) NOT NULL,
 CONSTRAINT [PK_Ranks] PRIMARY KEY CLUSTERED 
(
	[RankID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Speciality]    Script Date: 15-May-14 11:15:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialities](
	[SpecialityID] [int] IDENTITY(1,1) NOT NULL,
	[SpecialityName] [nvarchar](max) NOT NULL,
	[RankID] [int] NOT NULL,
 CONSTRAINT [PK_Specialities] PRIMARY KEY CLUSTERED 
(
	[SpecialityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 15-May-14 11:15:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentID] [int] IDENTITY(118000,1) NOT NULL,
	[PersonalNumber] [char](10) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[EducationForm] [nvarchar](50) NOT NULL,
	[SpecialityID] [int] NOT NULL,
	[StPassword] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Exams]  WITH CHECK ADD  CONSTRAINT [FK_Exams_Professors] FOREIGN KEY([ProfessorID])
REFERENCES [dbo].[Professors] ([ProfessorID])
GO
ALTER TABLE [dbo].[Exams] CHECK CONSTRAINT [FK_Exams_Professors]
GO
ALTER TABLE [dbo].[Exams]  WITH CHECK ADD  CONSTRAINT [FK_Exams_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([StudentID])
GO
ALTER TABLE [dbo].[Exams] CHECK CONSTRAINT [FK_Exams_Students]
GO
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD  CONSTRAINT [FK_Professors_Courses] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([CourseID])
GO
ALTER TABLE [dbo].[Professors] CHECK CONSTRAINT [FK_Professors_Courses]
GO
ALTER TABLE [dbo].[Specialities]  WITH CHECK ADD  CONSTRAINT [FK_Speciality_Ranks] FOREIGN KEY([RankID])
REFERENCES [dbo].[Ranks] ([RankID])
GO
ALTER TABLE [dbo].[Specialities] CHECK CONSTRAINT [FK_Speciality_Ranks]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Specialities] FOREIGN KEY([SpecialityID])
REFERENCES [dbo].[Specialities] ([SpecialityID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Specialities]
GO
USE [master]
GO
ALTER DATABASE [Student_System] SET  READ_WRITE 
GO
