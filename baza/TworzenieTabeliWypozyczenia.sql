USE [AJPO]
GO

/****** Object:  Table [dbo].[wypozyczenia]    Script Date: 2018-12-13 21:25:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[wypozyczenia](
	[id_w] [int] NOT NULL,
	[sygnatura] [nchar](25) NOT NULL,
	[id_czytelnika] [int] NULL,
	[tytul_ksiazki] [nchar](50) NOT NULL,
	[autor] [nchar](50) NULL,
	[gatunek] [nchar](25) NULL,
	[kara] [float] NULL,
 CONSTRAINT [PK_wypozyczenia_1] PRIMARY KEY CLUSTERED 
(
	[id_w] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[wypozyczenia]  WITH CHECK ADD  CONSTRAINT [FK_wypozyczenia_czytelnicy] FOREIGN KEY([id_czytelnika])
REFERENCES [dbo].[czytelnicy] ([id_czytelnika])
GO

ALTER TABLE [dbo].[wypozyczenia] CHECK CONSTRAINT [FK_wypozyczenia_czytelnicy]
GO


