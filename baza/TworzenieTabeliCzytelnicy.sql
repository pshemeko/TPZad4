USE [AJPO2]
GO

/****** Object:  Table [dbo].[Czytelnicy]    Script Date: 2019-01-06 14:11:04 ******/
DROP TABLE [dbo].[Czytelnicy]
GO

/****** Object:  Table [dbo].[Czytelnicy]    Script Date: 2019-01-06 14:11:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Czytelnicy](
	[ID_czytelnika] [int] IDENTITY(1,1) NOT NULL,
	[Nazwisko] [nchar](20) NULL,
	[Imie] [nchar](11) NULL,
	[Pesel] [nchar](11) NULL,
	[Plec] [nchar](1) NULL,
	[Telefon] [nchar](16) NULL,
 CONSTRAINT [PK_Czytelnicy] PRIMARY KEY CLUSTERED 
(
	[ID_czytelnika] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


