USE [master]
GO
/****** Object:  Database [School]    Script Date: 5/19/2020 7:43:22 PM ******/
CREATE DATABASE [School]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'School', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\School.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'School_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\School_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [School] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [School].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [School] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [School] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [School] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [School] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [School] SET ARITHABORT OFF 
GO
ALTER DATABASE [School] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [School] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [School] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [School] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [School] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [School] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [School] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [School] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [School] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [School] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [School] SET  DISABLE_BROKER 
GO
ALTER DATABASE [School] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [School] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [School] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [School] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [School] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [School] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [School] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [School] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [School] SET  MULTI_USER 
GO
ALTER DATABASE [School] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [School] SET DB_CHAINING OFF 
GO
ALTER DATABASE [School] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [School] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [School]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admin](
	[admin_id] [char](10) NOT NULL,
	[name_id] [int] NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[admin_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Class]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Class](
	[cls_id] [int] IDENTITY(100,1) NOT NULL,
	[cls_name] [varchar](50) NOT NULL,
	[time_id] [int] NULL,
	[section] [varchar](20) NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[cls_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Log_In]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Log_In](
	[log_id] [int] IDENTITY(1,1) NOT NULL,
	[l_id] [int] NOT NULL,
	[password] [char](30) NOT NULL,
	[role] [char](20) NOT NULL,
 CONSTRAINT [PK_Log_In] PRIMARY KEY CLUSTERED 
(
	[log_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Log_In_Id]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Log_In_Id](
	[l_id] [int] IDENTITY(1,1) NOT NULL,
	[stu_id] [char](10) NULL,
	[teacher_id] [char](10) NULL,
	[admin_id] [char](10) NULL,
 CONSTRAINT [PK_Log_In_Id] PRIMARY KEY CLUSTERED 
(
	[l_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Name]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Name](
	[name_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](45) NOT NULL,
	[last_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Name] PRIMARY KEY CLUSTERED 
(
	[name_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Parent]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parent](
	[parent_id] [int] IDENTITY(1,1) NOT NULL,
	[name_id] [int] NOT NULL,
 CONSTRAINT [PK_parent] PRIMARY KEY CLUSTERED 
(
	[parent_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Read_Subject]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Read_Subject](
	[rs_id] [int] IDENTITY(1,1) NOT NULL,
	[stu_id] [char](10) NOT NULL,
	[sub_id] [int] NOT NULL,
	[result] [int] NULL,
 CONSTRAINT [PK_Read_Subject] PRIMARY KEY CLUSTERED 
(
	[rs_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[stu_id] [char](10) NOT NULL,
	[name_id] [int] NOT NULL,
	[parent_id] [int] NOT NULL,
	[address] [nvarchar](100) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[phone] [nchar](11) NOT NULL,
	[admin_id] [char](10) NULL,
	[dob] [date] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[stu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student_Take_Class]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student_Take_Class](
	[tsc_id] [int] IDENTITY(1,1) NOT NULL,
	[stu_id] [char](10) NOT NULL,
	[cls_id] [int] NOT NULL,
 CONSTRAINT [PK_Student_Take_Class] PRIMARY KEY CLUSTERED 
(
	[tsc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subject](
	[sub_id] [int] IDENTITY(1,1) NOT NULL,
	[sub_name] [nvarchar](50) NOT NULL,
	[teacher_id] [char](10) NULL,
	[time_id] [int] NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[sub_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Teacher](
	[teacher_id] [char](10) NOT NULL,
	[name_id] [int] NOT NULL,
	[phone] [nchar](11) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[address] [varchar](100) NOT NULL,
	[admin_id] [char](10) NULL,
	[dob] [date] NOT NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[teacher_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Teacher_assigned_class]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Teacher_assigned_class](
	[tac_id] [int] IDENTITY(10,1) NOT NULL,
	[teacher_id] [char](10) NOT NULL,
	[cls_id] [int] NOT NULL,
 CONSTRAINT [PK_Teacher_assigned_class] PRIMARY KEY CLUSTERED 
(
	[tac_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Time_Table]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Time_Table](
	[time_id] [int] IDENTITY(1,1) NOT NULL,
	[time] [varchar](50) NOT NULL,
	[day] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Time_Table] PRIMARY KEY CLUSTERED 
(
	[time_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[Class_Student]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Class_Student]
                                        as
                                      Select stu_id from Student_Take_Class,class
                                     where Student_Take_Class.cls_id=Class.cls_id 
                                     and cls_name='Class - 6' and section='A'
GO
/****** Object:  View [dbo].[Find_Subject]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[Find_Subject]
                                          as
                                      select sub_id,sub_name,Teacher_assigned_class.teacher_id as teacher_id,cls_id 
                                     from Subject,Teacher_assigned_class
                                     where Subject.teacher_id=Teacher_assigned_class.teacher_id; 
GO
/****** Object:  View [dbo].[Routine]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Routine]
                                            as
                                      select time_id,sub_name from Subject,Read_Subject
                                          where Read_Subject.sub_id=Subject.sub_id and stu_id=''; 
GO
/****** Object:  View [dbo].[S_Profile]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[S_Profile]
                                               as
                                          select parent_id,first_name+' '+last_name as name
                                            from Parent,Name
                                            where Parent.name_id=Name.name_id; 
GO
/****** Object:  View [dbo].[S_Search]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[S_Search] as select stu_id,first_name+' '+last_name as name,email
                                  from Student,Name
                                 where Student.name_id=Name.name_id ;
GO
/****** Object:  View [dbo].[Student_Profile]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Student_Profile]
                                        as
                                       select first_name+' '+last_name as name ,email,stu_id
                                     from Name,Student
                                      where Student.name_id=Name.name_id;
GO
/****** Object:  View [dbo].[Subject_Teacher]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Subject_Teacher]
                                              as
                                     select teacher_id,first_name+' '+last_name as name from Teacher,Name where Teacher.name_id=Name.name_id; 
GO
/****** Object:  View [dbo].[Test]    Script Date: 5/19/2020 7:43:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW [dbo].[Test] AS select teacher_id,first_name+' '+last_name as name,phone,email,address,dob 
                                                   from Teacher,Name where Teacher.name_id=Name.name_id;
GO
INSERT [dbo].[Admin] ([admin_id], [name_id]) VALUES (N'O-100013  ', 1041)
SET IDENTITY_INSERT [dbo].[Class] ON 

INSERT [dbo].[Class] ([cls_id], [cls_name], [time_id], [section]) VALUES (101, N'Class - 6', NULL, N'A')
SET IDENTITY_INSERT [dbo].[Class] OFF
SET IDENTITY_INSERT [dbo].[Log_In] ON 

INSERT [dbo].[Log_In] ([log_id], [l_id], [password], [role]) VALUES (10, 10, N'111222                        ', N'Teacher             ')
INSERT [dbo].[Log_In] ([log_id], [l_id], [password], [role]) VALUES (11, 11, N'668152                        ', N'Teacher             ')
INSERT [dbo].[Log_In] ([log_id], [l_id], [password], [role]) VALUES (12, 12, N'555666                        ', N'Student             ')
INSERT [dbo].[Log_In] ([log_id], [l_id], [password], [role]) VALUES (14, 14, N'333444                        ', N'Officer             ')
SET IDENTITY_INSERT [dbo].[Log_In] OFF
SET IDENTITY_INSERT [dbo].[Log_In_Id] ON 

INSERT [dbo].[Log_In_Id] ([l_id], [stu_id], [teacher_id], [admin_id]) VALUES (10, NULL, N'T-20005   ', NULL)
INSERT [dbo].[Log_In_Id] ([l_id], [stu_id], [teacher_id], [admin_id]) VALUES (11, NULL, N'T-20011   ', NULL)
INSERT [dbo].[Log_In_Id] ([l_id], [stu_id], [teacher_id], [admin_id]) VALUES (12, N'S-20001   ', NULL, NULL)
INSERT [dbo].[Log_In_Id] ([l_id], [stu_id], [teacher_id], [admin_id]) VALUES (14, NULL, NULL, N'O-100013  ')
SET IDENTITY_INSERT [dbo].[Log_In_Id] OFF
SET IDENTITY_INSERT [dbo].[Name] ON 

INSERT [dbo].[Name] ([name_id], [first_name], [last_name]) VALUES (1037, N'Tabiul', N'Hasan')
INSERT [dbo].[Name] ([name_id], [first_name], [last_name]) VALUES (1038, N'Habibur', N'Rahman')
INSERT [dbo].[Name] ([name_id], [first_name], [last_name]) VALUES (1039, N'Tanaz', N'Rahman')
INSERT [dbo].[Name] ([name_id], [first_name], [last_name]) VALUES (1040, N'Mahbuba', N'Sultan')
INSERT [dbo].[Name] ([name_id], [first_name], [last_name]) VALUES (1041, N'Mahfujur', N'Rahman')
SET IDENTITY_INSERT [dbo].[Name] OFF
SET IDENTITY_INSERT [dbo].[Parent] ON 

INSERT [dbo].[Parent] ([parent_id], [name_id]) VALUES (11, 1040)
SET IDENTITY_INSERT [dbo].[Parent] OFF
SET IDENTITY_INSERT [dbo].[Read_Subject] ON 

INSERT [dbo].[Read_Subject] ([rs_id], [stu_id], [sub_id], [result]) VALUES (1, N'S-20001   ', 4, 32)
SET IDENTITY_INSERT [dbo].[Read_Subject] OFF
INSERT [dbo].[Student] ([stu_id], [name_id], [parent_id], [address], [email], [phone], [admin_id], [dob]) VALUES (N'S-20001   ', 1039, 11, N'Dhaka,Bangladesh', N'piyal05@gmail.com', N'01925153682', NULL, CAST(0xF42B0B00 AS Date))
SET IDENTITY_INSERT [dbo].[Student_Take_Class] ON 

INSERT [dbo].[Student_Take_Class] ([tsc_id], [stu_id], [cls_id]) VALUES (3, N'S-20001   ', 101)
SET IDENTITY_INSERT [dbo].[Student_Take_Class] OFF
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([sub_id], [sub_name], [teacher_id], [time_id]) VALUES (2, N' Bangla', N'T-20005   ', 1)
INSERT [dbo].[Subject] ([sub_id], [sub_name], [teacher_id], [time_id]) VALUES (4, N' Social Science', N'T-20005   ', 3)
INSERT [dbo].[Subject] ([sub_id], [sub_name], [teacher_id], [time_id]) VALUES (1002, N' Mathematics', N'T-20011   ', 1002)
SET IDENTITY_INSERT [dbo].[Subject] OFF
INSERT [dbo].[Teacher] ([teacher_id], [name_id], [phone], [email], [address], [admin_id], [dob]) VALUES (N'T-20005   ', 1037, N'01711511883', N'tabiulIfty@gmail.com', N'Dhaka,Bangladesh', NULL, CAST(0xF7230B00 AS Date))
INSERT [dbo].[Teacher] ([teacher_id], [name_id], [phone], [email], [address], [admin_id], [dob]) VALUES (N'T-20011   ', 1038, N'01715113920', N'habib@gmail.com', N'Dhaka,Bangladesh', NULL, CAST(0x6DF80A00 AS Date))
SET IDENTITY_INSERT [dbo].[Teacher_assigned_class] ON 

INSERT [dbo].[Teacher_assigned_class] ([tac_id], [teacher_id], [cls_id]) VALUES (10, N'T-20011   ', 101)
SET IDENTITY_INSERT [dbo].[Teacher_assigned_class] OFF
SET IDENTITY_INSERT [dbo].[Time_Table] ON 

INSERT [dbo].[Time_Table] ([time_id], [time], [day]) VALUES (1, N' 11.00AM to 12.00PM', N'Saturday')
INSERT [dbo].[Time_Table] ([time_id], [time], [day]) VALUES (2, N' 12.00PM to 1.00PM', N'Saturday')
INSERT [dbo].[Time_Table] ([time_id], [time], [day]) VALUES (3, N' 3.00PM to 4.00PM', N'Saturday')
INSERT [dbo].[Time_Table] ([time_id], [time], [day]) VALUES (4, N' 2.00PM to 3.00PM', N'Sunday')
INSERT [dbo].[Time_Table] ([time_id], [time], [day]) VALUES (1002, N' 11.00PM to 12.00PM', N'Sunday')
SET IDENTITY_INSERT [dbo].[Time_Table] OFF
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [FK_Admin_Name] FOREIGN KEY([name_id])
REFERENCES [dbo].[Name] ([name_id])
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [FK_Admin_Name]
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_Time_Table] FOREIGN KEY([time_id])
REFERENCES [dbo].[Time_Table] ([time_id])
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_Time_Table]
GO
ALTER TABLE [dbo].[Log_In]  WITH CHECK ADD  CONSTRAINT [FK_Log_In_Log_In_Id] FOREIGN KEY([l_id])
REFERENCES [dbo].[Log_In_Id] ([l_id])
GO
ALTER TABLE [dbo].[Log_In] CHECK CONSTRAINT [FK_Log_In_Log_In_Id]
GO
ALTER TABLE [dbo].[Log_In_Id]  WITH CHECK ADD  CONSTRAINT [FK_Log_In_Id_Admin] FOREIGN KEY([admin_id])
REFERENCES [dbo].[Admin] ([admin_id])
GO
ALTER TABLE [dbo].[Log_In_Id] CHECK CONSTRAINT [FK_Log_In_Id_Admin]
GO
ALTER TABLE [dbo].[Log_In_Id]  WITH CHECK ADD  CONSTRAINT [FK_Log_In_Id_Student] FOREIGN KEY([stu_id])
REFERENCES [dbo].[Student] ([stu_id])
GO
ALTER TABLE [dbo].[Log_In_Id] CHECK CONSTRAINT [FK_Log_In_Id_Student]
GO
ALTER TABLE [dbo].[Log_In_Id]  WITH CHECK ADD  CONSTRAINT [FK_Log_In_Id_Teacher] FOREIGN KEY([teacher_id])
REFERENCES [dbo].[Teacher] ([teacher_id])
GO
ALTER TABLE [dbo].[Log_In_Id] CHECK CONSTRAINT [FK_Log_In_Id_Teacher]
GO
ALTER TABLE [dbo].[Parent]  WITH CHECK ADD  CONSTRAINT [FK_parent_Name] FOREIGN KEY([name_id])
REFERENCES [dbo].[Name] ([name_id])
GO
ALTER TABLE [dbo].[Parent] CHECK CONSTRAINT [FK_parent_Name]
GO
ALTER TABLE [dbo].[Read_Subject]  WITH CHECK ADD  CONSTRAINT [FK_Read_Subject_Student] FOREIGN KEY([stu_id])
REFERENCES [dbo].[Student] ([stu_id])
GO
ALTER TABLE [dbo].[Read_Subject] CHECK CONSTRAINT [FK_Read_Subject_Student]
GO
ALTER TABLE [dbo].[Read_Subject]  WITH CHECK ADD  CONSTRAINT [FK_Read_Subject_Subject] FOREIGN KEY([sub_id])
REFERENCES [dbo].[Subject] ([sub_id])
GO
ALTER TABLE [dbo].[Read_Subject] CHECK CONSTRAINT [FK_Read_Subject_Subject]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Admin] FOREIGN KEY([admin_id])
REFERENCES [dbo].[Admin] ([admin_id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Admin]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Name] FOREIGN KEY([name_id])
REFERENCES [dbo].[Name] ([name_id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Name]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_parent] FOREIGN KEY([parent_id])
REFERENCES [dbo].[Parent] ([parent_id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_parent]
GO
ALTER TABLE [dbo].[Student_Take_Class]  WITH CHECK ADD  CONSTRAINT [FK_Student_Take_Class_Class] FOREIGN KEY([cls_id])
REFERENCES [dbo].[Class] ([cls_id])
GO
ALTER TABLE [dbo].[Student_Take_Class] CHECK CONSTRAINT [FK_Student_Take_Class_Class]
GO
ALTER TABLE [dbo].[Student_Take_Class]  WITH CHECK ADD  CONSTRAINT [FK_Student_Take_Class_Student] FOREIGN KEY([stu_id])
REFERENCES [dbo].[Student] ([stu_id])
GO
ALTER TABLE [dbo].[Student_Take_Class] CHECK CONSTRAINT [FK_Student_Take_Class_Student]
GO
ALTER TABLE [dbo].[Subject]  WITH CHECK ADD  CONSTRAINT [FK_Subject_Teacher] FOREIGN KEY([teacher_id])
REFERENCES [dbo].[Teacher] ([teacher_id])
GO
ALTER TABLE [dbo].[Subject] CHECK CONSTRAINT [FK_Subject_Teacher]
GO
ALTER TABLE [dbo].[Subject]  WITH CHECK ADD  CONSTRAINT [FK_Subject_Time_Table] FOREIGN KEY([time_id])
REFERENCES [dbo].[Time_Table] ([time_id])
GO
ALTER TABLE [dbo].[Subject] CHECK CONSTRAINT [FK_Subject_Time_Table]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Admin] FOREIGN KEY([admin_id])
REFERENCES [dbo].[Admin] ([admin_id])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Admin]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Name] FOREIGN KEY([name_id])
REFERENCES [dbo].[Name] ([name_id])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Name]
GO
ALTER TABLE [dbo].[Teacher_assigned_class]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_assigned_class_Class] FOREIGN KEY([cls_id])
REFERENCES [dbo].[Class] ([cls_id])
GO
ALTER TABLE [dbo].[Teacher_assigned_class] CHECK CONSTRAINT [FK_Teacher_assigned_class_Class]
GO
ALTER TABLE [dbo].[Teacher_assigned_class]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_assigned_class_Teacher] FOREIGN KEY([teacher_id])
REFERENCES [dbo].[Teacher] ([teacher_id])
GO
ALTER TABLE [dbo].[Teacher_assigned_class] CHECK CONSTRAINT [FK_Teacher_assigned_class_Teacher]
GO
USE [master]
GO
ALTER DATABASE [School] SET  READ_WRITE 
GO
