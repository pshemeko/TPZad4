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
using WarstwaPrezentacji.View;

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

        // DANE CZYTELNIKA

        /// <summary>
        /// dane czytelnikow
        /// </summary>
        /// 
        private int noweID_Czytelnika;

        public int NoweID_Czytelnika
        {
            get => noweID_Czytelnika;
            set
            {
                noweID_Czytelnika = value;
                RaisePropertyChanged();
            }
        }


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

        public DelegateCommand AddCzytelnikCommand { get; private set; }

        public DelegateCommand DeleteWypozyczenieCommand { get; private set; }

        public DelegateCommand DeleteCzytelnikCommand { get; private set; }

        public DelegateCommand UpdateWypozyczenieCommand { get; private set; }

        public DelegateCommand AddWindowCzytelnikaDodaj { get; private set; }

        public DelegateCommand AddWindowWypozyczenieDodaj { get; private set; }

        public MainViewModel()
        {

            dataLayer = new DataLayer();
            GetDataCommand = new DelegateCommand(() => DataLayer = new DataLayer());
            AddWypozyczenieCommand = new DelegateCommand(AddWypozyczenie);
            AddCzytelnikCommand = new DelegateCommand(AddCzytelnik);
            DeleteWypozyczenieCommand = new DelegateCommand(DeleteWypozyczenie);
            DeleteCzytelnikCommand = new DelegateCommand(DeleteCzytelnik);
            UpdateWypozyczenieCommand = new DelegateCommand(EditWypozyczenie);
            czytelnik = new ObservableCollection<Czytelnicy>();
            wypozyczenie = new ObservableCollection<Wypozyczenia>();

            AddWindowCzytelnikaDodaj = new DelegateCommand(AddWindowCzytelnika);
            AddWindowWypozyczenieDodaj = new DelegateCommand(AddWindowWypozyczenie);
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

        private void DeleteCzytelnik()
        {
            Task.Run(() => { DataRepository.DeleteCzytelnikId(biezacyCzytelnik.ID_czytelnika); });
            czytelnik.Remove(biezacyCzytelnik);
        }

        private void AddWindowCzytelnika()
        {
            NowyCzytelnikOkno noweOkno = new NowyCzytelnikOkno();
            noweOkno.Show();
        }
        
        private void AddWindowWypozyczenie()
        {
            NoweWypozyczenie noweOkno2 = new NoweWypozyczenie();
            noweOkno2.Show();
        }



        private void AddWypozyczenie()
        {
            if (newSygnatura.Length <= 23 && newTytul_ksiazki.Length <= 25 && newAutor.Length <= 25 &&
                newKara >= 0 && newGatunek.Length <= 25 && DataRepository.IsCzytelnicyIdValid(newCzytelnikID))
            {
                Wypozyczenia pr = new Wypozyczenia()
                {
                    ID_czytelnika = newCzytelnikID,
                    Sygnatura = newSygnatura,
                    Tytul_ksiazki = newTytul_ksiazki,
                    Autor = newAutor,
                    Gatunek = newGatunek,
                    Kara = newKara                    

                };
                wypozyczenie.Add(pr);
                Task.Run(() => { DataRepository.CreateWypozyczenia(pr); });
            }
            else MessageBox.Show("Podane dane wypozyczenia nie mogą zostać przekazane do bazy danych", "Błąd");
        }

        
        private void AddCzytelnik()
        {
            if (noweNazwisko.Length <= 20 && noweImie.Length <= 11 && nowePesel.Length <= 11 &&
                 noweTelefon.Length <= 16  && !DataRepository.IsCzytelnicyIdValid(newCzytelnikID))
            {
                Czytelnicy pr = new Czytelnicy()
                {
                    ID_czytelnika = newCzytelnikID,
                    Nazwisko = noweNazwisko,
                    Imie = noweImie,
                    Pesel = nowePesel,
                    Plec = nowePlec,
                    Telefon = noweTelefon                    

                };

                int a;
                a = 5;
                czytelnik.Add(pr);
                Task.Run(() => { DataRepository.CreateCzytelnik(pr); });
            }
            else MessageBox.Show("Podane dane Czytelnika nie mogą zostać przekazane do bazy danych", "Błąd");
            
        }

    }
}
