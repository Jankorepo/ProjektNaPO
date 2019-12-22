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

namespace NaPo
{
    /// <summary>
    /// Logika interakcji dla klasy BiletJednoosobowy.xaml
    /// </summary>
    public partial class BiletJednoosobowy : Page
    {
        public BiletJednoosobowy()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window strona = (Window)this.Parent;
            strona.Close();

            //BiletWieloosobowy p2 = new BiletWieloosobowy();
            //p2.NavigationService.Navigate(this);

            //Page uri = new BiletWieloosobowy();
            //this.NavigationService.Navigate(uri);

        }
    }
}
