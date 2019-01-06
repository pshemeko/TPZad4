USE [AJPO2]
GO

ALTER TABLE [dbo].[Wypozyczenia] DROP CONSTRAINT [FK_wypozyczenia_czytelnicy]
GO

/****** Object:  Table [dbo].[Wypozyczenia]    Script Date: 2019-01-06 14:11:23 ******/
DROP TABLE [dbo].[Wypozyczenia]
GO

/****** Object:  Table [dbo].[Wypozyczenia]    Script Date: 2019-01-06 14:11:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Wypozyczenia](
	[ID_wypozyczenia] [int] IDENTITY(1,1) NOT NULL,
	[ID_czytelnika] [int] NULL,
	[Sygnatura] [nchar](23) NOT NULL,
	[Tytul_ksiazki] [nchar](25) NOT NULL,
	[Autor] [nchar](25) NULL,
	[Gatunek] [nchar](25) NULL,
	[Kara] [float] NULL,
 CONSTRAINT [PK_Wypozyczenia] PRIMARY KEY CLUSTERED 
(
	[ID_wypozyczenia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Wypozyczenia]  WITH CHECK ADD  CONSTRAINT [FK_wypozyczenia_czytelnicy] FOREIGN KEY([ID_czytelnika])
REFERENCES [dbo].[Czytelnicy] ([ID_czytelnika])
GO

ALTER TABLE [dbo].[Wypozyczenia] CHECK CONSTRAINT [FK_wypozyczenia_czytelnicy]
GO





