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
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    namespace SmartBuy
    {
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
        public partial class MainWindow : Window
        {
            OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
            public MainWindow()
            {
                con.Open();
                InitializeComponent();
                this.Closing += (s, e) =>
                {
                    Application.Current.Shutdown();
                };
                mediaElement.Play();
            }

            private void button_Click(object sender, RoutedEventArgs e)
            {

                OracleCommand cmd = new OracleCommand("select * from login where username='"+textBox1.Text+"' and password='"+passwordBox2.Password+"'", con);
                OracleDataReader odr = cmd.ExecuteReader();
                if(odr.Read())
                {
                    String s = odr["user_admin"].ToString();
                    if(s=="User")
                    {
                        this.Hide();
                        String sql1 = "create or replace view selected_customer as select customer_id from login where customer_id="+odr["customer_id"].ToString();
                        OracleCommand cmd1 = new OracleCommand(sql1, con);
                        cmd1.ExecuteNonQuery();
                        Main_Menu a = new Main_Menu();
                        a.Show();
                    }
                    else
                    {
                        Admin a = new Admin();
                        this.Hide();
                        a.Show();
                    }
                mediaElement.Stop();
            }
                else
                {
                    MessageBox.Show("Login Failed. Try Again");
                }

        }

            private void newuser_Click(object sender, RoutedEventArgs e)
            {
                create_user cu = new create_user();
                cu.Show();
                mediaElement.Stop();
                this.Hide();
            }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            dev.Visibility = Visibility.Visible;
            mediaElement.Pause();
            con.Close();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            dev.Visibility = Visibility.Hidden;
            mediaElement.Play();
        }
    }
    }
