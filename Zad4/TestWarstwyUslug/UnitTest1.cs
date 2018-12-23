using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarstwaUslug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWarstwyUslug
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void TestInitialize()
        {
            RepozytoriumDanych.DataContex = new BazaDanychDataContext();
        }

        [TestMethod()]
        public void GetAllWyporzyczeniaTest()
        {
            var lista = RepozytoriumDanych.GetAllWyporzyczenia().Select(v => v.ID_wypozyczenia);

            Assert.AreEqual(4, lista.Count());
            Assert.IsTrue(lista.Contains(1));
            Assert.IsTrue(lista.Contains(2));
            Assert.IsTrue(lista.Contains(3));
            Assert.IsTrue(lista.Contains(4));
        }

        [TestMethod()]
        public void CreateWyporzyczenieTest()
        {
            int ilosc1 = RepozytoriumDanych.GetAllWyporzyczenia().Count();

            Wypozyczenia w = new Wypozyczenia()
            {
                ID_wypozyczenia = 200, // chyba nie trzeba
                ID_czytelnika = 2,
                Autor = "Jan",
                Gatunek = "Popularno-Naukowy",
                Kara = 0.0,
                Sygnatura = "ISBN 454-3424-424-2443-3",
                Tytul_ksiazki = "Ja jako byly"                
            };

            RepozytoriumDanych.CreateWyporzyczenie(w);

            int ilosc2 = RepozytoriumDanych.GetAllWyporzyczenia().Count;

            Assert.AreNotEqual(ilosc1, ilosc2);

            // czyszczenie bazy
            RepozytoriumDanych.DeleteWypozyczeniePoID(w.ID_wypozyczenia);

        }

        [TestMethod()]
        public void DeleteWypozyczeniePoIDTest()
        {
            Wypozyczenia w = new Wypozyczenia()
            {
                ID_wypozyczenia = 200, // chyba nie trzeba
                ID_czytelnika = 2,
                Autor = "Jan",
                Gatunek = "Popularno-Naukowy",
                Kara = 0.0,
                Sygnatura = "ISBN 454-3424-424-2443-3",
                Tytul_ksiazki = "Ja jako byly"
            };

            RepozytoriumDanych.CreateWyporzyczenie(w);

            int ilosc1 = RepozytoriumDanych.GetAllWyporzyczenia().Count();

            RepozytoriumDanych.DeleteWypozyczeniePoID(w.ID_wypozyczenia);

            int ilosc2 = RepozytoriumDanych.GetAllWyporzyczenia().Count;

            Assert.AreNotEqual(ilosc1, ilosc2);
        }

        [TestMethod()]
        public void UpdateVendorTest()
        {
            Wypozyczenia w = new Wypozyczenia()
            {
                ID_wypozyczenia = 200, // chyba nie trzeba
                ID_czytelnika = 2,
                Autor = "Jan",
                Gatunek = "Popularno-Naukowy",
                Kara = 0.0,
                Sygnatura = "ISBN 454-3424-424-2443-3",
                Tytul_ksiazki = "Ja jako byly"
            };

            RepozytoriumDanych.CreateWyporzyczenie(w);

            w.Autor = "noweImie";

            RepozytoriumDanych.UpdateWypozyczenia(w);

            List<Wypozyczenia> toTestList = RepozytoriumDanych.GetAllWyporzyczenia();

            Assert.AreEqual(toTestList.Last().Autor, "noweImie");

            // czyszczenie bazy
            RepozytoriumDanych.DeleteWypozyczeniePoID(w.ID_wypozyczenia);
        }


    }
}
