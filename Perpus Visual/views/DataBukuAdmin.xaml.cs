﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Perpus_Visual.views
{
    /// <summary>
    /// Interaction logic for DataBukuAdmin.xaml
    /// </summary>
    public partial class DataBukuAdmin : UserControl
    {
        public DataBukuAdmin()
        {
            InitializeComponent();
        }

        private void addBook_Click(object sender, RoutedEventArgs e)
        {
            AddBook book = new AddBook();
            book.Show();
        }
    }
}
