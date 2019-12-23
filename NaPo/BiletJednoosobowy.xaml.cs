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
    public partial class BiletJednoosobowy : Window
    {
        public BiletJednoosobowy()
        {
            InitializeComponent();
            Com1.Items.Add("Olsztyn");
            Com1.Items.Add("Kętrzyn");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Klik1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Convert.ToString(Com1.Text));

        }
    }
}
