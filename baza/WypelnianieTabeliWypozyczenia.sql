USE [AJPO]
GO

INSERT INTO [dbo].[wypozyczenia]
           ([id_w]
           ,[sygnatura]
           ,[id_czytelnika]
           ,[tytul_ksiazki]
           ,[autor]
           ,[gatunek]
           ,[kara])
     VALUES
           (1 , 'ISBN 978-83-283-2446-6', 1 , 'C# leksykon wiedzy' ,'Joseph Albahari' , 'naukowa',0.0),
		   (2 , 'ISBN 645-46-456-4655-0', 2 , 'Podroze pana kleka' , 'Pan kleks', 'bajki' , 1.2),
		   (3 , 'ISBN 978-83-283-2480-0', 1 , 'Jacva Podstawy' , 'Cay S. Horstman', 'naukowa',1.7),
		   (4 , 'ISBN 965-43-432-4564-4', 4 , 'Hobbit czyli tam i spowrotem', 'Tolkien', 'legendy', 0.0),
		   (5 , 'ISBN 978-83-204-3472-9', 2 , 'Inzynieria oprogramowania. Wzorce projektowe' , 'Erich Gamma', 'naukowa', 4.6)
GO


