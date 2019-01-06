USE [AJPO2]
GO

INSERT INTO [dbo].[Wypozyczenia]
           ([ID_czytelnika]
		   ,[Sygnatura]
		   ,[Tytul_ksiazki]
		   ,[Autor]
		   ,[Gatunek]
		   ,[Kara])
     VALUES
           (1 ,'ISBN 978-83-283-2446-6', 'C# leksykon wiedzy' ,'Joseph Albahari' , 'naukowa',0.0),
		   (2 ,'ISBN 645-46-456-4655-0', 'Podroze pana kleka' , 'Pan kleks', 'bajki' , 1.2),
		   (1 ,'ISBN 978-83-283-2480-0', 'Java Podstawy' , 'Cay S. Horstman', 'naukowa',1.7),
		   (4 ,'ISBN 965-43-432-4564-4', 'Hobbit, tam i spowrotem', 'Tolkien', 'legendy', 0.0),
		   (2 ,'ISBN 978-83-204-3472-9', 'Inzynieria oprogramowania' , 'Erich Gamma', 'naukowa', 4.6)
GO


