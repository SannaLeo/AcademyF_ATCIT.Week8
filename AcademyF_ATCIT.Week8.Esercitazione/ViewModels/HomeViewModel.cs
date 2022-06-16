using AcademyF_ATCIT.Week8.Esercitazione.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace AcademyF_ATCIT.Week8.Esercitazione.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private List<Prodotti> _prodotti;
        private List<Prodotti> _carrello;
        private Prodotti _prodotto_selezionato = null;
        private string _prodotto_da_mostrare = "";
        private decimal _totale=0;
        private bool _isVisible = false;
        
        public ICommand SelezionaProdottoCommand { get; set; }
        public ICommand AggiungiProdottoCommand { get; set; }
        public ICommand RimuoviProdottoCommand { get; set; }

        public List<Prodotti> Prodotti
        {
            get { return _prodotti; }
            set { _prodotti = value; RaisePropertyChanged(); }
        }
        public List<Prodotti> Carrello
        {
            get { return _carrello; }
            set { _carrello = value; RaisePropertyChanged(); }
        }

        public Prodotti Prodottoselezionato
        {
            get { return _prodotto_selezionato; }
            set { _prodotto_selezionato = value; RaisePropertyChanged(); }
        }

        public string ProdottoDaMostrare
        {
            get { return _prodotto_da_mostrare; }
            set { _prodotto_da_mostrare = value; RaisePropertyChanged(); }
        }

        public decimal Totale { get
            {
                return _totale;
            }
            set
            {
                _totale = value;
                RaisePropertyChanged();
            } 
        }
        public bool IsVisible
        {
            get { return _isVisible; }
            set { _isVisible = value; RaisePropertyChanged(); }
        }


        public HomeViewModel()
        {
            SelezionaProdottoCommand = new RelayCommand(SelezionaProdotto);
            AggiungiProdottoCommand = new RelayCommand(AggiungiAlCarrello);
            RimuoviProdottoCommand = new RelayCommand(TogliDalCarrello);
            Carrello = new List<Prodotti>();
            Prodotti = new List<Prodotti>
            {
                new Prodotti
                {
                    Name = "PC molto bello",
                    Tipo = "Elettronica",
                    Prezzo = 1420.69m
                },
                new Prodotti 
                { 
                    Name = "Pc non molto bello",
                    Tipo = "Elettronica",
                    Prezzo = 350.00m
                },
                new Prodotti
                {
                    Name = "Telefono mela",
                    Tipo = "Elettronica",
                    Prezzo = 1234.56m
                },
                new Prodotti
                {
                    Name = "Telefono Robot",
                    Tipo = "Elettronica",
                    Prezzo = 1600.00m
                },
                new Prodotti
                {
                    Name = "Telefono",
                    Tipo = "Elettronica",
                    Prezzo = 500.00m
                },
            };
        }

        public void SelezionaProdotto()
        {
            if (Prodottoselezionato == null)
                return;
            
            ProdottoDaMostrare = Prodottoselezionato.ToString();
        }

        public void AggiungiAlCarrello()
        {
            if (Prodottoselezionato == null)
                return;
            Carrello.Add(Prodottoselezionato);
            Totale = Carrello.Sum(p => p.Prezzo);
        }

        public void TogliDalCarrello()
        {
            if (Prodottoselezionato == null)
                return;
            Carrello.Remove(Prodottoselezionato);
            Totale = Carrello.Sum(p => p.Prezzo);
        }
    }
}
