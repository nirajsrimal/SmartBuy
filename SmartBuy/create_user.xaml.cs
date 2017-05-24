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
    /// Interaction logic for create_user.xaml
    /// </summary>
    public partial class create_user : Window
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        public create_user()
        {
            con.Open();
            InitializeComponent();

            mediaElement.Play();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int iid=0;
            if ((String.IsNullOrEmpty(name.Text)) || (String.IsNullOrEmpty(address.Text)) || (String.IsNullOrEmpty(mobile.Text)))
                MessageBox.Show("Some Fields have been left blank");
            else if ((String.IsNullOrEmpty(username.Text)) || (String.IsNullOrEmpty(email.Text)) || (String.IsNullOrEmpty(username.Text)))
                MessageBox.Show("Some Fields have been left blank");
            else if ((String.IsNullOrEmpty(password.Password)) || (String.IsNullOrEmpty(password1.Password)))
                MessageBox.Show("Some Fields have been left blank");
            else if (mobile.Text.ToString().Length!=10)
            {
                MessageBox.Show("Invalid Mobile Number. Mobile number should be of 10 digits");
            }
            else
            {
                if (password.Password == password1.Password)
                {
                    try
                    {
                        OracleCommand cmdc = new OracleCommand("select * from customer order by customer_id", con);
                        OracleDataReader odr = cmdc.ExecuteReader();
                        while (odr.Read())
                        {
                            iid = Int32.Parse((odr["customer_id"].ToString()));
                        }
                        iid = iid + 1;
                        OracleCommand cmd = new OracleCommand("insert into login values('" + username.Text + "','" + password.Password + "','User'," + iid.ToString() + ")", con);
                        OracleCommand cmd1 = new OracleCommand("insert into customer values(" + iid.ToString() + ",'" + name.Text + "','" + address.Text + "'," + mobile.Text + ",'" + email.Text + "')", con);
                        OracleDataReader odr1 = cmd.ExecuteReader();
                        OracleDataReader odr2 = cmd1.ExecuteReader();
                        MessageBox.Show("User Created");
                        MainWindow a = new MainWindow();
                        a.Show();
                        this.Hide();
                        mediaElement.Stop();
                    }
                    catch
                    {
                        MessageBox.Show("Username already exists. Choose a new username");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords Do Not Match");
                }
            }
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Hide();
            mediaElement.Stop();
        }
    }
}
