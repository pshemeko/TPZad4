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
using WarstwaPrezentacji.Model;
//using WarstwaPrezentacji.View;

namespace WarstwaPrezentacji.ViewModel
{
    public class MainViewModel : BindableBase
    {
        private ObservableCollection<Wypozyczenia> wypozyczenie;
        private ObservableCollection<Czytelnicy> czytelnik;
        private Wypozyczenia biezaceWypozyczenie;
        private Czytelnicy biezacyCzytelnik;
        private DataLayer dataLayer;

        // właściwości do pobrania danych
        private int newCzytelnikID;
        public int NewCzytelnikID
        {
            get => newCzytelnikID;
            set
            {
                newCzytelnikID = value;
                RaisePropertyChanged();
            }
        }

        private string newSygnatura;
        public string NewSygnatura
        {
            get => newSygnatura;
            set
            {
                newSygnatura = value;
                RaisePropertyChanged();
            }
        }

        private string newTytul_ksiazki;
        public string NewTytul_ksiazki
        {
            get => newTytul_ksiazki;
            set
            {
                newTytul_ksiazki = value;
                RaisePropertyChanged();
            }
        }

        private string newAutor;
        public string NewAutor
        {
            get => newAutor;
            set
            {
                newAutor = value;
                RaisePropertyChanged();
            }
        }

        private string newGatunek;
        public string NewGatunek
        {
            get => newGatunek;
            set
            {
                newGatunek = value;
                RaisePropertyChanged();
            }
        }

        private double newKara;
        public double NewKara
        {
            get => newKara;
            set
            {
                newKara = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<Wypozyczenia> WypozyczeniaCzytelnikow
        {
            get => wypozyczenie;
            set { wypozyczenie = value; RaisePropertyChanged(); }
        }

        public ObservableCollection<Czytelnicy> Czytelnik
        {
            get => czytelnik;
            set { czytelnik = value; RaisePropertyChanged(); }
        }

        public Wypozyczenia BiezaceWypozyczenie
        {
            get => biezaceWypozyczenie;
            set
            {
                biezaceWypozyczenie = value;
                RaisePropertyChanged();
                // ustawienie biezacyCzytelnik
                BiezacyCzytelnik = czytelnik.First(p => p.ID_czytelnika == biezaceWypozyczenie.ID_czytelnika);
            }
        }

        public Czytelnicy BiezacyCzytelnik
        {
            get => biezacyCzytelnik;
            set { biezacyCzytelnik = value; RaisePropertyChanged(); }
        }

        public DataLayer DataLayer
        {
            get => dataLayer;
            set
            {
                dataLayer = value;
                WypozyczeniaCzytelnikow = new ObservableCollection<Wypozyczenia>(value.Wypozyczenias);
                Czytelnik = new ObservableCollection<Czytelnicy>(value.Czytelnicys);
            }
        }

        public DelegateCommand GetDataCommand { get; private set; }

        public DelegateCommand AddWypozyczenieCommand { get; private set; }

        public DelegateCommand DeleteWypozyczenieCommand { get; private set; }

        public DelegateCommand UpdateWypozyczenieCommand { get; private set; }

        public MainViewModel()
        {

            dataLayer = new DataLayer();
            GetDataCommand = new DelegateCommand(() => DataLayer = new DataLayer());
            AddWypozyczenieCommand = new DelegateCommand(AddWypozyczenie);
            DeleteWypozyczenieCommand = new DelegateCommand(DeleteWypozyczenie);
            UpdateWypozyczenieCommand = new DelegateCommand(EditWypozyczenie);
        }

        private void EditWypozyczenie()
        {
            Task.Run(() => { DataRepository.UpdateWypozyczenia(biezaceWypozyczenie); });
        }

        private void DeleteWypozyczenie()
        {
            Task.Run(() => { DataRepository.DeleteWypozyczeniaPoId(biezaceWypozyczenie.ID_wypozyczenia); });
            wypozyczenie.Remove(biezaceWypozyczenie);
        }

        private void AddWypozyczenie()
        {
            if (newSygnatura.Length <= 50 && newTytul_ksiazki.Length <= 50 && newAutor.Length <= 50 &&
                newKara >= 0 && newGatunek.Length <= 50 && DataRepository.IsCzytelnicyIdValid(newCzytelnikID))
            {
                Wypozyczenia pr = new Wypozyczenia()
                {
                    ID_czytelnika = newCzytelnikID,
                    Autor = newAutor,
                    Gatunek = newGatunek,
                    Kara = newKara,
                    Sygnatura = newSygnatura,
                    Tytul_ksiazki = newTytul_ksiazki

                };
                wypozyczenie.Add(pr);
                Task.Run(() => { DataRepository.CreateWypozyczenia(pr); });
            }
            else MessageBox.Show("Podane dane wypozyczenia nie mogą zostać przekazane do bazy danych", "Błąd");
        }
    }
}
