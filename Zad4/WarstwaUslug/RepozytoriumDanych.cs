using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarstwaUslug
{
    public class RepozytoriumDanych
    {
        private static BazaDanychDataContext dataContex = new BazaDanychDataContext();

        public static BazaDanychDataContext DataContex
        {
            get => dataContex;
            set => dataContex = value;
        }

        public static void StworzWyporzyczenie(Wypozyczenia wyp)
        {
            dataContex.Wypozyczenia.InsertOnSubmit(wyp);
            try
            {
                dataContex.SubmitChanges();
            }
            catch (Exception e)
            {

            }
        }

        public static void StworzCzytelnika(Czytelnicy czyt)
        {
            dataContex.Czytelnicy.InsertOnSubmit(czyt);
            try
            {
                DataContex.SubmitChanges();
            }
            catch (Exception e)
            {

            }
        }

        public static List<Wypozyczenia> GetAllWyporzyczenia()
        {
            List<Wypozyczenia> w = (from wypozyczenia in dataContex.Wypozyczenia
                                      select wypozyczenia).ToList();
            return w;
        }

        public static List<Czytelnicy> GetAllCzytelnicy()
        {
            List<Czytelnicy> c = (from czytelnicy in dataContex.Czytelnicy
                                  select czytelnicy).ToList();
            return c;
        }

        public static void DeleteWypozyczenie(int id)
        {
            var daneSkasuj = (from wypozyczenie in dataContex.Wypozyczenia
                              where wypozyczenie.ID_wypozyczenia == id
                              select wypozyczenie).First();
            if (daneSkasuj != null)
            {
                DataContex.Wypozyczenia.DeleteOnSubmit(daneSkasuj);
            }

            try
            {
                dataContex.SubmitChanges();
            }
            catch (Exception e)
            {
            }
        }

        public static void UpdateWypozyczenia(Wypozyczenia wypoz)
        {
            Wypozyczenia wypozyczenieDoZmienienia = dataContex.Wypozyczenia.Single(w => w.ID_wypozyczenia == wypoz.ID_wypozyczenia);

            wypozyczenieDoZmienienia.ID_czytelnika = wypoz.ID_czytelnika;
            wypozyczenieDoZmienienia.Autor = wypoz.Autor;
            wypozyczenieDoZmienienia.Czytelnicy = wypoz.Czytelnicy;
            wypozyczenieDoZmienienia.Gatunek = wypoz.Gatunek;
            wypozyczenieDoZmienienia.Kara = wypoz.Kara;
            wypozyczenieDoZmienienia.Sygnatura = wypoz.Sygnatura;

            try
            {
                dataContex.SubmitChanges();
            }
            catch (Exception e)
            {

            }
        }


        //TODO DOKONCZYC
        // get all, delete update jakies trzeba chyba jeszcze dodac


    }
}
