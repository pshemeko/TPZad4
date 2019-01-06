USE [AJPO]
GO

/****** Object:  Table [dbo].[czytelnicy]    Script Date: 2018-12-13 21:27:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[czytelnicy](
	[id_czytelnika] [int] NOT NULL,
	[nazwisko] [nchar](20) NULL,
	[imie] [nchar](11) NULL,
	[pesel] [nchar](11) NULL,
	[plec] [nchar](1) NULL,
	[telefon] [nchar](16) NULL,
 CONSTRAINT [PK_czytelnicy] PRIMARY KEY CLUSTERED 
(
	[id_czytelnika] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


