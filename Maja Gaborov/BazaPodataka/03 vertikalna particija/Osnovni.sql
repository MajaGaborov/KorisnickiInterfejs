USE [master]
GO

CREATE DATABASE [SEMINARSKIOsnovnaBazaOsnovni]
GO

USE [SEMINARSKIOsnovnaBazaOsnovni]
GO

CREATE TABLE [dbo].[SemRad](
[ID] [nvarchar](15) NOT NULL PRIMARY KEY,
	[ImeKandidata] [nvarchar](30) NOT NULL,
	[PrezimeKandidata] [nvarchar](30) NOT NULL,
	[MestoKandidata] [nvarchar] (10) NOT NULL,
	[AdresaKandidata] [nvarchar](20) NOT NULL,
	[OblastTakmicenja] [nvarchar](60) NOT NULL
	
)
	
GO

