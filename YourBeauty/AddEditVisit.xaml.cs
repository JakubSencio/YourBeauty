﻿using MahApps.Metro.Controls;
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
using MahApps.Metro.Controls;
using System.Windows;
using YourBeauty.Models;
using YourBeauty.ViewModels;
using YourBeauty.Models.Wrappers;

namespace YourBeauty.Views
{
    public partial class AddEditVisit : MetroWindow
    {
        public AddEditVisit(ClientWrapper client = null)
        {
            InitializeComponent();
            DataContext = new AddEditVisitViewModel(client);
        }
    }
}