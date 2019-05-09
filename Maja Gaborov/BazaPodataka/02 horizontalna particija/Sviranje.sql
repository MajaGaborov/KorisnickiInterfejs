USE [master]
GO

CREATE DATABASE [SEMINARSKIOsnovnaBazaSviranje]
GO

USE [SEMINARSKIOsnovnaBazaSviranje]
GO

CREATE TABLE [dbo].[SemRad](
[ID] [nvarchar](15) NOT NULL PRIMARY KEY,
	[ImeKandidata] [nvarchar](30) NOT NULL,
	[PrezimeKandidata] [nvarchar](30) NOT NULL,
	[MestoKandidata] [nvarchar] (10) NOT NULL,
	[AdresaKandidata] [nvarchar](20) NOT NULL,
	[OblastTakmicenja] [nvarchar](60) NOT NULL,
	[BrojGodina] [nvarchar](10) NOT NULL,
	[NazivSkole] [nvarchar](40) NOT NULL
)
	
GO

