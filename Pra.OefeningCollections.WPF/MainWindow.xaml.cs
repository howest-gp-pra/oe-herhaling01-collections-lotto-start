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

namespace Pra.OefeningCollections.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initialiseer();
            MaakAllesLeeg();
            MaakAllesWit();
        }
        private void Initialiseer()
        {
        }
        private void MaakAllesLeeg()
        {
        }
        private void MaakAllesWit()
        {
        }
        private void CmbBallen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void RdbJa_Checked(object sender, RoutedEventArgs e)
        {
            if (!this.IsLoaded) return;
        }
        private void RdbNeen_Checked(object sender, RoutedEventArgs e)
        {
            if (!this.IsLoaded) return;
        }
        private void BtnEigenNummers_Click(object sender, RoutedEventArgs e)
        {
        }
        private void BtnWinnendeNummers_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
