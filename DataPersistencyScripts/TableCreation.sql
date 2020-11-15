USE [AreosaManagerDB]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT 1 
           FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME='tbl_Users')
BEGIN
--This table was created without a primary key
--constraint that was added later in another file.
--Look for better solution.
--Also, this REALLY needs a "is unique" constraint on email
	CREATE TABLE [dbo].[tbl_Users](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Email] [nvarchar](20) NOT NULL,
		[Name] [nvarchar](20) NOT NULL,
		[Password] [nvarchar](20) NOT NULL,
		[CreationDate] [date] NOT NULL,
		[LastLogin] [datetime] NULL
	) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT 1
			FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_NAME ='tbl_UserRoles')
BEGIN
	CREATE TABLE [dbo].[tbl_UserRoles](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[UserID] [int] NOT NULL,
		[Role] [nvarchar](10) NOT NULL,
		[CreationDate] [date] NOT NULL,
		[AtributionDate] [date] NOT NULL,
		[DeactivationDate] [date] NULL,
		[Active] [bit] Null,
		FOREIGN KEY(UserID) REFERENCES tbl_Users(ID)
	) ON [PRIMARY]
END

