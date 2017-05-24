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
    /// Interaction logic for motoxf.xaml
    /// </summary>
    public partial class motoxf : Window
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        public string id;
        public string s="";
       // public int quantity;

        public motoxf()
        {
            con.Open();
            InitializeComponent();
            //label.Visibility = Visibility.Hidden;
            getData();
            //quantity = Int32.Parse(comboBox.Select1dItem.ToString());
            
        }
        public void getData()
        {
            int a = 0;
            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int avg = 0;
            //Label label = new Label();
            //label.Content = id;
            //id = label.Content.ToString();
            //id.Remove(0, 1);
            //int iid = Int32.Parse(id);
            String sql = "select * from selected_device";
            OracleCommand com = new OracleCommand(sql, con);
            OracleDataReader odr = com.ExecuteReader();
            if (odr.Read())
            {
                s = odr["device_id"].ToString();
            }

            String sql1 = " select * from device natural join memory natural join platform natural join features natural join rating natural join display natural join device_body where device_id =" + s;
            OracleCommand com1 = new OracleCommand(sql1, con);
            OracleDataReader odr1 = com1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[2] {new DataColumn("Specs"), new DataColumn("Info")});
            if(odr1.Read())
            {
                dt.Rows.Add("Brand", odr1["device_brand"]);
                dt.Rows.Add("Model",odr1["device_Model"]);
                dt.Rows.Add("Price", odr1["device_price"]);
                dt.Rows.Add("Device Launch", odr1["device_launch"]);
                dt.Rows.Add("Brand: ", odr1["device_brand"]);
                dt.Rows.Add("OS",odr1["device_os_type"]);
                dt.Rows.Add("OS Version", odr1["device_os_version"]);
                dt.Rows.Add("Battery", odr1["device_battery"]);
                dt.Rows.Add("RAM", odr1["ram"]);
                dt.Rows.Add("Internal Memory", odr1["rom"]);
                dt.Rows.Add("Expandable Memory", odr1["expandable_memory"]);
                dt.Rows.Add("Number of Cores", odr1["cores"]);
                dt.Rows.Add("Speed", odr1["speed"]);
                dt.Rows.Add("GPU", odr1["gpu"]);
                dt.Rows.Add("Chipset", odr1["chipset"]);
                dt.Rows.Add("Weight", odr1["weight"]);
                dt.Rows.Add("Thickness", odr1["thickness"]);
                dt.Rows.Add("length", odr1["length"]);
                dt.Rows.Add("breadth", odr1["breadth"]);
                dt.Rows.Add("Dual Sim", odr1["dual_sim"]);
                dt.Rows.Add("3G", odr1["sim_3g"]);
                dt.Rows.Add("4G", odr1["sim_4g"]);
                dt.Rows.Add("Primary Camera", odr1["primary_camera"]);
                dt.Rows.Add("Front Camera", odr1["front_camera"]);
                dt.Rows.Add("Screen Type", odr1["screentype"]);
                dt.Rows.Add("Display Size", odr1["screen_size"]);
                dt.Rows.Add("Pixel Density", odr1["pixel_density"]);
                dt.Rows.Add("Protection", odr1["protection"]);
                dt.Rows.Add("Accelerometer", odr1["accelerometer"]);
                dt.Rows.Add("Gyrometer", odr1["gyrometer"]);
                dt.Rows.Add("Proximity Sensor", odr1["Proximity_Sensor"]);
                dt.Rows.Add("Compass", odr1["Compass"]);
                dt.Rows.Add("Infrared Sensor", odr1["infrared_sensor"]);
                dt.Rows.Add("Heart Rate Sensor", odr1["heart_rate"]);
                dt.Rows.Add("Fingerprint Sensor", odr1["fingerprint"]);
                dt.Rows.Add("Barometer", odr1["Barometer"]);
                dt.Rows.Add("Waterproof", odr1["Waterproof"]);
                dt.Rows.Add("Dustproof", odr1["Dust_proof"]);
                dt.Rows.Add("Fast Charging", odr1["Fast_charging"]);
                dt.Rows.Add("AnTuTu Benchmark", odr1["antutu"]);
                dt.Rows.Add("Design Rating", odr1["design"]);
                dt.Rows.Add("Software Rating", odr1["software"]);
                dt.Rows.Add("Performance Rating", odr1["Performance"]);
                dt.Rows.Add("Value for Money", odr1["value_for_money"]);
                dataGrid.ItemsSource = dt.DefaultView;
            }
            String sql2 = " select * from device natural join memory natural join platform natural join features natural join rating natural join display natural join device_body natural join device_photos where device_id =" + s;
            OracleCommand com2 = new OracleCommand(sql2, con);
            OracleDataReader odr2 = com2.ExecuteReader();
            if (odr2.Read())
            {
                sp0.Width = 200;
                sp0.Height = 600;
                sp0.Margin = new Thickness(30, -1, 30, -1);


                l.Content = new TextBlock() { Text = odr2["device_brand"].ToString(), TextWrapping = TextWrapping.Wrap };
                l.FontWeight = FontWeights.Bold;
                l.HorizontalAlignment = HorizontalAlignment.Center;

                l1.Content = new TextBlock() { Text = odr2["device_model"].ToString(), TextWrapping = TextWrapping.Wrap };
                l1.FontWeight = FontWeights.Bold;
                l1.HorizontalAlignment = HorizontalAlignment.Center;

                a = Int32.Parse(odr2["performance"].ToString());
                a1 = Int32.Parse(odr2["design"].ToString());
                a2= Int32.Parse(odr2["software"].ToString());
                a3 = Int32.Parse(odr2["value_for_money"].ToString());

                string url = odr2["device_photo"].ToString();
                Uri u = new Uri(url, UriKind.Relative);
                BitmapImage b = new BitmapImage();
                b.BeginInit();
                b.UriSource = u;
                b.CacheOption = BitmapCacheOption.OnLoad;
                b.EndInit();
                img.Source = b;
                double avg1 =((a+a1+a2+a3)/4.0);
                avg = (int)Math.Round(avg1);
                label2.Content = "Rating : " + avg1 + "/10.0";
                label2.ToolTip = "Rating : "+avg1+"/10.0";
                price.Content = odr2["device_price"].ToString();
            }
         }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            Main_Menu a = new Main_Menu();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            mbdisp a = new mbdisp();
            a.Show();
            this.Hide();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(quantity.Text))
            {
                MessageBox.Show("Please Enter Quantity");
            }
            else
            {
                String sql2 = "delete from finalbuy";
                OracleCommand cmd2 = new OracleCommand(sql2, con);
                cmd2.ExecuteNonQuery();
                String sql1 = "insert into finalbuy values("+s+","+quantity.Text+","+total.Content+")";
                OracleCommand cmd1 = new OracleCommand(sql1, con);
                cmd1.ExecuteNonQuery();
                buy a = new buy();
                a.Show();
            }
        }

        private void quantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            int n;
            if (String.IsNullOrEmpty(quantity.Text))
                n = 0;
            else
            {
                n = Int32.Parse(quantity.Text.ToString());
            }
            int p = Int32.Parse(price.Content.ToString());
            int tot = n * p;
            total.Content = tot.ToString();
        }
    }
}
