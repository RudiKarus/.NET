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

namespace WPFGeometriePfad
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

        private void aendern(object sender, RoutedEventArgs e)
        {
            PathGeometry pg = Pt.Data as PathGeometry;
            ArcSegment asg = pg.Figures[1].Segments[0] as ArcSegment; //Bogenradius des ersten Segments der zweiten Figur;
            asg.Size = new Size(asg.Size.Width + 5, asg.Size.Height + 5);
        }
    }
}
