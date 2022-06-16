using AcademyF_ATCIT.Week8.Core;
using AcademyF_ATCIT.Week8.Core.BusinessLayer;
using AcademyF_ATCIT.Week8.Core.Interfaces;
using AcademyF_ATCIT.Week8.EcommLogin.Messages;
using AcademyF_ATCIT.Week8.RepositoryMOCK.Repos;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AcademyF_ATCIT.Week8.EcommLogin
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            DependencyContainer.Register<IBusinessLayer, BusinessLayer>();
            DependencyContainer.Register<IRepositoryUser, RepositoryUserMOCK>();
            DependencyContainer.Register<IRepositoryDipendente, RepositoryDipendentiMOCK>();
            DependencyContainer.Register<IRepositoryProdotti, RepositoryProdottiMOCK>();

            Messenger.Default.Register<DialogMessage>(this, OnDialogMessage);
        }

        private void OnDialogMessage(DialogMessage msg)
        {
            var result = MessageBox.Show(
                msg.Content,
                msg.Title,
                msg.Button,
                msg.Icon);
        }
    }    
}

