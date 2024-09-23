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
    /// Logika interakcji dla klasy EditProductWindow.xaml
    /// </summary>
    public partial class EditProductWindow : Window
    {

        public event EventHandler<ProductEventArgs> ProductUpdated;
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        private ObservableCollection<Product> _products;
        private int id;
        private decimal price;
        private ObservableCollection<Product> products;

        public EditProductWindow(int id, string name, decimal price, ObservableCollection<Product> products)
        {
            InitializeComponent();

            _products = products;

            ProductId = id;
            ProductName = name;
            ProductPrice = price;

            IdTextBox.Text = id.ToString();
            NameTextBox.Text = name;
            PriceTextBox.Text = price.ToString();
        }


        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            ProductId = int.Parse(IdTextBox.Text);
            ProductName = NameTextBox.Text;
            ProductPrice = decimal.Parse(PriceTextBox.Text);

            if (string.IsNullOrWhiteSpace(ProductName))
            {
                MessageBox.Show("Nazwa produktu nie może być pusta.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return; 
            }

            foreach (var product in _products)
            {
                if (product.Id == ProductId)
                {
                    product.Name = ProductName;
                    product.Price = ProductPrice;
                    break;
                }
            }

            ProductUpdated?.Invoke(this, new ProductEventArgs(ProductId, ProductName, ProductPrice));

            this.Close();
        }


    }
}
