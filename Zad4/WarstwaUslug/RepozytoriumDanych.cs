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

        //TODO DOKONCZYC
        // get all, delete update

    }
}
