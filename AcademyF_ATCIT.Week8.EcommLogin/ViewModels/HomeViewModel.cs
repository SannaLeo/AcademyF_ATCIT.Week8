using AcademyF_ATCIT.Week8.Core;
using AcademyF_ATCIT.Week8.Core.BusinessLayer;
using AcademyF_ATCIT.Week8.Core.Entities;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AcademyF_ATCIT.Week8.EcommLogin.ViewModels
{
    internal class HomeViewModel : ViewModelBase
    {

        private List<Prodotti> _prodotti;
        private List<Prodotti> _carrello;
        private Prodotti _prodotto_selezionato = null;
        private string _prodotto_da_mostrare = "";
        private decimal _totale = 0;
        private bool _isVisible = false;
        IBusinessLayer BL;
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

        public decimal Totale
        {
            get
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
            BL = DependencyContainer.Resolve<IBusinessLayer>();
            Prodotti = BL.GetAllProdotti();
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

