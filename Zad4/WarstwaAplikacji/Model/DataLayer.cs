using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarstwaUslug;

namespace Zadanie4.Model
{
    public class DataLayer
    {
        public IEnumerable<Wypozyczenia> Wypozyczenia
        {
            get
            {
                List<Wypozyczenia> wypozyczenia = RepozytoriumDanych.GetAllWyporzyczenia();
                return wypozyczenia;
            }
        }

        public IEnumerable<Czytelnicy> Czytelnicy
        {
            get
            {
                List<Czytelnicy> czytelnicy = RepozytoriumDanych.GetAllCzytelnicy();
                return czytelnicy;
            }
        }
    }
}
