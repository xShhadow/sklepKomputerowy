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
using System.Windows.Shapes;

namespace SklepKomputerowy
{
    /// <summary>
    /// Logika interakcji dla klasy AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        public Product Product { get; set; }
        public AddProductWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(IdTextBox.Text, out int id) && !string.IsNullOrEmpty(NameTextBox.Text) && decimal.TryParse(PriceTextBox.Text, out decimal price))
            {
                Product = new Product { Id = id, Name = NameTextBox.Text, Price = price };
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane.");
            }
        }
    }
}
