using Perpus_Visual.viewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Perpus_Visual
{
    /// <summary>
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class admin : Window
    {
        public admin()
        {
            InitializeComponent();
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
                    DataContext = new DataBukuAdmin() ;
                    break;
                case 3:
                    DataContext = new DataMember();
                    break;
                case 4:
                    DataContext = new DataPinjamAdmin();
                    break;
                case 5:
                    DataContext = new Laporan();
                    break;
                case 6:
                    this.Close();
                    break;
            }
        }

    }
}
