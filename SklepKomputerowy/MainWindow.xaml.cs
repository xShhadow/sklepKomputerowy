using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace SklepKomputerowy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public ObservableCollection<Product> Products { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Products = new ObservableCollection<Product>();
            ProductListView.ItemsSource = Products;

            Products.Add(new Product { Id = 1, Name = "Procesor", Price = 899.00m });
            Products.Add(new Product { Id = 2, Name = "Karta Graficzna", Price = 2499.00m });
            Products.Add(new Product { Id = 3, Name = "Klawiatura", Price = 399.00m });
            Products.Add(new Product { Id = 4, Name = "Monitor", Price = 1299.00m });
            
            ProductListView.ItemsSource = Products;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow addProductWindow = new AddProductWindow();
            if (addProductWindow.ShowDialog() == true)
            {
                Products.Add(addProductWindow.Product);
            }
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            BuyProductWindow buyProductWindow = new BuyProductWindow(Products);
            buyProductWindow.ShowDialog();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (ProductListView.SelectedItem != null)
            {
              
                Product selectedProduct = (Product)ProductListView.SelectedItem;

                
                EditProductWindow editWindow = new EditProductWindow(selectedProduct.Id, selectedProduct.Name, selectedProduct.Price, Products);

              
                editWindow.ProductUpdated += (s, args) =>
                {
                  
                    foreach (var product in Products)
                    {
                        if (product.Id == args.Id)
                        {
                            product.Name = args.Name;
                            product.Price = (decimal)args.Price;
                            break;
                        }
                    }
                };

            
                _ = editWindow.ShowDialog();
            }
            else
            {
                
                MessageBox.Show("Proszę wybrać produkt do edycji.", "Brak wyboru", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}