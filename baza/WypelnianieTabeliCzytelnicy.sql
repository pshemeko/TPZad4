USE [AJPO2]
GO

INSERT INTO [dbo].[Czytelnicy]
           ([Nazwisko]
           ,[Imie]
           ,[Pesel]
           ,[Plec]
           ,[Telefon])
     VALUES
			( 'Brzeczyszczykiewicz', 'Grzegorz' , '76030553421', 'm' ,'500-432-954'),
			( 'Nowak', 'Jan', '20111234653', 'm', '678-654-234'),
			( 'Zarobiona', 'Ilona', '90052287544', 'k', '800543765'),
			( 'WajchePrzeloz', 'tadeusz', '67113056741', 'm', '634-435-655'),
			( 'Zbidula', 'Urszula', '02020245654', 'k', '800400800')

GO


