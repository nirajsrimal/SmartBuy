using System;
using System.Collections.Generic;
using System.Data.OracleClient;
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

namespace SmartBuy
{
    /// <summary>
    /// Interaction logic for Mbtb.xaml
    /// </summary>
    public partial class Mbtb : Window
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        public Mbtb()
        {
            con.Open();
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String sql2 = "create or replace view mbtb as select * from device where device_type='Phone'";
            OracleCommand cmd2 = new OracleCommand(sql2, con);
            cmd2.ExecuteNonQuery();
            FilterBrand a = new FilterBrand();
            this.Hide();
            a.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String sql1 = "create or replace view mbtb as select * from device where device_type='Tablet'";
            OracleCommand cmd1 = new OracleCommand(sql1, con);
            cmd1.ExecuteNonQuery();
            FilterBrand a = new FilterBrand();
            this.Hide();
            a.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            String sql = "create or replace view mbtb as select * from device";
            OracleCommand cmd = new OracleCommand(sql, con);
            cmd.ExecuteNonQuery();
            FilterBrand a = new FilterBrand();
            this.Hide();
            a.Show();
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            Main_Menu a = new Main_Menu();
            a.Show();
            this.Hide();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            String sql="";
            if (String.IsNullOrEmpty(search.Text))
            {
               sql = "create or replace view filter as select * from device";
            }
            else
            {
                sql = "create or replace view filter as select * from device where device_model like '%" + search.Text.ToString() + "%'";
            }
            OracleCommand cmdz = new OracleCommand(sql, con);
            cmdz.ExecuteNonQuery();
            mbdisp ob = new mbdisp();
            ob.Show();
            this.Hide();
        }
    }
}
