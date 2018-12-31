using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Prism.Commands;
using Prism.Mvvm;
using WarstwaUslug;
using Zadanie4.Model;
using Zadanie4.View;

namespace Zadanie4.ViewModel
{
    public class MainViewModel : BindableBase
    {
        private ObservableCollection<Wypozyczenia> wypozyczenia;
        private ObservableCollection<Czytelnicy> czytelnicy;
        private Wypozyczenia biezaceWypozyczenie;
        private Czytelnicy biezacyCzytelnik;
        private DataLayer dataLayer;

        // właściwości do pobrania danych
        private string noweNazwisko;
        public string NoweNazwisko
        {
            get => noweNazwisko;
            set
            {
                noweNazwisko = value;
                RaisePropertyChanged();
            }
        }

        private string noweImie;
        public string NoweImie
        {
            get => noweImie;
            set
            {
                noweImie = value;
                RaisePropertyChanged();
            }
        }

        private string nowePesel;
        public string NowePesel
        {
            get => nowePesel;
            set
            {
                nowePesel = value;
                RaisePropertyChanged();
            }
        }

        private char nowePlec;
        public char NowePlec
        {
            get => nowePlec;
            set
            {
                nowePlec = value;
                RaisePropertyChanged();
            }
        }

        private string noweTelefon;
        public string NoweTelefon
        {
            get => noweTelefon;
            set
            {
                noweTelefon = value;
                RaisePropertyChanged();
            }
        }
        
        //do Wyozyczenia
        private int nowyCzytelnicyID;
        public int NowyCzytelnicyID
        {
            get => nowyCzytelnicyID;
            set
            {
                nowyCzytelnicyID = value;
                RaisePropertyChanged();
            }
        }

        private string noweSygnatura;
        public string NoweSygnatura
        {
            get => noweSygnatura;
            set
            {
                noweSygnatura = value;
                RaisePropertyChanged();
            }
        }

        private string noweTytulKsiazki;
        public string NoweTytulKsiazki
        {
            get => noweTytulKsiazki;
            set
            {
                noweTytulKsiazki = value;
                RaisePropertyChanged();
            }
        }

        private string noweAutor;
        public string NoweAutor
        {
            get => noweAutor;
            set
            {
                noweAutor = value;
                RaisePropertyChanged();
            }
        }

        private string noweGatunek;
        public string NoweGatunek
        {
            get => noweGatunek;
            set
            {
                noweGatunek = value;
                RaisePropertyChanged();
            }
        }

        private double noweKara;
        public double NoweKara
        {
            get => noweKara;
            set
            {
                noweKara = value;
                RaisePropertyChanged();
            }
        }

        public Czytelnicy BiezacyCzytelnik
        {
            get => biezacyCzytelnik;
            set
            {
                biezacyCzytelnik = value;
                RaisePropertyChanged();
            }
        }

        public Wypozyczenia BiezaceWypozyczenie
        {
            get => biezaceWypozyczenie;
            set
            {
                biezaceWypozyczenie = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<Wypozyczenia> WypozyczeniaKolekcja
        {
            get => wypozyczenia;
            set
            {
                wypozyczenia = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<Czytelnicy> CzytelnicyKolekcja
        {
            get => czytelnicy;
            set
            {
                czytelnicy = value;
                RaisePropertyChanged();
            }
        }

        public DataLayer DataLayer
        {
            get => dataLayer;
            set
            {
                dataLayer = value;
                WypozyczeniaKolekcja = new ObservableCollection<Wypozyczenia>(value.Wypozyczenia);
                CzytelnicyKolekcja = new ObservableCollection<Czytelnicy>(value.Czytelnicy);
            }
        }


        // TODO Dalej


    }
}
