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

namespace perpusVisual
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPinjam(object sender, RoutedEventArgs e)
        {
            adminPeminjaman pinjam = new adminPeminjaman();
            pinjam.Show();
            this.Hide();
        }

        private void btnKembalian(object sender, RoutedEventArgs e)
        {
            adminPengembalian kembalian = new adminPengembalian();
            kembalian.Show();
            this.Hide();
        }
        private void btnDataBuku(object sender, RoutedEventArgs e)
        {
            adminDataBuku dataBuku = new adminDataBuku();
            dataBuku.Show();
            this.Hide();
        }
        private void btnDataMember(object sender, RoutedEventArgs e)
        {
            adminDataMember dataMember = new adminDataMember();
            dataMember.Show();
            this.Hide();
        }
        private void btnDataPinjam(object sender, RoutedEventArgs e)
        {
            adminDataPinjam dataPinjam = new adminDataPinjam();
            dataPinjam.Show();
            this.Hide();
        }
        private void btnLaporan(object sender, RoutedEventArgs e)
        {
            adminLaporan laporan = new adminLaporan();
            laporan.Show();
            this.Hide();
        }
        private void btnLogout(object sender, RoutedEventArgs e)
        {
            selfMainWindows logout = new selfMainWindows();
            logout.Show();
            this.Close();
        }
    }
}
