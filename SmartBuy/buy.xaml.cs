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
    /// Interaction logic for buy.xaml
    /// </summary>
    public partial class buy : Window
    {
        int iid = 0;
        public string cid1="";
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        private OracleConnection NOW;

        public buy()
        {
            con.Open();
            InitializeComponent();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            OracleCommand cmd = new OracleCommand("select * from selected_customer natural join customer", con);
            OracleDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                name.Text = dr["customer_name"].ToString();
                address.Text = dr["customer_address"].ToString();
                phone.Text = dr["customer_cellno"].ToString();
                email.Text = dr["customer_email"].ToString();
                cid1 = dr["customer_id"].ToString();
            }
             
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            name.Text = null;
            address.Text = null;
            phone.Text = null;
            email.Text = null;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            OracleCommand cmd1 = new OracleCommand("select * from sales order by sales_id", con);
            OracleDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                iid = Int32.Parse((dr1["sales_id"].ToString()));

            }
            iid = iid + 1;
            String dt = "";
            OracleCommand cmd3 = new OracleCommand("select to_char(sysdate,'dd/mm/yyyy') NOW from dual", con);
            OracleDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                dt = dr3["NOW"].ToString();

            }
            String did = "";
            String quan = "";
            String tot = "";
            OracleCommand cmd4 = new OracleCommand("select * from finalbuy", con);
            OracleDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                did = dr4["device_id"].ToString();
                quan = dr4["quantity"].ToString();
                tot = dr4["total"].ToString();
            }
            int t = Int32.Parse(tot);
            int q = Int32.Parse(quan);
            int sum = t / q;
            OracleCommand cmd6 = new OracleCommand("insert into sales values(" + iid.ToString() + ",'" + dt + "'," + cid1 + "," + did + "," + sum + "," + quan + "," + tot + ")", con);
            OracleDataReader dr6 = cmd6.ExecuteReader();
            OracleCommand cmd5 = new OracleCommand("insert into customer_history values("+cid1+","+did+ ")", con);
            OracleDataReader dr5 = cmd5.ExecuteReader();
            MessageBox.Show("Purchase Successful.");
            this.Hide();
            
        }
    }
}
