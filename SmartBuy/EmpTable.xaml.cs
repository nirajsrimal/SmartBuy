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
    /// Interaction logic for EmpTable.xaml
    /// </summary>
    public partial class EmpTable : Window
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        public EmpTable()
        {
            InitializeComponent();
            getData();
        }

        public void getData()
        {
            using (con)
            {
                con.Open();
                string sql = "select * FROM employees";
                OracleCommand com = new OracleCommand(sql, con);


                using (OracleDataAdapter adapter = new OracleDataAdapter(com))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGrid.ItemsSource = dt.DefaultView;
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            emp_add a = new emp_add();
            a.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Visibility = Visibility.Hidden;
        }
    }
}
