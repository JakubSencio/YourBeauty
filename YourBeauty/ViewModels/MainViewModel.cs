using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using YourBeauty.Commands;
using YourBeauty.Models;
using YourBeauty.Models.Wrappers;
using YourBeauty.Views;

namespace YourBeauty.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            using (var context = new ApplicationDbContext())
            {
                var clients = context.Clients.ToList();
            }

            AddClientCommand = new RelayCommand(AddEditClient);
            EditClientCommand = new RelayCommand(AddEditClient, 
                CanEditDeleteClient);
            DeleteClientCommand = new AsyncRelayCommand(DeleteClient, 
                CanEditDeleteClient);
            RefreshClientsCommand = new RelayCommand(RefreshClients);

            RefreshPanel();
        }



        public ICommand RefreshClientsCommand { get; set; }
        public ICommand AddClientCommand { get; set; }
        public ICommand EditClientCommand { get; set; }
        public ICommand DeleteClientCommand { get; set; }


        private ClientWrapper _selectedClient;
        public ClientWrapper SelectedClient
        {
            get { return _selectedClient; }
            set
            {
                _selectedClient = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<ClientWrapper> _clients;
        public ObservableCollection<ClientWrapper> Clients
        {
            get { return _clients; }
            set
            {
                _clients = value;
                OnPropertyChanged();
            }
        }



        private async Task DeleteClient(object obj)
        {
            var metroWindow = Application.Current.MainWindow as MetroWindow;
            var dialog = await metroWindow.ShowMessageAsync("Usuwanie wizyty", 
                $"Czy napewno chcesz usunąć wizytę klienta " +
                $"{SelectedClient.FirstName} {SelectedClient.LastName} z dnia {SelectedClient.Data}",
                MessageDialogStyle.AffirmativeAndNegative
                );
            if(dialog != MessageDialogResult.Affirmative)
                return;

            RefreshPanel();
        }


        private void AddEditClient(object obj)
        {
            var addEditVisitWindow = new AddEditVisit(obj as ClientWrapper);
            addEditVisitWindow.Closed += AddEditVisitWindow_Closed;
            addEditVisitWindow.ShowDialog();
        }

        private void AddEditVisitWindow_Closed(object sender, EventArgs e)
        {
            RefreshPanel();
        }

        private void RefreshClients(object obj)
        {
            RefreshPanel();
        }
        private bool CanEditDeleteClient(object obj)
        {
            return SelectedClient != null;
        }
        private void RefreshPanel()
        {
            Clients = new ObservableCollection<ClientWrapper>
            {
                new ClientWrapper
                {
                    FirstName = "Jakub",
                    LastName = "Sencio",
                },
                new ClientWrapper
                {
                    FirstName = "Michał",
                    LastName = "Nowak",
                },
                new ClientWrapper
                {
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                },
            };
        }


    }
}
