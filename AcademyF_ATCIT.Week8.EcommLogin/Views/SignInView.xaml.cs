using AcademyF_ATCIT.Week8.EcommLogin.Messages;
using AcademyF_ATCIT.Week8.EcommLogin.ViewModels;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AcademyF_ATCIT.Week8.EcommLogin.Views
{
    /// <summary>
    /// Interaction logic for SignInView.xaml
    /// </summary>
    public partial class SignInView : Window
    {
        public SignInView()
        {
            InitializeComponent();

            SignInViewModel vm = new SignInViewModel();
            this.DataContext = vm;


            // Mi registro ai messaggi che sono in grado di soddisfare
            Messenger.Default.Register<ShowViewMessage>(this, OnShowViewMessage);
        }

        private void OnShowViewMessage(ShowViewMessage msg)
        {
            if (msg.ViewName == "HomeView")
            {
                HomeView view = new HomeView();
                view.DataContext = new HomeViewModel();

                view.Show();

                this.Close();
            }
        }
    }
}
