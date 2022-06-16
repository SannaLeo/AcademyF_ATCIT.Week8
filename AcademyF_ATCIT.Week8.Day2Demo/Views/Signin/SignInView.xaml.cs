using AcademyF_ATCIT.Week8.Day2Demo.ViewModels.SignIn;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AcademyF_ATCIT.Week8.Day2Demo.Views.Signin
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
        }

        private void LoginCommand(object sender, RoutedEventArgs e)
        {
            txtMessaggio.Text = "Login avvenuto! Benvenuto/a " + $"{user.Text.ToString()}";
        }
    }
}
