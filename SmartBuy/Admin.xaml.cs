using System;
using System.Data.OracleClient;
//using Oracle.DataAccess.Client;
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
using System.Data.SqlClient;
using System.Data;

namespace SmartBuy
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        
        public Admin()
        {
            con.Open();
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            EmpTable et = new EmpTable();
            et.Show();
            this.Hide();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            SalesTable st = new SalesTable();
            st.Show();
            this.Hide();

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            SupTable et = new SupTable();
            et.Show();
            this.Hide();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            PurTable pt = new PurTable();
            pt.Show();
            this.Hide();
        }

        private void add_admin_Click(object sender, RoutedEventArgs e)
        {
            addadmin a = new addadmin();
            a.Show();
            this.Hide();

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            this.Hide();
            a.Show();
        }

        private void add_device_Click(object sender, RoutedEventArgs e)
        {
            addphone a = new addphone();
            a.Show();
            this.Hide();
        }
    }
}
