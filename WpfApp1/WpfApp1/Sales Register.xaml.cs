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
using System.Runtime.InteropServices;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ObservableCollection<Item> items = new ObservableCollection<Item>();
        public double sum { get; set; }
        public double totalp { get; set; }

        public int clicks;
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
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            clicks = clicks + 1;
            double discount = 0;

            double apple = 1.0;
            lbx.Items.Add("Apple        " + apple);
            sum = sum + apple;
            
            Total.Text = sum.ToString();

            totalp = sum - discount;
            double totalpayable = totalp;

            

            if (clicks > 5)
            {
                discount = 0.3;
                //Displays dicount number
                Discount.Text = discount.ToString();
                //displays total payable (sum - discount)



                totalp = totalp - discount;



            }
            TotalPayable.Text = totalp.ToString();


        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double banana = 1.10;
            lbx.Items.Add("Banana       " + banana);
            sum = sum + banana;
            Total.Text = sum.ToString();
            Total.Text = sum.ToString();

        }
        private void pearbtn_Click(object sender, RoutedEventArgs e)
        {
            double pear = 0.55;
            lbx.Items.Add("Pear         " + pear);
            sum = sum + pear;
            Total.Text = sum.ToString();


        }
        private void grapebtn_Click(object sender, RoutedEventArgs e)
        {
            double grape = 0.20;
            lbx.Items.Add("Grape        " + grape);
            sum = sum + grape;
            Total.Text = sum.ToString();
        }

        private void cauliflowerbtn_Click(object sender, RoutedEventArgs e)
        {
            double cauliflower = 1.0;
            lbx.Items.Add("Cauliflower  " + cauliflower);
            sum = sum + cauliflower;
            Total.Text = sum.ToString();
        }

        private void carrotbtn_Click(object sender, RoutedEventArgs e)
        {
            double carrot = 0.50;
            lbx.Items.Add("Carrot       " + carrot);
            sum = sum + carrot;
            Total.Text = sum.ToString();
        }

        private void chickenbtn_Click(object sender, RoutedEventArgs e)
        {
            double chicken = 2.0;
            lbx.Items.Add("Chicken      " + chicken);
            sum = sum + chicken;
            Total.Text = sum.ToString();
        }

        private void steak_Click(object sender, RoutedEventArgs e)
        {
            double steak = 3.0;
            lbx.Items.Add("Steak       " + steak);
            sum = sum + steak;
            Total.Text = sum.ToString();
        }

        private void eggbtn_Click(object sender, RoutedEventArgs e)
        {
            double egg = 1.0;
            lbx.Items.Add("Egg         " + egg);
            sum = sum + egg;
            Total.Text = sum.ToString();
        }

        private void bunbtn_Click(object sender, RoutedEventArgs e)
        {
            double bun = 1.70;
            lbx.Items.Add("Bun         " + bun);
            sum = sum + bun;
            Total.Text = sum.ToString();
        }

        private void cokebtn_Click(object sender, RoutedEventArgs e)
        {
            double coke = 2.50;
            lbx.Items.Add("Coke        " + coke);
            sum = sum + coke;
            Total.Text = sum.ToString();
        }
        private void orangebtn_Copy7_Click(object sender, RoutedEventArgs e)
        {
            double pasta = 2.50;
            lbx.Items.Add("Pasta       " + pasta);
            sum = sum + pasta;
            Total.Text = sum.ToString();
        }

        private void Total_GotFocus(object sender, RoutedEventArgs e)
        {

        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
           
        }

        

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        

        
    }
}
