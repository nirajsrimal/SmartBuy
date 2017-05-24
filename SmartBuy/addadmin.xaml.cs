using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for addadmin.xaml
    /// </summary>
    public partial class addadmin : Window
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        public addadmin()
        {
            con.Open();
            InitializeComponent();
            String sql1 = "select username from login where user_admin='Admin'";
            OracleCommand com1 = new OracleCommand(sql1, con);
            OracleDataReader dr = com1.ExecuteReader();
            while(dr.Read())
            {
                Label l = new Label();
                l.Content = new TextBlock() { Text = dr["username"].ToString(), TextWrapping = TextWrapping.Wrap };
                l.FontWeight = FontWeights.Bold;
                l.FontSize = 30;
                l.HorizontalAlignment = HorizontalAlignment.Center;
                sp.Children.Add(l);
            }
                /*
                OracleCommand com = new OracleCommand(sql1, con);
                using (OracleDataAdapter adapter = new OracleDataAdapter(com))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    admint.ItemsSource = dt.DefaultView;
                }
                */
            }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(password.Password)) || (String.IsNullOrEmpty(password1.Password)) || String.IsNullOrEmpty(name.Text))
            {
                MessageBox.Show("Some field(s) may have been left blank.");
            }
            else
            {
                if (password.Password == password1.Password)
                {
                    OracleCommand cmd = new OracleCommand("insert into login values('" + name.Text + "','" + password.Password + "','Admin'," + "null)", con);
                    OracleDataReader odr1 = cmd.ExecuteReader();
                    MessageBox.Show("New Administrator Created.");
                    addadmin a = new addadmin();
                    this.Hide(); 
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Passwords do not match.");
                }
            }
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.Show();
        }
    }
}
