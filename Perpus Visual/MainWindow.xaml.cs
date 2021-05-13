﻿using Perpus_Visual.models;
using Perpus_Visual.viewModels;
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

namespace Perpus_Visual
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Database db;

        public MainWindow()
        {
            InitializeComponent();
         //   db = new Database();
           // db.Insert();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (150 * index), 45, 0, 0);

            switch (index)
            {
                case 0:
                    DataContext = new Peminjaman();
                    break;
                case 1:
                    DataContext = new Pengembalian();
                    break;
                case 2:
                    DataContext = new DataBuku();
                    break;
                case 3:
                    DataContext = new Login();
                    break;
            }
        }
    }
}
