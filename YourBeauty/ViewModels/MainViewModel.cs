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

namespace YourBeauty.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            AddClientCommand = new RelayCommand(AddClient);
            EditClientCommand = new RelayCommand(EditClient);
            DeleteClientCommand = new RelayCommand(DeleteClient);
            RefreshClientsCommand = new RelayCommand(RefreshClients);


            Clients = new ObservableCollection<Client> 
            { 
                new Client 
                { 
                    FirstName = "Jakub", 
                    LastName = "Sencio", 
                },
                new Client
                {
                    FirstName = "Michał",
                    LastName = "Nowak",
                },
                new Client
                {
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                },
            };
        }


        public ICommand RefreshClientsCommand { get; set; }
        public ICommand AddClientCommand { get; set; }
        public ICommand EditClientCommand { get; set; }
        public ICommand DeleteClientCommand { get; set; }


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



        private void DeleteClient(object obj)
        {
            throw new NotImplementedException();
        }

        private void EditClient(object obj)
        {
            throw new NotImplementedException();
        }

        private void AddClient(object obj)
        {
            throw new NotImplementedException();
        }
        private void RefreshClients(object obj)
        {
        }



    }
}
