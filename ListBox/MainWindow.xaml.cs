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

        List<string> termekek = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            ReloadListBox();
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
                termekek.Remove(torlendo);

                ReloadListBox();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox.Text.ToString()))
            {
                AddToListHelper();
            }
            else if (string.IsNullOrWhiteSpace(txtBox.Text.ToString()))
            {
                MessageBox.Show("Empty TextBox");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lbNevek.SelectedItem != null)
            {
                termekek.Remove(lbNevek.SelectedItem.ToString());
                ReloadListBox();
            }
            else if (lbNevek.SelectedItem == null)
            {
                MessageBox.Show("No item selected");
            }
        }
        private void txtBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && !string.IsNullOrWhiteSpace(txtBox.Text.ToString()))
            {
                AddToListHelper();
            }
            else if (e.Key == Key.Enter && string.IsNullOrWhiteSpace(txtBox.Text.ToString()))
            {
                MessageBox.Show("Empty TextBox");
            }
        }
        private void ReloadListBox()
        {
            lbNevek.ItemsSource = null;
            lbNevek.ItemsSource = termekek;
        }

        private void AddToListHelper()
        {
            termekek.Add(txtBox.Text.ToString());
            ReloadListBox();
            txtBox.Text = "";
        }
    }
}