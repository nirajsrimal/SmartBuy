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
using System.Data.OracleClient;

namespace SmartBuy
{
    /// <summary>
    /// Interaction logic for profile.xaml
    /// </summary>
    public partial class profile : Window
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        public profile()
        {
            con.Open();
            InitializeComponent();
            mediaElement.Play();
            OracleCommand cmd = new OracleCommand("select * from selected_customer natural join customer", con);
            OracleCommand cmd1 = new OracleCommand("select * from selected_customer natural join login", con);
            OracleDataReader odr = cmd.ExecuteReader();
            if (odr.Read())
            {
                id.Content = odr["customer_id"].ToString();
                name.Content = odr["customer_name"].ToString();
                address.Content = odr["customer_address"].ToString();
                Phone.Content = odr["customer_cellno"].ToString();
                Email.Content = odr["customer_email"].ToString();
            }
            OracleDataReader odr1 = cmd1.ExecuteReader();
            if (odr1.Read())
            {
                username.Content = odr1["username"].ToString();
            }
        }
   
        private void button_Click(object sender, RoutedEventArgs e)
        {
            purchist a = new purchist();
            a.Show();
            this.Hide();
            mediaElement.Stop();
        }

        private void button_Click1(object sender, RoutedEventArgs e)
        {
            resetpassword a = new resetpassword();
            this.Hide();
            a.Show();
            mediaElement.Stop();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Main_Menu a = new Main_Menu();
            a.Show();
            this.Hide();
            mediaElement.Stop();
        }
    }
}
