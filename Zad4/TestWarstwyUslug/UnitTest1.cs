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
            DataRepository.DataContext = new DataBaseDataContext();
        }

        [TestMethod()]
        public void GetAllWyporzyczeniaTest()
        {
            var lista = DataRepository.GetAllWypozyczenia().Select(v => v.ID_wypozyczenia);

            Assert.AreEqual(6, lista.Count());
            //Assert.IsTrue(lista.Contains(1));
            Assert.IsTrue(lista.Contains(2));
            Assert.IsTrue(lista.Contains(3));
            Assert.IsTrue(lista.Contains(4));
            Assert.IsTrue(lista.Contains(5));
        }

        [TestMethod()]
        public void CreateWyporzyczenieTest()
        {
            int ilosc1 = DataRepository.GetAllWypozyczenia().Count();

            Wypozyczenia w = new Wypozyczenia()
            {
               // ID_wypozyczenia = 200, // chyba nie trzeba
                ID_czytelnika = 2,
                Sygnatura = "ISBN454-3424-424-2443-3",
                Tytul_ksiazki = "Ja jako byly",
                Autor = "Jan",
                Gatunek = "Popularno-Naukowy",
                Kara = 0.0
            };

            DataRepository.CreateWypozyczenia(w);

            int ilosc2 = DataRepository.GetAllWypozyczenia().Count;

            Assert.AreNotEqual(ilosc1, ilosc2);

            // czyszczenie bazy
            DataRepository.DeleteWypozyczeniaPoId(w.ID_wypozyczenia);

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
                Sygnatura = "ISBN454-3424-424-2443-3",
                Tytul_ksiazki = "Ja jako byly"
            };

            DataRepository.CreateWypozyczenia(w);

            int ilosc1 = DataRepository.GetAllWypozyczenia().Count();

            DataRepository.DeleteWypozyczeniaPoId(w.ID_wypozyczenia);

            int ilosc2 = DataRepository.GetAllWypozyczenia().Count;

            Assert.AreNotEqual(ilosc1, ilosc2);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Wypozyczenia w = new Wypozyczenia()
            {
                ID_wypozyczenia = 200, // chyba nie trzeba
                ID_czytelnika = 2,
                Autor = "Jan",
                Gatunek = "Popularno-Naukowy",
                Kara = 0.0,
                Sygnatura = "ISBN454-3424-424-2443-3",
                Tytul_ksiazki = "Ja jako byly"
            };

            DataRepository.CreateWypozyczenia(w);

            w.Autor = "noweImie";

            DataRepository.UpdateWypozyczenia(w);

            List<Wypozyczenia> toTestList = DataRepository.GetAllWypozyczenia();

            Assert.AreEqual(toTestList.Last().Autor, "noweImie");

            // czyszczenie bazy
            DataRepository.DeleteWypozyczeniaPoId(w.ID_wypozyczenia);
        }




   
    }
}
