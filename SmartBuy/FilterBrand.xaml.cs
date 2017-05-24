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
    /// Interaction logic for FilterBrand.xaml
    /// </summary>
    public partial class FilterBrand : Window
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        public FilterBrand()
        {
            con.Open();
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String sql1 = "create or replace view filterbrand as select * from mbtb";
            OracleCommand cmd1 = new OracleCommand(sql1, con);
            cmd1.ExecuteNonQuery();
            Filter a = new Filter();
            this.Hide();
            a.Show();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            String sql2 = "create or replace view filterbrand as select * from mbtb where device_brand='LG'";
            OracleCommand cmd2 = new OracleCommand(sql2, con);
            cmd2.ExecuteNonQuery();
            Filter a = new Filter();
            this.Hide();
            a.Show();
        }

        private void button_Copy6_Click(object sender, RoutedEventArgs e)
        {
            String sql3 = "create or replace view filterbrand as select * from mbtb where device_brand='Asus'";
            OracleCommand cmd3 = new OracleCommand(sql3, con);
            cmd3.ExecuteNonQuery();
            Filter a = new Filter();
            this.Hide();
            a.Show();
        }

        private void button_Copy5_Click(object sender, RoutedEventArgs e)
        {
            String sql4 = "create or replace view filterbrand as select * from mbtb where device_brand='Xiaomi'";
            OracleCommand cmd4 = new OracleCommand(sql4, con);
            cmd4.ExecuteNonQuery();
            Filter a = new Filter();
            this.Hide();
            a.Show();
        }

        private void button_Copy4_Click(object sender, RoutedEventArgs e)
        {
            String sql5 = "create or replace view filterbrand as select * from mbtb where device_brand='OnePlus'";
            OracleCommand cmd5 = new OracleCommand(sql5, con);
            cmd5.ExecuteNonQuery();
            Filter a = new Filter();
            this.Hide();
            a.Show();
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            String sql6 = "create or replace view filterbrand as select * from mbtb where device_brand='Micromax'";
            OracleCommand cmd6 = new OracleCommand(sql6, con);
            cmd6.ExecuteNonQuery();
            Filter a = new Filter();
            this.Hide();
            a.Show();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            String sql6 = "create or replace view filterbrand as select * from mbtb where device_brand='Motorola'";
            OracleCommand cmd6 = new OracleCommand(sql6, con);
            cmd6.ExecuteNonQuery();
            Filter a = new Filter();
            this.Hide();
            a.Show();
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            String sql8 = "create or replace view filterbrand as select * from mbtb where device_brand='Microsoft'";
            OracleCommand cmd8 = new OracleCommand(sql8, con);
            cmd8.ExecuteNonQuery();
            Filter a = new Filter();
            this.Hide();
            a.Show();
        }

        private void button_Copy9_Click(object sender, RoutedEventArgs e)
        {
            String sql9 = "create or replace view filterbrand as select * from mbtb where device_brand='Sony'";
            OracleCommand cmd9 = new OracleCommand(sql9, con);
            cmd9.ExecuteNonQuery();
            Filter a = new Filter();
            this.Hide();
            a.Show();
        }

        private void button_Copy7_Click(object sender, RoutedEventArgs e)
        {
            String sql10 = "create or replace view filterbrand as select * from mbtb where device_brand='Apple'";
            OracleCommand cmd10 = new OracleCommand(sql10, con);
            cmd10.ExecuteNonQuery();
            Filter a = new Filter();
            this.Hide();
            a.Show();
        }

        private void button_Copy8_Click(object sender, RoutedEventArgs e)
        {
            String sql11 = "create or replace view filterbrand as select * from mbtb where device_brand='Samsung'";
            OracleCommand cmd11 = new OracleCommand(sql11, con);
            cmd11.ExecuteNonQuery();
            Filter a = new Filter();
            this.Hide();
            a.Show();
        }

        private void button_Copy10_Click(object sender, RoutedEventArgs e)
        {
            String sql12 = "create or replace view filterbrand as select * from mbtb where device_brand='HTC'";
            OracleCommand cmd12 = new OracleCommand(sql12, con);
            cmd12.ExecuteNonQuery();
            Filter a = new Filter();
            this.Hide();
            a.Show();
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            Main_Menu a = new Main_Menu();
            a.Show();
            this.Hide();
        }
    }
}
