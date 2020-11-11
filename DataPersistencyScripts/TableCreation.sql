USE [AreosaManagerDB]
GO

/****** Object:  Table [dbo].[tbl_Users]    Script Date: 10/11/2020 23:55:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT 1 
           FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME='tbl_Users')
BEGIN
	CREATE TABLE [dbo].[tbl_Users](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Email] [nvarchar](1) NOT NULL,
		[Name] [nvarchar](1) NOT NULL,
		[Password] [nvarchar](1) NOT NULL,
		[CreationDate] [date] NOT NULL,
		[LastLogin] [datetime] NULL
	) ON [PRIMARY]
END
GO

