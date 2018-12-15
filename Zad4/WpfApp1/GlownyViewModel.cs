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
//using ServiceLayer;
//using Zadanie4.Model;
//using Zadanie4.View;
using System.Windows.Forms;

namespace WpfApp1
{
    class GlownyViewModel : BindableBase
    {

        private ObservableCollection<wypozyczenia> wypozyczonka;
        private ObservableCollection<czytelnicy> czytelniki;
        private wypozyczenia bierzaceWypozyczenie;
        private czytelnicy biezacyczytelnik;
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
        private string newCzytelnikNazwisko;
        public string NewCzytelnikNazwisko
        {
            get => newCzytelnikNazwisko;
            set
            {
                newCzytelnikNazwisko = value;
                RaisePropertyChanged();
            }
        }
        private string newCzytelnikImie;
        public string NewCzytelnikImie
        {
            get => newCzytelnikImie;
            set
            {
                newCzytelnikImie = value;
                RaisePropertyChanged();
            }
        }
        private string newCzytelnikPesel;
        public string NewCzytelnikPesel
        {
            get => newCzytelnikPesel;
            set
            {
                newCzytelnikPesel = value;
                RaisePropertyChanged();
            }
        }
        private char newCzytelnikPlec;
        public char NewCzytelnikPlec
        {
            get => newCzytelnikPlec;
            set
            {
                newCzytelnikPlec = value;
                RaisePropertyChanged();
            }
        }
        private string newCzytelnikTelefon;
        public string NewCzytelnikTelefon
        {
            get => newCzytelnikTelefon;
            set
            {
                newCzytelnikTelefon = value;
                RaisePropertyChanged();
            }
        }



        private int newWypozyczeniaId;
        public int NewWypozyczeniaId
        {
            get => newWypozyczeniaId;
            set
            {
                newWypozyczeniaId = value;
                RaisePropertyChanged();
            }
        }
        private string newWypozyczeniaSygnatura;
        public string NewWypozyczeniaSygnatura
        {
            get => newWypozyczeniaSygnatura;
            set
            {
                newWypozyczeniaSygnatura = value;
                RaisePropertyChanged();
            }
        }

        private int newWypozyczeniaIdCzytelnika;
        public int NewWypozyczeniaIdCzytelnika
        {
            get => newWypozyczeniaIdCzytelnika;
            set
            {
                newWypozyczeniaIdCzytelnika = value;
                RaisePropertyChanged();
            }
        }

        private string newWypozyczenieTytulKsiazki;
        public string NewWypozyczenieTytulKsiazki
        {
            get => newWypozyczenieTytulKsiazki;
            set
            {
                newWypozyczenieTytulKsiazki = value;
                RaisePropertyChanged();
            }
        }
        private string newWypozyczenieAutor;
        public string NewWypozyczenieAutor
        {
            get => newWypozyczenieAutor;
            set
            {
                newWypozyczenieAutor = value;
                RaisePropertyChanged();
            }
        }
        private string newWypozyczenieGatunek;
        public string NewWypozyczenieGatunek
        {
            get => newWypozyczenieGatunek;
            set
            {
                newWypozyczenieGatunek = value;
                RaisePropertyChanged();
            }
        }

        private double newWypozyczenieKara;
        public double NewWypozyczenieKara
        {
            get => newWypozyczenieKara;
            set
            {
                newWypozyczenieKara = value;
                RaisePropertyChanged();
            }
        }


        public ObservableCollection<wypozyczenia> Wypozyczeniaa
        {
            get => wypozyczonka;
            set { wypozyczonka = value; RaisePropertyChanged(); }
        }

        public ObservableCollection<czytelnicy> Czytelnicyy
        {
            get => czytelniki;
            set { czytelniki = value; RaisePropertyChanged(); }
        }

        public wypozyczenia BiezaceWypozyczenie
        {
            get => bierzaceWypozyczenie;
            set
            {
                bierzaceWypozyczenie = value;
                RaisePropertyChanged();
                // ustawienie currentProduct
                BiezacyCzytelnik = czytelniki.First(p => p.id_czytelnika == bierzaceWypozyczenie.id_czytelnika);
            }
        }

        public czytelnicy BiezacyCzytelnik
        {
            get => biezacyczytelnik;
            set { biezacyczytelnik = value; RaisePropertyChanged(); }
        }

