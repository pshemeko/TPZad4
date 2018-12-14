using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class DataRepository
    {
        private static BazaLinquDataContext dataContext = new BazaLinquDataContext();

        public static BazaLinquDataContext DataContext
        {
            get => dataContext;
            set => dataContext = value;
        }

        public static void CreateWypozyczenie(wypozyczenia v)
        {
            dataContext.wypozyczenia.InsertOnSubmit(v);
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
            }
        }

        public static void StworzCzytelnika(czytelnicy v)
        {
            dataContext.czytelnicy.InsertOnSubmit(v);
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
            }
        }


        public static void DeleteWypozyczeniePoId(int id)
        {
            var wypozyczeniaToDelete =
                (from wypoz in dataContext.wypozyczenia
                 where wypoz.id_w == id
                 select wypoz).First();

            if (wypozyczeniaToDelete != null)
            {
                DataContext.wypozyczenia.DeleteOnSubmit(wypozyczeniaToDelete);
            }

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {

            }
        }

        public static List<wypozyczenia> GetAllWypozyczenia()
        {
            List<wypozyczenia> wypoz = (from wypozyczenia in dataContext.wypozyczenia
                                          select wypozyczenia).ToList();

            return wypoz;
        }

        public static void UpdateWypozyczenie(wypozyczenia wypoz)
        {
            wypozyczenia updatedReview = dataContext.wypozyczenia.Single(r => r.id_w == wypoz.id_w);
            updatedReview.id_czytelnika = wypoz.id_czytelnika;
            updatedReview.autor = wypoz.autor;
            updatedReview.czytelnicy = wypoz.czytelnicy;
            updatedReview.gatunek = wypoz.gatunek;
            updatedReview.kara = wypoz.kara;
            updatedReview.sygnatura = wypoz.sygnatura;
            updatedReview.tytul_ksiazki = wypoz.tytul_ksiazki;
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {

            }
        }

        public static List<czytelnicy> GetAllCzytelnicy()
        {
            List<czytelnicy> czytelnicyy = (from czytelnik in dataContext.czytelnicy
                                         select czytelnik).ToList();
            return czytelnicyy;
        }

        public static int GetIdForNazwiskoCzytelnika(string czyteln)
        {
            var id = (from p in dataContext.czytelnicy
                      where p.nazwisko == czyteln
                      select p.id_czytelnika).First();
            return id;
        }

        public static bool CzyIstniejeUzytkownikZId(int id) //// TODO chyba zle chyba wypozyczenie
        {
            int counter = (from p in dataContext.czytelnicy
                where p.id_czytelnika == id
                select p).ToList().Count();
            if (counter >= 1) return true;
            else return false;
        }

        public static bool CzyIstniejeCzytelnikZId(int id) //// TODO chyba zle chyba wypozyczenie
        {
            int counter = (from p in dataContext.czytelnicy
                           where p.id_czytelnika == id
                           select p).ToList().Count();
            if (counter >= 1) return true;
            else return false;
        }




    }
}
