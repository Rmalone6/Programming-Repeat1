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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ObservableCollection<Item> items = new ObservableCollection<Item>();
        string Name { get; set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow newWindow2 = new MainWindow();
            newWindow2.Show();
            this.Close();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string name = "Apple";
            double price = 2;
            int quantity = 1;

            //create item object 

            Item item = new Item(name, price, quantity);

            //add to observable collection
            items.Add(item);




        }

        private void lbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //check what has been selected
            Item selectedItem = lbx.SelectedItem as Item;

            //ensure it is not null
            if (selectedItem != null)
            {
                //take action - update the display
                Name = selectedItem.Name;
                Price = selectedItem.Price;
                Quantity = selectedItem.Quantity;
            }

        }

        private void lbx_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            lbx.Items.Add(txtb.Text);
            
        }
    }
}