        public DataLayer DataLayer
        {
            get => dataLayer;
            set
            {
                dataLayer = value;
                Wypozyczeniaa = new ObservableCollection<wypozyczenia>(value.Wypozyczenia);
                Czytelnicyy = new ObservableCollection<czytelnicy>(value.Czytelnicy);
            }
        }

        public DelegateCommand GetDataCommand { get; private set; } //TODO zmien nazwy

        public DelegateCommand AddProductReviewCommand { get; private set; }

        public DelegateCommand DeleteProductReviewCommand { get; private set; }

        public DelegateCommand UpdateProductReviewCommand { get; private set; }

        public DelegateCommand DodajOknoDodawaniaKlienta { get; private set; }

        public DelegateCommand DodajCzytelnikaCommand { get; private set; }


        public GlownyViewModel()
        {

            dataLayer = new DataLayer();
            GetDataCommand = new DelegateCommand(() => DataLayer = new DataLayer());
            AddProductReviewCommand = new DelegateCommand(AddProductReview);
            DeleteProductReviewCommand = new DelegateCommand(DeleteProductReview);
            UpdateProductReviewCommand = new DelegateCommand(EditProductReview);
            DodajCzytelnikaCommand = new DelegateCommand(DodajCzytelnika);
            DodajOknoDodawaniaKlienta = new DelegateCommand(FunkcjaDoOkna);
            czytelniki = new ObservableCollection<czytelnicy>();
        }

        private void EditProductReview()
        {
            Task.Run(() => { DataRepository.UpdateWypozyczenie(bierzaceWypozyczenie); });
        }

        private void DeleteProductReview()
        {
            Task.Run(() => { DataRepository.DeleteWypozyczeniePoId(bierzaceWypozyczenie.id_w); });
            wypozyczonka.Remove(bierzaceWypozyczenie);
        }

        private void AddProductReview()
        {
            if (NewWypozyczeniaSygnatura.Length <= 25 && NewWypozyczenieTytulKsiazki.Length <= 50 && NewWypozyczenieAutor.Length <= 50 &&
                NewWypozyczenieGatunek.Length <= 25 && NewWypozyczenieKara >= 0.0 && DataRepository.CzyIstniejeUzytkownikZId(NewWypozyczeniaIdCzytelnika))
            {

                wypozyczenia pr = new wypozyczenia()
                {
                    id_w = NewWypozyczeniaId, // wywalic bo bdzie automatycznie generowany numer
                    sygnatura = NewWypozyczeniaSygnatura,
                    id_czytelnika = NewWypozyczeniaIdCzytelnika,
                    tytul_ksiazki = NewWypozyczenieTytulKsiazki,
                    autor = NewWypozyczenieAutor,
                    gatunek = NewWypozyczenieGatunek,
                    kara = NewWypozyczenieKara,
                    //czytelnicy = NewCzytelnikID

                };
                wypozyczonka.Add(pr);
                Task.Run(() => { DataRepository.CreateWypozyczenie(pr);});
            }
            else System.Windows.MessageBox.Show("Podane dane wypozyczenia nie mogą zostać przekazane do bazy danych", "Błąd");
        }

        private void DodajCzytelnika() // TODO zaczalem wlasnie
        {
            if (NewCzytelnikNazwisko.Length <= 50 && NewCzytelnikImie.Length <= 50 && NewCzytelnikPesel.Length <= 11 &&
                 NewCzytelnikTelefon.Length <= 16 && !DataRepository.CzyIstniejeCzytelnikZId(NewCzytelnikID))
            {
                czytelnicy cz = new czytelnicy()
                {
                    id_czytelnika = NewCzytelnikID,
                    imie = NewCzytelnikImie,
                    nazwisko = NewCzytelnikNazwisko,
                    pesel = NewCzytelnikPesel,
                    plec = NewCzytelnikPlec,
                    telefon = NewCzytelnikTelefon
                };
                czytelniki.Add(cz);
                Task.Run(() => { DataRepository.StworzCzytelnika(cz); });
            }
            else System.Windows.MessageBox.Show("Podane dane Czytelnika nie mogą zostać przekazane do bazy danych", "Błąd");
            
        }


        public void FunkcjaDoOkna() // nazwya sie jak bindig z przyciku
        {
            okno2 okienko2 = new okno2();
            okienko2.Show();
        }






    }
}
