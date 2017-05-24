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
    /// Interaction logic for Main_Menu.xaml
    /// </summary>
    public partial class Main_Menu : Window
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        public Main_Menu()
        {
            con.Open();
            InitializeComponent();
            String cid = "";
            String sql1 = "select * from selected_customer natural join customer";
            OracleCommand com1 = new OracleCommand(sql1, con);
            OracleDataReader dr = com1.ExecuteReader();
            if (dr.Read())
            {
                cid = dr["customer_name"].ToString();
            }
            name.Content = cid;
            mediaElement.Play();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Mbtb a = new Mbtb();
            a.Show();
            this.Hide();
            mediaElement.Stop();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            profile a = new profile();
            this.Hide();
            a.Show();
            mediaElement.Stop();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ob = new MainWindow();
            this.Hide();
            ob.Show();
            mediaElement.Stop();
        }
    }
}
