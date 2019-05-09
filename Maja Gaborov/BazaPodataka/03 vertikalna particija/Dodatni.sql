USE [master]
GO

CREATE DATABASE [SEMINARSKIOsnovnaBazaDodatni]
GO

USE [SEMINARSKIOsnovnaBazaDodatni]
GO

CREATE TABLE [dbo].[SemRad](
	[ID] [nvarchar](15) NOT NULL PRIMARY KEY,
	[BrojGodina] [nvarchar](10) NOT NULL,
	[NazivSkole] [nvarchar](40) NOT NULL
)
	
GO

