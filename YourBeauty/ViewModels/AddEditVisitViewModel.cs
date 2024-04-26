using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using YourBeauty.Commands;
using YourBeauty.Models;

namespace YourBeauty.ViewModels
{
    public class AddEditVisitViewModel : ViewModelBase
    {
        public AddEditVisitViewModel(Client client = null)
        {
            CloseCommand = new RelayCommand(Close);
            ConfirmCommand = new RelayCommand(Confirm);

            if(client == null)
            {
                Client = new Client();
            }
            else 
            {
                Client = client;
            }
        }
        private Client _client;

        public Client Client
        {
            get { return _client; }
            set
            { 
                _client = value;
                OnPropertyChanged();
            }
        }
        private void Confirm(object obj)
        {

            CloseWindow(obj as Window);
        }

        private void Close(object obj)
        {
            CloseWindow(obj as Window);
        }
        private void CloseWindow(Window window)
        {
            window.Close();
        }

        public ICommand CloseCommand { get; set; }
        public ICommand ConfirmCommand { get; set;}
    }
}
