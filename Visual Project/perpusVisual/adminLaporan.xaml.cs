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

namespace perpusVisual
{
    /// <summary>
    /// Interaction logic for adminLaporan.xaml
    /// </summary>
    public partial class adminLaporan : Window
    {
        public adminLaporan()
        {
            InitializeComponent();
        }
        private void btnPinjam(object sender, RoutedEventArgs e)
        {
            adminPeminjaman pinjam = new adminPeminjaman();
            pinjam.Show();
            this.Close();
        }

        private void btnKembalian(object sender, RoutedEventArgs e)
        {
            adminPengembalian kembalian = new adminPengembalian();
            kembalian.Show();
            this.Close();
        }
        private void btnDataBuku(object sender, RoutedEventArgs e)
        {
            adminDataBuku dataBuku = new adminDataBuku();
            dataBuku.Show();
            this.Close();
        }
        private void btnDataMember(object sender, RoutedEventArgs e)
        {
            adminDataMember dataMember = new adminDataMember();
            dataMember.Show();
            this.Close();
        }
        private void btnDataPinjam(object sender, RoutedEventArgs e)
        {
            adminDataPinjam dataPinjam = new adminDataPinjam();
            dataPinjam.Show();
            this.Close();
        }
        private void btnLaporan(object sender, RoutedEventArgs e)
        {
            adminLaporan laporan = new adminLaporan();
            laporan.Show();
            this.Close();
        }
        private void btnLogout(object sender, RoutedEventArgs e)
        {
            selfMainWindows logout = new selfMainWindows();
            logout.Show();
            this.Close();
        }
        private void btnKembali(object sender, RoutedEventArgs e)
        {
            MainWindow back = new MainWindow();
            back.Show();
            this.Close();
        }
    }
}
