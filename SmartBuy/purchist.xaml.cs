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
using System.Data;

namespace SmartBuy
{
    /// <summary>
    /// Interaction logic for purchist.xaml
    /// </summary>
    public partial class purchist : Window
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        public purchist()
        {
            con.Open();
            InitializeComponent();
            getData();
            mediaElement.Play();
        }
        

        public void getData()
        {
            using (con)
            {
                String cid = "";
                String sql1 = "select * from selected_customer";
                OracleCommand com1 = new OracleCommand(sql1, con);
                OracleDataReader dr = com1.ExecuteReader();
                if(dr.Read())
                {
                    cid = dr["customer_id"].ToString();
                }
                string sql = "select sales_id,device_brand,device_model,sales_date,sales_rate,sales_quantity,sales_total FROM sales natural join device where customer_id =" + cid;
                OracleCommand com = new OracleCommand(sql, con);


                using (OracleDataAdapter adapter = new OracleDataAdapter(com))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGrid.ItemsSource = dt.DefaultView;
                }
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
            profile a = new profile();
            a.Show();
            this.Hide();
        }
    }
}
