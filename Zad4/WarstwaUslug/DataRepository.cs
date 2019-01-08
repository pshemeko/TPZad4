using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarstwaUslug
{
    public class DataRepository
    {
        private static DataBaseDataContext dataContext = new DataBaseDataContext();

        public static DataBaseDataContext DataContext
        {
            get => dataContext;
            set => dataContext = value;
        }

        public static void CreateWypozyczenia(Wypozyczenia v)
        {
            dataContext.Wypozyczenia.InsertOnSubmit(v);
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {

            }
        }

        public static void CreateCzytelnik(Czytelnicy v)
        {
            dataContext.Czytelnicy.InsertOnSubmit(v);
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {

            }
        }

        public static void DeleteWypozyczeniaPoId(int id)
        {
            Wypozyczenia WypozyczenieDoSkasowania =
                (from review in dataContext.Wypozyczenia
                 where review.ID_wypozyczenia == id
                 select review).First();

            if (WypozyczenieDoSkasowania != null)
            {
                DataContext.Wypozyczenia.DeleteOnSubmit(WypozyczenieDoSkasowania);
            }

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {

            }
        }

        public static void DeleteCzytelnikId(int id)
        {
            Czytelnicy CzytelnikDoSkasowania =
                (from review in dataContext.Czytelnicy
                 where review.ID_czytelnika == id
                 select review).First();

            if (CzytelnikDoSkasowania != null)
            {
                DataContext.Czytelnicy.DeleteOnSubmit(CzytelnikDoSkasowania);
            }

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {

            }
        }


        public static IEnumerable<Wypozyczenia> GetAllWypozyczenia()
        {
            List<Wypozyczenia> reviews = (from productReview in dataContext.Wypozyczenia
                                          select productReview).ToList();

            return reviews;
        }

        public static void UpdateWypozyczenia(Wypozyczenia review)
        {
            Wypozyczenia updatedReview = dataContext.Wypozyczenia.Single(r => r.ID_wypozyczenia == review.ID_wypozyczenia);
            updatedReview.ID_czytelnika = review.ID_czytelnika;
            updatedReview.Sygnatura = review.Sygnatura;
            updatedReview.Tytul_ksiazki = review.Tytul_ksiazki;
            updatedReview.Autor = review.Autor;
            updatedReview.Gatunek = review.Gatunek;
            updatedReview.Kara = review.Kara;
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {

            }
        }

        public static IEnumerable<Czytelnicy> GetAllCzytelnicy()
        {
            List<Czytelnicy> products = (from product in dataContext.Czytelnicy
                                         select product).ToList();
            return products;
        }

        public static int GetIdDlaCzytelnicy(string nazwisko)
        {
            Int32 id = (from p in dataContext.Czytelnicy
                      where p.Nazwisko == nazwisko
                      select p.ID_czytelnika).First();
            return id;
        }

        public static bool IsCzytelnicyIdValid(int id)
        {
            int counter = (from p in dataContext.Czytelnicy
                           where p.ID_czytelnika == id
                           select p).ToList().Count();
            if (counter >= 1) return true;
            else return false;
        }

    }
}

