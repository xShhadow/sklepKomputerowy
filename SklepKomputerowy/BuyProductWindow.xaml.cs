using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logika interakcji dla klasy BuyProductWindow.xaml
    /// </summary>
    public partial class BuyProductWindow : Window
    {
        private ObservableCollection<Product> _products;
        public BuyProductWindow(ObservableCollection<Product> products)
        {
            InitializeComponent();
            _products = products;
            foreach (var product in products)
            {
                ProductComboBox.Items.Add(product.Name);
            }
        }
        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProductComboBox.SelectedItem != null)
            {
                string selectedProductName = ProductComboBox.SelectedItem.ToString();
                Product selectedProduct = _products.FirstOrDefault(p => p.Name == selectedProductName);

                if (selectedProduct != null)
                {
                    _products.Remove(selectedProduct);
                    DialogResult = true;
                }
                else
                {
                    MessageBox.Show("Nie można znaleźć wybranego produktu.");
                }
            }
            else
            {
                MessageBox.Show("Wybierz produkt do kupienia.");
            }
        }
        
    }
}
