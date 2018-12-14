using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class DataLayer
    {

        public IEnumerable<wypozyczenia> Wypozyczenia
        {
            get
            {
                List<wypozyczenia> wypozyczeniaa = DataRepository.GetAllWypozyczenia();
                return wypozyczeniaa;
            }
        }

        public IEnumerable<czytelnicy> Czytelnicy
        {
            get
            {
                List<czytelnicy> czytelnicyy = DataRepository.GetAllCzytelnicy();
                return czytelnicyy;
            }
        }
    }
}
