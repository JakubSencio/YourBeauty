using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using YourBeauty.Commands;
using YourBeauty.Models;

namespace YourBeauty.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            RefreshClientsCommand = new RelayCommand(RefreshClients);

            Clients = new ObservableCollection<Client> 
            { 
                new Client 
                { 
                    FirstName = "Jakub", 
                    LastName = "Sencio", 
                    Group = new Group { Id = 1 } 
                },
                new Client
                {
                    FirstName = "Michał",
                    LastName = "Nowak",
                    Group = new Group { Id = 2 }
                },
                new Client
                {
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Group = new Group { Id = 3 }
                },
            };
        }
        public ICommand RefreshClientsCommand { get; set; }

        private Client _selectedClient;
        public Client SelectedClient
        {
            get { return _selectedClient; }
            set
            {
                _selectedClient = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Client> _clients;
        public ObservableCollection<Client> Clients
        {
            get { return _clients; }
            set
            {
                _clients = value;
                OnPropertyChanged();
            }
        }

        private void RefreshClients(object obj)
        {
        }



    }
}
