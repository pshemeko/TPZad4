using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarstwaUslug;

namespace WarstwaPrezentacji.Model
{
    public class DataLayer
    {
        public IEnumerable<Wypozyczenia> Wypozyczenias
        {
            get
            {
                IEnumerable<Wypozyczenia> reviews = DataRepository.GetAllWypozyczenia();
                return reviews;
            }
        }

        public IEnumerable<Czytelnicy> Czytelnicys
        {
            get
            {
                IEnumerable<Czytelnicy> products = DataRepository.GetAllCzytelnicy();
                return products;
            }
        }
    }
}