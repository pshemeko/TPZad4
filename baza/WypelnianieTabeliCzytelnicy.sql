USE [AJPO]
GO

INSERT INTO [dbo].[czytelnicy]
           ([id_czytelnika]
           ,[nazwisko]
           ,[imie]
           ,[pesel]
           ,[plec]
           ,[telefon])
     VALUES
			( 1 , 'Brzeczyszczykiewicz', 'Grzegorz' , '76030553421', 'm' ,'500-432-954'),
			( 2 , 'Nowak', 'Jan', '20111234653', 'm', '678-654-234'),
			( 3 , 'Zarobiona', 'Ilona', '90052287544', 'k', '800543765'),
			( 4 , 'WajchePrzeloz', 'tadeusz', '67113056741', 'm', '634-435-655'),
			( 5 , 'Zbidula', 'Urszula', '02020245654', 'k', '800400800')

GO


