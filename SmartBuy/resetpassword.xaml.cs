using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
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
    /// Interaction logic for resetpassword.xaml
    /// </summary>
    public partial class resetpassword : Window
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        public resetpassword()
        {
            con.Open();
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            OracleCommand cmd = new OracleCommand("select * from login natural join selected_customer", con);
            OracleDataReader odr = cmd.ExecuteReader();
            if (odr.Read())
            {
                if ((String.IsNullOrEmpty(old.Password)) || (String.IsNullOrEmpty(new1.Password)) || (String.IsNullOrEmpty(newcon.Password)))
                {
                    MessageBox.Show("Some Fields have been left blank.");
                }
                else
                {

                    if ((odr["password"].ToString() == old.Password) && (new1.Password == newcon.Password))
                    {
                        OracleCommand cmd1 = new OracleCommand("update login set password='"+new1.Password+"' where customer_id ="+odr["customer_id"].ToString(), con);
                        OracleDataReader odr1 = cmd1.ExecuteReader();
                        MessageBox.Show("Password Changed.");
                        profile a = new profile();
                        a.Show();
                        this.Hide();
                    }
                    else
                    {
                        if ((odr["password"].ToString() != old.Password))
                        {
                            MessageBox.Show("Invalid Old Password");
                        }
                        else
                        {
                            MessageBox.Show("New Password and Confirm Passwords do not match.");
                        }
                    }
                }
            }
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            profile a = new profile();
            a.Show();
            this.Hide();
        }
    }
}

