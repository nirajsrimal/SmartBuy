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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class PurTable : Window
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        public PurTable()
        {
            con.Open();
            InitializeComponent();
            getData();
        }

        public void getData()
        {
            String sql = "select * FROM purchase";
            OracleCommand com = new OracleCommand(sql, con);


            using (OracleDataAdapter adapter = new OracleDataAdapter(com))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGrid.ItemsSource = dt.DefaultView;
            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int iid = 0;
            OracleCommand cmdc = new OracleCommand("select * from purchase order by purchase_id", con);
            OracleDataReader odr = cmdc.ExecuteReader();
            while (odr.Read())
            {
                iid = Int32.Parse((odr["purchase_id"].ToString()));

            }
            iid = iid + 1;
            if ((String.IsNullOrEmpty(date1.Text)) || (String.IsNullOrEmpty(sid.Text)) || (String.IsNullOrEmpty(did.Text)) || (String.IsNullOrEmpty(rate.Text)) || (String.IsNullOrEmpty(quantity.Text)))
            {
                MessageBox.Show("Some field(s) may have been left blank.");
            }
            else
            {
                double r = Double.Parse(rate.Text.ToString());
                int q = Int32.Parse(quantity.Text.ToString());
                double total = q * r;
                OracleCommand cmd = new OracleCommand("insert into purchase values(" + iid + ",'" + date1.Text.ToString() + "'," + sid.Text.ToString() + "," + did.Text.ToString() + "," + rate.Text.ToString() + "," + quantity.Text.ToString() + "," + total.ToString() + ")", con);
                OracleDataReader odr1 = cmd.ExecuteReader();
                MessageBox.Show("Purchase Details Added Successfully.");
                PurTable a = new PurTable();
                this.Visibility = Visibility.Hidden;
                a.Show();
            }
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            Admin a = new Admin();
            this.Visibility = Visibility.Hidden;
            a.Show();
        }
    }
}