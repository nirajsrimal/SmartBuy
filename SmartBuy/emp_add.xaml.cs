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
    /// Interaction logic for emp_add.xaml
    /// </summary>
    public partial class emp_add : Window
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        public emp_add()
        {
            con.Open();
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(eid.Text)) || (String.IsNullOrEmpty(eid1.Text)))
            {
                MessageBox.Show("Some field may have been left blank");
            }
            else
            {
                if (eid.Text == eid1.Text)
                {
                    OracleCommand cmd = new OracleCommand("delete from employees where employee_id=" + eid.Text.ToString(), con);
                    OracleDataReader odr = cmd.ExecuteReader();
                    MessageBox.Show("Deletion Succesful.");
                    EmpTable ob = new EmpTable();
                    this.Visibility = Visibility.Hidden;
                    ob.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Employee ID or Employee ID's do not match");
                }
            }

        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void addemp_Click(object sender, RoutedEventArgs e)
        {
            int iid = 0;
            if ((String.IsNullOrEmpty(name.Text)) || (String.IsNullOrEmpty(address.Text)) || (String.IsNullOrEmpty(mobile.Text)))
                MessageBox.Show("Some Fields have been left blank");
            else if ((String.IsNullOrEmpty(email.Text)) || (String.IsNullOrEmpty(salary.Text)) || (String.IsNullOrEmpty(bonus.Text)))
                MessageBox.Show("Some Fields have been left blank");
            else if((mobile.Text).ToString().Length!=10)
            {
                MessageBox.Show("Invalid Mobile Number. Mobile Number should be of 10 digits");
            }
            else
            {
                OracleCommand cmdc = new OracleCommand("select * from employees order by employee_id", con);
                OracleDataReader odr = cmdc.ExecuteReader();
                while (odr.Read())
                {
                    iid = Int32.Parse((odr["employee_id"].ToString()));

                }
                iid = iid + 1;
                OracleCommand cmd1 = new OracleCommand("insert into employees values(" + iid.ToString() + ",'" + name.Text + "','" + address.Text + "','" + email.Text + "'," + mobile.Text + "," + salary.Text + "," + bonus.Text + ")", con);
                OracleDataReader odr1 = cmd1.ExecuteReader();
                MessageBox.Show("Employee Added");
                this.Visibility = Visibility.Hidden;
                EmpTable ob = new EmpTable();
                ob.Show();

            }
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            EmpTable ob = new EmpTable();
            this.Visibility = Visibility.Hidden;
            ob.Show();
        }
    }
}
