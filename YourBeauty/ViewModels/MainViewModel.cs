using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using YourBeauty.Commands;

namespace YourBeauty.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            RefreshClientsCommand = new RelayCommand(RefreshClients, CanRefreshClients);
        }

        private void RefreshClients(object obj)
        {
            MessageBox.Show("RefreshClients");
        }

        private bool CanRefreshClients(object obj)
        {
            return true;
        }

        public ICommand RefreshClientsCommand {  get; set; }
    }
}
