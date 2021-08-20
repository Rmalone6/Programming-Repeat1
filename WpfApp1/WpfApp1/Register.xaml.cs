using System;
using System.Collections.Generic;
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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            Window2 newWindow1 = new Window2();
            newWindow1.Show();
            this.Close();
        }

        private void Registerbtn_Click(object sender, RoutedEventArgs e)
        {
            

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NC0NE7I;Initial Catalog=Login;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            
            
            SqlCommand cmd = new SqlCommand("Insert into Login(Username,Password) values ('" + usernameReg.Text + "','" + usernameReg.Text + "')",connection);

            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@Username", usernameReg.Text);
            cmd.Parameters.AddWithValue("@Password", PasswordReg.Text);

            connection.Open();
            cmd.ExecuteNonQuery();

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Error");
            }



            connection.Close();

}
    }
}
