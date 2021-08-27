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
using System.Windows.Media.Animation;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ObservableCollection<Item> items = new ObservableCollection<Item>();

        List<int> myValues = new List<int>(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        public double sum { get; set; }
        public double totalp { get; set; }

        

        public int clicks;
        string Name { get; set; }
        
        public double Price { get; private set; }
        public int Quantity { get; set; }
        public int Count { get; private set; }

        public double TotalDiscount { get; set; }

        public Window1()
        {
            InitializeComponent();
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

        

        

        private void lbx_Loaded(object sender, RoutedEventArgs e)
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
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            double apple = 0.5;
            myValues[0] = myValues[0] +1;

            clicks = clicks + 1;
            
            
                     

            sum = sum + apple;
            Total.Text = sum.ToString();
            Total.Text = sum.ToString();

            totalp = sum - TotalDiscount;
            double totalpayable = totalp;


            
               
                if (myValues[0] == 2)
            {

           
                    TotalDiscount = TotalDiscount + 0.5;
                    //Displays dicount number
                    Discount.Text = TotalDiscount.ToString();
                    //displays total payable (sum - discount)



                    totalp = totalp - TotalDiscount;
                }
                
                

                
                    



                
            
            
            TotalPayable.Text = totalp.ToString();


            string value = "Apple";
            bool exists = false;
            for (int i = 0; i < lbx.Items.Count; i++)
            {
                var x = lbx.Items[i].ToString();
                if (x.StartsWith(value))
                {
                    if (x == value)
                    {
                        lbx.Items[i] = value + "x2";
                        exists = true;
                        break;
                    }
                    else
                    {

                        var pattern = Regex.Escape(value);

                        Match m = Regex.Match(x, "^" + pattern + @"x(\d+)$");
                        if (m.Success)
                        {
                            lbx.Items[i] = value + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                            exists = true;
                            break;
                        }
                    }
                }
            }
            if (!exists) lbx.Items.Add(value);


        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double banana = 0.62;

            clicks = clicks + 1;

            myValues[1] = myValues[1] + 1;


            sum = sum + banana;
            Total.Text = sum.ToString();
            Total.Text = sum.ToString();

            totalp = sum - TotalDiscount;
            double totalpayable = totalp;



            
                if (myValues[1] == 10)
                {
                    TotalDiscount = TotalDiscount + 1.24;
                    //Displays dicount number
                    Discount.Text = TotalDiscount.ToString();
                    //displays total payable (sum - discount)



                    totalp = totalp - TotalDiscount;



                }
            
            TotalPayable.Text = totalp.ToString();


            string value = "Banana";
            bool exists = false;
            for (int i = 0; i < lbx.Items.Count; i++)
            {
                var x = lbx.Items[i].ToString();
                if (x.StartsWith(value))
                {
                    if (x == value)
                    {
                        lbx.Items[i] = value + "x2";
                        exists = true;
                        break;
                    }
                    else
                    {

                        var pattern = Regex.Escape(value);

                        Match m = Regex.Match(x, "^" + pattern + @"x(\d+)$");
                        if (m.Success)
                        {
                            lbx.Items[i] = value + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                            exists = true;
                            break;
                        }
                    }
                }
            }
            if (!exists) lbx.Items.Add(value);

        }
        private void pearbtn_Click(object sender, RoutedEventArgs e)
        {
            double pear = 0.45;

            clicks = clicks + 1;
            double discount = 0;
            myValues[2] = myValues[2] + 1;


            sum = sum + pear;
            Total.Text = sum.ToString();
            Total.Text = sum.ToString();

            totalp = sum - TotalDiscount;
            double totalpayable = totalp;



            if (myValues[2] == 10)
            {
                TotalDiscount = TotalDiscount + 0.45;
                //Displays dicount number
                Discount.Text = TotalDiscount.ToString();
                //displays total payable (sum - discount)



                totalp = totalp - TotalDiscount;



            }
            TotalPayable.Text = totalp.ToString();


            string value = "Pear";
            bool exists = false;
            for (int i = 0; i < lbx.Items.Count; i++)
            {
                var x = lbx.Items[i].ToString();
                if (x.StartsWith(value))
                {
                    if (x == value)
                    {
                        lbx.Items[i] = value + "x2";
                        exists = true;
                        break;
                    }
                    else
                    {

                        var pattern = Regex.Escape(value);

                        Match m = Regex.Match(x, "^" + pattern + @"x(\d+)$");
                        if (m.Success)
                        {
                            lbx.Items[i] = value + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                            exists = true;
                            break;
                        }
                    }
                }
            }
            if (!exists) lbx.Items.Add(value);


        }
        private void grapebtn_Click(object sender, RoutedEventArgs e)
        {

            double grape = 0.1;

            clicks = clicks + 1;
            double discount = 0;

            myValues[3] = myValues[3] + 1;

            sum = sum + grape;
            Total.Text = sum.ToString();
            Total.Text = sum.ToString();

            totalp = sum - TotalDiscount;
            double totalpayable = totalp;



            if (myValues[3] == 30)
            {
                TotalDiscount = TotalDiscount +  0.5;
                //Displays dicount number
                Discount.Text = TotalDiscount.ToString();
                //displays total payable (sum - discount)



                totalp = totalp - TotalDiscount;



            }
            totalp = totalp - discount;
            TotalPayable.Text = totalp.ToString();


            string value = "Grape";
            bool exists = false;
            for (int i = 0; i < lbx.Items.Count; i++)
            {
                var x = lbx.Items[i].ToString();
                if (x.StartsWith(value))
                {
                    if (x == value)
                    {
                        lbx.Items[i] = value + "x2";
                        exists = true;
                        break;
                    }
                    else
                    {

                        var pattern = Regex.Escape(value);

                        Match m = Regex.Match(x, "^" + pattern + @"x(\d+)$");
                        if (m.Success)
                        {
                            lbx.Items[i] = value + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                            exists = true;
                            break;
                        }
                    }
                }
            }
            if (!exists) lbx.Items.Add(value);
        }

        private void cauliflowerbtn_Click(object sender, RoutedEventArgs e)
        {
            double cauliflower = 0.7;

            clicks = clicks + 1;
            double discount = 0;

            myValues[4] = myValues[4] + 1;

            sum = sum + cauliflower;
            Total.Text = sum.ToString();
            Total.Text = sum.ToString();

            totalp = sum - TotalDiscount;
            double totalpayable = totalp;



            if (myValues[4] == 8)
            {
                TotalDiscount = TotalDiscount+ 0.2;
                //Displays dicount number
                Discount.Text = TotalDiscount.ToString();
                //displays total payable (sum - discount)



                totalp = totalp - TotalDiscount;



            }
            TotalPayable.Text = totalp.ToString();


            string value = "Cauliflower";
            bool exists = false;
            for (int i = 0; i < lbx.Items.Count; i++)
            {
                var x = lbx.Items[i].ToString();
                if (x.StartsWith(value))
                {
                    if (x == value)
                    {
                        lbx.Items[i] = value + "x2";
                        exists = true;
                        break;
                    }
                    else
                    {

                        var pattern = Regex.Escape(value);

                        Match m = Regex.Match(x, "^" + pattern + @"x(\d+)$");
                        if (m.Success)
                        {
                            lbx.Items[i] = value + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                            exists = true;
                            break;
                        }
                    }
                }
            }
            if (!exists) lbx.Items.Add(value);
        }

        private void carrotbtn_Click(object sender, RoutedEventArgs e)
        {
            double carrot = 0.7;

            clicks = clicks + 1;
            double discount = 0;

            myValues[5] = myValues[5] + 1;

            sum = sum + carrot;
            Total.Text = sum.ToString();
            Total.Text = sum.ToString();

            totalp = sum - TotalDiscount;
            double totalpayable = totalp;



            if (myValues[5] > 15)
            {
                TotalDiscount = TotalDiscount+ 0.2;
                //Displays dicount number
                Discount.Text = TotalDiscount.ToString();
                //displays total payable (sum - discount)



                totalp = totalp - TotalDiscount;



            }
            TotalPayable.Text = totalp.ToString();


            string value = "Carrot";
            bool exists = false;
            for (int i = 0; i < lbx.Items.Count; i++)
            {
                var x = lbx.Items[i].ToString();
                if (x.StartsWith(value))
                {
                    if (x == value)
                    {
                        lbx.Items[i] = value + "x2";
                        exists = true;
                        break;
                    }
                    else
                    {
                        
                        var pattern = Regex.Escape(value);
                       
                        Match m = Regex.Match(x, "^" + pattern + @"x(\d+)$");
                        if (m.Success)
                        {
                            lbx.Items[i] = value + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                            exists = true;
                            break;
                        }
                    }
                }
            }
            if (!exists) lbx.Items.Add(value);
        }

        private void chickenbtn_Click(object sender, RoutedEventArgs e)
        {
            double chicken = 0.7;

            clicks = clicks + 1;
            double discount = 0;
            myValues[6] = myValues[6] + 1;

            sum = sum + chicken;
            Total.Text = sum.ToString();
            Total.Text = sum.ToString();

            totalp = sum - TotalDiscount;
            double totalpayable = totalp;



            if (myValues[6] == 5)
            {
                TotalDiscount = TotalDiscount + 0.7;
                //Displays dicount number
                Discount.Text = TotalDiscount.ToString();
                //displays total payable (sum - discount)



                totalp = totalp - TotalDiscount;



            }
            TotalPayable.Text = totalp.ToString();


            string value = "Chicken";
            bool exists = false;
            for (int i = 0; i < lbx.Items.Count; i++)
            {
                var x = lbx.Items[i].ToString();
                if (x.StartsWith(value))
                {
                    if (x == value)
                    {
                        lbx.Items[i] = value + "x2";
                        exists = true;
                        break;
                    }
                    else
                    {

                        var pattern = Regex.Escape(value);

                        Match m = Regex.Match(x, "^" + pattern + @"x(\d+)$");
                        if (m.Success)
                        {
                            lbx.Items[i] = value + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                            exists = true;
                            break;
                        }
                    }
                }
            }
            if (!exists) lbx.Items.Add(value);
        }

        private void steak_Click(object sender, RoutedEventArgs e)
        {
            double steak = 0.7;

            clicks = clicks + 1;
            double discount = 0;

            myValues[7] = myValues[7] + 1;

            sum = sum + steak;
            Total.Text = sum.ToString();
            Total.Text = sum.ToString();

            totalp = sum - TotalDiscount;
            double totalpayable = totalp;



            if (myValues[7] == 3)
            {
                TotalDiscount = TotalDiscount + 0.2;
                //Displays dicount number
                Discount.Text = TotalDiscount.ToString();
                //displays total payable (sum - discount)



                totalp = totalp - TotalDiscount;



            }
            TotalPayable.Text = totalp.ToString();


            string value = "Steak";
            bool exists = false;
            for (int i = 0; i < lbx.Items.Count; i++)
            {
                var x = lbx.Items[i].ToString();
                if (x.StartsWith(value))
                {
                    if (x == value)
                    {
                        lbx.Items[i] = value + "x2";
                        exists = true;
                        break;
                    }
                    else
                    {

                        var pattern = Regex.Escape(value);

                        Match m = Regex.Match(x, "^" + pattern + @"x(\d+)$");
                        if (m.Success)
                        {
                            lbx.Items[i] = value + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                            exists = true;
                            break;
                        }
                    }
                }
            }
            if (!exists) lbx.Items.Add(value);
        }

        private void eggbtn_Click(object sender, RoutedEventArgs e)
        {
            double egg = 0.7;

            clicks = clicks + 1;
            double discount = 0;

            myValues[8] = myValues[8] + 1;

            sum = sum + egg;
            Total.Text = sum.ToString();
            Total.Text = sum.ToString();

            totalp = sum - TotalDiscount;
            double totalpayable = totalp;



            if (myValues[8] == 3)
            {
                TotalDiscount = TotalDiscount+ 0.2;
                //Displays dicount number
                Discount.Text = TotalDiscount.ToString();
                //displays total payable (sum - discount)



                totalp = totalp - TotalDiscount;



            }
            TotalPayable.Text = totalp.ToString();


            string value = "Egg";
            bool exists = false;
            for (int i = 0; i < lbx.Items.Count; i++)
            {
                var x = lbx.Items[i].ToString();
                if (x.StartsWith(value))
                {
                    if (x == value)
                    {
                        lbx.Items[i] = value + "x2";
                        exists = true;
                        break;
                    }
                    else
                    {

                        var pattern = Regex.Escape(value);

                        Match m = Regex.Match(x, "^" + pattern + @"x(\d+)$");
                        if (m.Success)
                        {
                            lbx.Items[i] = value + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                            exists = true;
                            break;
                        }
                    }
                }
            }
            if (!exists) lbx.Items.Add(value);
        }

        private void bunbtn_Click(object sender, RoutedEventArgs e)
        {
            double bun = 0.7;

            clicks = clicks + 1;
            double discount = 0;

            myValues[9] = myValues[9] + 1;

            sum = sum + bun;
            Total.Text = sum.ToString();
            Total.Text = sum.ToString();

            totalp = sum - TotalDiscount;
            double totalpayable = totalp;



            if (myValues[9] == 3)
            {
                TotalDiscount = TotalDiscount +0.2;
                //Displays dicount number
                Discount.Text = TotalDiscount.ToString();
                //displays total payable (sum - discount)



                totalp = totalp - TotalDiscount;



            }
            TotalPayable.Text = totalp.ToString();


            string value = "Bun";
            bool exists = false;
            for (int i = 0; i < lbx.Items.Count; i++)
            {
                var x = lbx.Items[i].ToString();
                if (x.StartsWith(value))
                {
                    if (x == value)
                    {
                        lbx.Items[i] = value + "x2";
                        exists = true;
                        break;
                    }
                    else
                    {

                        var pattern = Regex.Escape(value);

                        Match m = Regex.Match(x, "^" + pattern + @"x(\d+)$");
                        if (m.Success)
                        {
                            lbx.Items[i] = value + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                            exists = true;
                            break;
                        }
                    }
                }
            }
            if (!exists) lbx.Items.Add(value);
        }

        private void cokebtn_Click(object sender, RoutedEventArgs e)
        {
            double coke = 0.7;

            clicks = clicks + 1;
            double discount = 0;

            myValues[10] = myValues[10] + 1;

            sum = sum + coke;
            Total.Text = sum.ToString();
            Total.Text = sum.ToString();

            totalp = sum - TotalDiscount;
            double totalpayable = totalp;



            if (myValues[10] == 1)
            {
                TotalDiscount = TotalDiscount +0.7;
                //Displays dicount number
                Discount.Text = TotalDiscount.ToString();
                //displays total payable (sum - discount)



                totalp = totalp - TotalDiscount;



            }
            TotalPayable.Text = totalp.ToString();


            string value = "Coke";
            bool exists = false;
            for (int i = 0; i < lbx.Items.Count; i++)
            {
                var x = lbx.Items[i].ToString();
                if (x.StartsWith(value))
                {
                    if (x == value)
                    {
                        lbx.Items[i] = value + "x2";
                        exists = true;
                        break;
                    }
                    else
                    {

                        var pattern = Regex.Escape(value);

                        Match m = Regex.Match(x, "^" + pattern + @"x(\d+)$");
                        if (m.Success)
                        {
                            lbx.Items[i] = value + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                            exists = true;
                            break;
                        }
                    }
                }
            }
            if (!exists) lbx.Items.Add(value);
        }
        private void orangebtn_Copy7_Click(object sender, RoutedEventArgs e)
        {
            double pasta = 0.7;

            clicks = clicks + 1;
            double discount = 0;

            myValues[11] = myValues[11] + 1;

            sum = sum + pasta;
            Total.Text = sum.ToString();
            Total.Text = sum.ToString();

            totalp = sum - TotalDiscount;
            double totalpayable = totalp;



            if (myValues[11] == 3)
            {
                TotalDiscount = TotalDiscount +0.2;
                //Displays dicount number
                Discount.Text = TotalDiscount.ToString();
                //displays total payable (sum - discount)



                totalp = totalp - TotalDiscount;



            }
            TotalPayable.Text = totalp.ToString();


            string value = "Pasta";
            bool exists = false;
            for (int i = 0; i < lbx.Items.Count; i++)
            {
                var x = lbx.Items[i].ToString();
                if (x.StartsWith(value))
                {
                    if (x == value)
                    {
                        lbx.Items[i] = value + "x2";
                        exists = true;
                        break;
                    }
                    else
                    {
                        
                        var pattern = Regex.Escape(value);
                       
                        Match m = Regex.Match(x, "^" + pattern + @"x(\d+)$");
                        if (m.Success)
                        {
                            lbx.Items[i] = value + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                            exists = true;
                            break;
                        }
                    }
                }
            }
            if (!exists) lbx.Items.Add(value);



        }
        private int increaseCount()
        {
            Count++;
            return Count;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           //Soft Drink Filter

            itemlist.Items.Clear();
            itemlist.Items.Add(cokebtn);
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            itemlist.Items.Clear();
            itemlist.Items.Add(applebtn);
            itemlist.Items.Add(bananabtn);
            itemlist.Items.Add(pearbtn);
            itemlist.Items.Add(grapebtn);
            itemlist.Items.Add(cauliflowerbtn);
            itemlist.Items.Add(carrotbtn);
            itemlist.Items.Add(chickenbtn);
            itemlist.Items.Add(steak);
            itemlist.Items.Add(eggbtn);
            itemlist.Items.Add(bunbtn);
            itemlist.Items.Add(cokebtn);
            itemlist.Items.Add(pastabtn);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void FoodFilter_Click(object sender, RoutedEventArgs e)
        {
            itemlist.Items.Clear();
            itemlist.Items.Clear();
            itemlist.Items.Add(applebtn);
            itemlist.Items.Add(bananabtn);
            itemlist.Items.Add(pearbtn);
            itemlist.Items.Add(grapebtn);
            itemlist.Items.Add(cauliflowerbtn);
            itemlist.Items.Add(carrotbtn);
            itemlist.Items.Add(chickenbtn);
            itemlist.Items.Add(steak);
            itemlist.Items.Add(eggbtn);
            itemlist.Items.Add(bunbtn);
            itemlist.Items.Add(pastabtn);

        }

        private void FruitFilter_Click(object sender, RoutedEventArgs e)
        {
            itemlist.Items.Clear();
            itemlist.Items.Add(applebtn);
            itemlist.Items.Add(bananabtn);
            itemlist.Items.Add(pearbtn);
            itemlist.Items.Add(grapebtn);
         

        }

        private void MeatFilter_Click(object sender, RoutedEventArgs e)
        {
            itemlist.Items.Clear();
            itemlist.Items.Add(chickenbtn);
            itemlist.Items.Add(steak);

        }

        
    }
}
