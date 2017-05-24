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
    public partial class SalesTable : Window
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        public SalesTable()
        {
            InitializeComponent();
            getData();
        }

        public void getData()
        {
            using (con)
            {
                con.Open();
                string sql = "select * FROM sales natural join customer";
                OracleCommand com = new OracleCommand(sql, con);


                using (OracleDataAdapter adapter = new OracleDataAdapter(com))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGrid.ItemsSource = dt.DefaultView;
                }
            }
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }
    }
}
