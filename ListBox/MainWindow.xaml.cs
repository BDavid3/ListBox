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

namespace ListBox
{
    public partial class MainWindow : Window
    {

        List<string> nevekLista = new List<string>() { "Kovács Anna", "Nagy Béla", "Szabó Kata" };
        public MainWindow()
        {
            InitializeComponent();
            lbNevek.ItemsSource = null;
            lbNevek.ItemsSource = nevekLista;
        }


        public void SelectItem()
        {
            if (lbNevek.SelectedItem != null)
            {
                string kivalasztottNev = lbNevek.SelectedItem.ToString();
                int index = lbNevek.SelectedIndex;
            }
        }

        public void DeleteItem()
        {
           if (lbNevek.SelectedItem != null)
           {
                string torlendo = lbNevek.SelectedItem.ToString();
                nevekLista.Remove(torlendo);

                lbNevek.ItemsSource = null;
                lbNevek.ItemsSource = nevekLista;
            }
        }
    }
}