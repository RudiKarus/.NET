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

namespace WPFLayoutKombi
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


        private void B1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("B1");
        }


        private void B2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("B2");
        }


        private void Sp_Click(object sender, RoutedEventArgs e) //object sender verweist aus das Stackpanel; Die Eigenschaft "Source" des Objekts "e" verweist auf den tatsächlich auslösenden Button;
        {
            Button b = e.Source as Button;
            MessageBox.Show(b.Name);
        }
    }
}
