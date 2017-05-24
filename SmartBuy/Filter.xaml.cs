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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Filter : Window
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        public int f13=0, f131=0, f14=0, f15=0, f16=0, f17=0,f18=0, f19=0, f20=0, f201=0, f21=0, f22=0, f23 = 0, f24 = 0, f25 = 0;
        public String sql = "create or replace view filter as select * from filterbrand";
        //public String sq1 = "select * from filterbrand";
        public String sql2 = "select * from filterbrand";
        public String sql0 = "select * from filterbrand";
        public String sql1 = "select * from filterbrand";
        public String sql3 = "select * from filterbrand";
        public String sql4 = "select * from filterbrand";
        public String sql5 = "select * from filterbrand";
        public String sql6 = "select * from filterbrand";
        public String sql61 = "select * from filterbrand";
        public String sql7 = "select * from filterbrand";
        public String sql8 = "select * from filterbrand";
        public String sql9 = "select * from filterbrand";
        public String sql10 = "select * from filterbrand";
        public String sql11 = "select * from filterbrand";
        public String sql12 = "select * from filterbrand";
        public String sql13 = "select * from filterbrand where 1=0";
        public String sql131 = "select * from filterbrand where 1=0";
        public String sql14 = "select * from filterbrand where 1=0";
        public String sql15 = "select * from filterbrand where 1=0";
        public String sql16 = "select * from filterbrand where 1=0";
        public String sql17 = "select * from filterbrand where 1=0";
        public String sql18 = "select * from filterbrand where 1=0";
        public String sql19 = "select * from filterbrand where 1=0";
        public String sql20 = "select * from filterbrand where 1=0";
        public String sql201 = "select * from filterbrand where 1=0";
        public String sql21 = "select * from filterbrand where 1=0";
        public String sql22 = "select * from filterbrand where 1=0";
        public String sql23 = "select * from filterbrand where 1=0";
        public String sql24 = "select * from filterbrand where 1=0";
        public String sql25 = "select * from filterbrand where 1=0";

        public double highval=90000; 
        public String sqlp = "select * from filterbrand";
        public Filter()
        {
            con.Open();
            InitializeComponent();
            //sql = sql + " intersect " + sql2;
            price.Content = 144990;
            mediaElement.Play();

        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (price!= null)
            {
                highval = slider.Value;
                double abc = Math.Floor(highval); 
                price.Content = abc.ToString();
                sqlp = "select * from filterbrand where device_price between 0 and " + abc.ToString();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String sqll = "create or replace view filter as select * from filterbrand";
            OracleCommand cmd2 = new OracleCommand(sqll, con);
            cmd2.ExecuteNonQuery();
            mbdisp a = new mbdisp();
            this.Hide();
            a.Show();
            mediaElement.Stop();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            sql = sql + " intersect " + sqlp;
            String sqll1 = "", sqll2="", sqll3="", sqll4="";
            sqll1 = "("+sql0 + " intersect " + sql1 + " intersect " + sql2 + " intersect " + sql3 + " intersect " + sql4 + " intersect " + sql5 + " intersect " + sql6 + " intersect " + sql61 + " intersect " + sql7 + " intersect " + sql8 + " intersect " + sql9 + " intersect " + sql10 + " intersect " + sql11 + " intersect " + sql12 + ")";
            if (f13 == 0 && f131 == 0 && f14 == 0)
            {
                sqll2 = "select * from filterbrand";
            }
            else
            {
                sqll2 = "("+sql13 + " union " + sql131 + " union " + sql14+")";
            }
            if (f15 == 0 && f16 == 0 && f17 == 0 && f18 == 0 && f19 == 0 && f20 == 0 && f201 == 0)
            {
                sqll3 = "select * from filterbrand";
            }
            else
            {
                sqll3 = "("+sql15 + "  union " + sql16 + "  union " + sql17 + "  union " + sql18 + "  union " + sql19 + "  union " + sql20 + "  union " + sql201+")";
            }
            if (f21 == 0 && f22 == 0 && f23 == 0 && f24 == 0 && f25 == 0)
            {
                sqll4 = "select * from filterbrand";
            }
            else
            {
                sqll4 = "("+sql21 + "  union " + sql22 + "  union " + sql23 + "  union " + sql24 + "  union " + sql25+")";
            }
            sql = sql + " intersect "+ sqll1 + " intersect " + sqll2 + " intersect " + sqll3 + " intersect " + sqll4;
            OracleCommand cmd2 = new OracleCommand(sql, con);
            cmd2.ExecuteNonQuery();
            mbdisp a = new mbdisp();
          //  mediaElement.Stop();
            this.Hide();
            a.Show();
            mediaElement.Stop();
        }


        private void finger_Checked(object sender, RoutedEventArgs e)
        {
           sql0 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join features where fingerprint='Yes'";
        }
        private void finger_Unchecked(object sender, RoutedEventArgs e)
        {
            sql0 = "select * from filterbrand";
        }

        private void accelero_Checked(object sender, RoutedEventArgs e)
        {
            sql1 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join features where accelerometer='Yes'";
        }


        private void accelero_Unchecked(object sender, RoutedEventArgs e)
        {
            sql1 = "select * from filterbrand";
        }

       

        private void gyro_Checked(object sender, RoutedEventArgs e)
        {
            sql2 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join features where gyrometer='Yes'";
        }

        private void gyro_Unchecked(object sender, RoutedEventArgs e)
        {
            sql2 = "select * from filterbrand";
        }

        private void proximity_Checked(object sender, RoutedEventArgs e)
        {
            sql3 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join features where proximity_sensor='Yes'";
        }
        private void proximity_Unchecked(object sender, RoutedEventArgs e)
        {
            sql3 = "select * from filterbrand";
        }

       

        private void compass_Checked(object sender, RoutedEventArgs e)
        {
            sql4 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join features where compass='Yes'";
        }

        private void compass_Unchecked(object sender, RoutedEventArgs e)
        {
            sql4 = "select * from filterbrand";
    }

        private void infrared_Unchecked(object sender, RoutedEventArgs e)
        {
            sql5 = "select * from filterbrand";
        }

        private void infrared_Checked(object sender, RoutedEventArgs e)
        {
            sql5 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join features where infrared_sensor='Yes'";
        }

        private void heart_Checked(object sender, RoutedEventArgs e)
        {
            sql6 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join features where Heart_rate='Yes'";
        }

        private void heart_Unchecked(object sender, RoutedEventArgs e)
        {
            sql6 = "select * from filterbrand";
        }

        private void baro_Unchecked(object sender, RoutedEventArgs e)
        {
            sql61 = "select * from filterbrand";
        }

        private void baro_Checked(object sender, RoutedEventArgs e)
        {
            sql61 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join features where barometer='Yes'";
        }

        private void water_Checked(object sender, RoutedEventArgs e)
        {
            sql7 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join features where waterproof='Yes'";
        }

        private void water_Unchecked(object sender, RoutedEventArgs e)
        {
            sql7 = "select * from filterbrand";
        }

        private void dust_Unchecked(object sender, RoutedEventArgs e)
        {
            sql8 = "select * from filterbrand";
        }

        private void dust_Checked(object sender, RoutedEventArgs e)
        {
            sql8 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join features where dust_proof='Yes'";
        }

        private void fast_Checked(object sender, RoutedEventArgs e)
        {
            sql9 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join features where fast_charging='Yes'";
        }

        private void fast_Unchecked(object sender, RoutedEventArgs e)
        {
            sql9 = "select * from filterbrand";
        }

        private void dual_Unchecked(object sender, RoutedEventArgs e)
        {
            sql10 = "select * from filterbrand";
        }

        private void dual_Checked(object sender, RoutedEventArgs e)
        {
            sql10 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join device_body where dual_sim='Yes'";
        }

        private void g4_Checked(object sender, RoutedEventArgs e)
        {
            sql11 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join device_body where sim_4G='Yes'";
        }

        private void g4_Unchecked(object sender, RoutedEventArgs e)
        {
            sql11 = "select * from filterbrand";
        }

        private void sd_Unchecked(object sender, RoutedEventArgs e)
        {
            sql12 = "select * from filterbrand";
        }

        private void sd_Checked(object sender, RoutedEventArgs e)
        {
            sql12 = "(select * from filterbrand)minus(select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join memory where Expandable_memory ='0')";
        }

        private void android_Checked(object sender, RoutedEventArgs e)
        {
            sql13 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join device where device_os_type='Android'";
            f13 = 1;
        }

        private void android_Unchecked(object sender, RoutedEventArgs e)
        {
            sql13 = "select * from filterbrand where 1=0";
            f13 = 0;
        }

        private void windows_Checked(object sender, RoutedEventArgs e)
        {
            sql14 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join device where device_os_type='Windows'";
            f14 = 1;
        }

        private void windows_Unchecked(object sender, RoutedEventArgs e)
        {
            sql14 = "select * from filterbrand where 1=0";
            f14 = 0;
        }

        private void r1_Unchecked(object sender, RoutedEventArgs e)
        {
            sql15 = "select * from filterbrand where 1=0";
            f15 = 0;
        }

        private void r1_Checked(object sender, RoutedEventArgs e)
        {
            sql15 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join memory where RAM ='.512'";
            f15 = 1;
        }

        private void r2_Checked(object sender, RoutedEventArgs e)
        {
            sql16 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join memory where RAM ='1'";
            f16 = 1;
        }

        private void r2_Unchecked(object sender, RoutedEventArgs e)
        {
            sql16 = "select * from filterbrand where 1=0";
            f16 = 0;
        }

        private void r3_Unchecked(object sender, RoutedEventArgs e)
        {
            sql17 = "select * from filterbrand where 1=0";
            f17 = 0;
        }

        private void r3_Checked(object sender, RoutedEventArgs e)
        {
            sql17 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join memory where RAM ='1.5'";
            f17 = 1;
        }

        private void r4_Checked(object sender, RoutedEventArgs e)
        {
            sql18 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join memory where RAM ='2'";
            f18 = 1;
        }

        private void r4_Unchecked(object sender, RoutedEventArgs e)
        {
            sql18 = "select * from filterbrand where 1=0";
            f18 = 0;
        }

        private void r5_Unchecked(object sender, RoutedEventArgs e)
        {
            sql19 = "select * from filterbrand where 1=0";
            f19 = 0;
        }

        private void r5_Checked(object sender, RoutedEventArgs e)
        {
            sql19 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join memory where RAM ='3'";
            f19 = 1;
        }

        private void s1_Checked(object sender, RoutedEventArgs e)
        {
            sql201 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join display where screen_size <= 3.0";
            f201 = 1;    
        }

        private void s1_Unchecked(object sender, RoutedEventArgs e)
        {
            sql201 = "select * from filterbrand where 1=0";
            f201 = 0;
        }

        private void ios_Checked(object sender, RoutedEventArgs e)
        {
            sql131 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join device where device_os_type='iOS'";
            f131 = 1;
        }

        private void ios_Unchecked(object sender, RoutedEventArgs e)
        {
            sql131 = "select * from filterbrand where 1=0";
            f131 = 0;
        }

 
        private void back_Click(object sender, RoutedEventArgs e)
        {
            FilterBrand a = new FilterBrand();
            this.Hide();
            a.Show();
        }

        private void s2_Unchecked(object sender, RoutedEventArgs e)
        {
            sql21 = "select * from filterbrand where 1=0";
            f21 = 0;
            
        }

        private void s2_Checked(object sender, RoutedEventArgs e)
        {
            sql21 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join display where screen_size between 3.0 and 3.5";
            f21 = 1;
        }

        private void s3_Checked(object sender, RoutedEventArgs e)
        {
            sql22 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join display where screen_size between 3.5 and 4.0";
            f22 = 1;
        }

        private void s3_Unchecked(object sender, RoutedEventArgs e)
        {
            sql22 = "select * from filterbrand where 1=0";
            f22 = 0;
        }

        private void s4_Unchecked(object sender, RoutedEventArgs e)
        {
            sql23 = "select * from filterbrand where 1=0";
            f23 = 0;
        }

        private void s4_Checked(object sender, RoutedEventArgs e)
        {
            sql23 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join display where screen_size between 4.0 and 4.5";
            f23 = 1;
        }

        private void s5_Checked(object sender, RoutedEventArgs e)
        {
            sql24 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join display where screen_size between 4.5 and 5.0";
            f24 = 1;
        }

        private void s5_Unchecked(object sender, RoutedEventArgs e)
        {
            sql24 = "select * from filterbrand where 1=0";
            f24 = 0;
        }

        private void s6_Unchecked(object sender, RoutedEventArgs e)
        {
            sql25 = "select * from filterbrand where 1=0";
            f25 = 0;
        }

        private void s6_Checked(object sender, RoutedEventArgs e)
        {
            sql25 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join display where screen_size >= 5.0";
            f25 = 1;
        }

        private void r6_Checked(object sender, RoutedEventArgs e)
        {
            sql20 = "select device_id,device_type,device_launch,device_brand,device_model,device_price,device_os_version,device_os_type,device_battery from filterbrand natural join memory where RAM ='4'";
            f20 = 1;
        }

        private void r6_Unchecked(object sender, RoutedEventArgs e)
        {
            sql20 = "select * from filterbrand where 1=0";
            f20 = 0;
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            Main_Menu b = new Main_Menu();
            b.Show();
            this.Hide();
            mediaElement.Stop();

        }

    }
}
