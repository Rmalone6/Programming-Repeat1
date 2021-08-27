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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();

        }

        public void Customerslbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Customerslbx_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-NC0NE7I;Initial Catalog=Login;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Login", connection);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Customerslbx.Items.Add(dr["Username"].ToString());
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow dr = new MainWindow();
            dr.Show();
            this.Close();
        }
    }
}
        
        
            

            
        
    

