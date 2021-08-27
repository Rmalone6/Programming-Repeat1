using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newWindow1 = new MainWindow();
            newWindow1.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Registerbtn_Click(object sender, RoutedEventArgs e)
        {
            Window4 Register = new Window4();
            Register.Show();
            this.Close();
        }

        private void login_test_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-NC0NE7I;Initial Catalog=Login;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                connection.Open();
                SqlCommand checker = new SqlCommand("SELECT COUNT (*) from Login WHERE Username=@UserName AND Password = @Password", connection);
                checker.Parameters.Add(new SqlParameter("@userName", Usernamelog.Text));
                checker.Parameters.Add(new SqlParameter("@password", Passwordlog.Text));
                var count = Convert.ToInt32(checker.ExecuteScalar());
                connection.Close();
                if (count > 0)
                {
                    
                    MainWindow wen = new MainWindow();
                    wen.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect password or username.");
                }
            }
            catch
            {
                MessageBox.Show("Incorrect password or username.");
            }
        }

       

        private void Timetbx_Loaded(object sender, RoutedEventArgs e)
        {
            Timetbx.Text = DateTime.Now.ToString();

        }

      
    }
           
            
        }
    

