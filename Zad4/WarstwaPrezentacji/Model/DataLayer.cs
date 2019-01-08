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
                List<Wypozyczenia> reviews = DataRepository.GetAllWypozyczenia();
                return reviews;
            }
        }

        public IEnumerable<Czytelnicy> Czytelnicys
        {
            get
            {
                List<Czytelnicy> products = DataRepository.GetAllCzytelnicy();
                return products;
            }
        }
    }
}