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
    /// Interaction logic for SupTable.xaml
    /// </summary>
    public partial class SupTable : Window
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        public SupTable()
        {
            con.Open();
            InitializeComponent();
            getData();
        }

        public void getData()
        {
            string sql = "select * FROM supplier";
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
            if ((String.IsNullOrEmpty(name.Text)) || (String.IsNullOrEmpty(address.Text)) || (String.IsNullOrEmpty(mobile.Text)) || (String.IsNullOrEmpty(email.Text)))
                MessageBox.Show("Some Fields have been left blank");
            else if((mobile.Text).ToString().Length!=10)
            {
                MessageBox.Show("Mobile Number invalid.It must be of 10 digits");
            }
            else
            {
                String ll = "";
                if (!String.IsNullOrEmpty(landline.Text))
                {
                    ll = landline.Text;
                }
                OracleCommand cmdc = new OracleCommand("select * from supplier order by supplier_id", con);
                OracleDataReader odr = cmdc.ExecuteReader();
                while (odr.Read())
                {
                    iid = Int32.Parse((odr["supplier_id"].ToString()));
                }
                iid = iid + 1;
                OracleCommand cmd1 = new OracleCommand("insert into supplier values(" + iid.ToString() + ",'" + name.Text + "','" + address.Text + "'," + mobile.Text + "," + ll + ",'" + email.Text + "')", con);
                OracleDataReader odr2 = cmd1.ExecuteReader();
                MessageBox.Show("Supplier Added Succesfully");
                SupTable a = new SupTable();
                a.Show();
                this.Hide();
            }
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }
    }
}
