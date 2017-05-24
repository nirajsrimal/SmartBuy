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
    /// Interaction logic for addphone.xaml
    /// </summary>
    public partial class addphone : Window
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        String f1 = "No";
        String f2 = "No";
        String f3 = "No";
        String f4 = "No";
        String f5 = "No";
        String f6 = "No";
        String f7 = "No";
        String f8 = "No";
        String f9 = "No";
        String f10 = "No";
        String f11 = "No";
        String f12 = "No";
        String f13 = "No";
        String f14 = "No";
        public addphone()
        {
            con.Open();
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String brand = "";
            int iid = 0;
            if ((String.IsNullOrEmpty(model.Text)) || (String.IsNullOrEmpty(price.Text)) || (String.IsNullOrEmpty(osv.Text)) || (String.IsNullOrEmpty(battery.Text)) || (String.IsNullOrEmpty(ram.Text)) || (String.IsNullOrEmpty(rom.Text)) || (String.IsNullOrEmpty(launch.Text)) || (String.IsNullOrEmpty(expandable.Text)) || (String.IsNullOrEmpty(Chipset.Text)) || (String.IsNullOrEmpty(length.Text)) || (String.IsNullOrEmpty(thickness.Text)) || (String.IsNullOrEmpty(breadth.Text)) || (String.IsNullOrEmpty(weight.Text)) || (String.IsNullOrEmpty(primary.Text)) || (String.IsNullOrEmpty(front.Text)) || (String.IsNullOrEmpty(cores.Text)) || (String.IsNullOrEmpty(Speed.Text)) || (String.IsNullOrEmpty(gpu.Text)) || (String.IsNullOrEmpty(screensize.Text)) || (String.IsNullOrEmpty(screentype.Text)) || (String.IsNullOrEmpty(pixel.Text)) || (String.IsNullOrEmpty(protection.Text)) || (String.IsNullOrEmpty(Antutu.Text)) || (String.IsNullOrEmpty(design.Text)) || (String.IsNullOrEmpty(software.Text)) || (String.IsNullOrEmpty(valuefor.Text)) || (String.IsNullOrEmpty(device_type.Text)) || (String.IsNullOrEmpty(device_os.Text)))
            {
                MessageBox.Show("Some fields may have been left blank");
            }
            else
            {
                OracleCommand cmdc = new OracleCommand("select * from device order by device_id", con);
                OracleDataReader odr = cmdc.ExecuteReader();
                while (odr.Read())
                {
                    iid = Int32.Parse((odr["device_id"].ToString()));
                }
                iid = iid + 1;
                //try
                //{
                    OracleCommand cmd1 = new OracleCommand("insert into device values(" + iid.ToString() + ",'" + device_type.Text + "','" + launch.Text + "'," + brands.Content.ToString() + "','" + model.Text + "','" + price.Text + "','" + osv.Text + "','" + device_os.Text + "','" + battery.Text + "')", con);
                    OracleCommand cmd2 = new OracleCommand("insert into device_features values(" + iid.ToString() + ",'" + f1 + "','" + f2 + "','" + f3 + "','" + f4 + "','" + f5 + "','" + f6 + "','" + f7 + "','" + f8 + "','" + f9 + "','" + f10 + "','" + f11 + "')", con);
                    OracleCommand cmd3 = new OracleCommand("insert into memory values(" + iid.ToString() + ", '" + ram.Text + "','" + rom.Text + "','" + expandable.Text + "')");
                    OracleCommand cmd4 = new OracleCommand("insert into platform values(" + iid.ToString() + ", '" + cores.Text + "','" + Speed.Text + "','" + gpu.Text + "','" + Chipset.Text + "')");
                    OracleCommand cmd5 = new OracleCommand("insert into device_body values(" + iid.ToString() + "," + length.Text + "," + thickness.Text + "," + length.Text + "," + breadth.Text + ",'" + f12 + "','" + f14 + "','" + f13 + "','" + primary.Text + "','" + front.Text + "')");
                    OracleCommand cmd6 = new OracleCommand("insert into rating values(" + iid.ToString() + "," + Antutu.Text + "," + design.Text + "," + software.Text + "," + performance.Text + "," + valuefor.Text + ")");
                    OracleCommand cmd7 = new OracleCommand("insert into display values(" + iid.ToString() + ",'" + screentype.Text + "'," + screensize.Text + "," + pixel.Text + ",'" + protection.Text + "')");
                    OracleCommand cmd8 = new OracleCommand("insert into device values(" + iid.ToString() + ",'" + device_type.Text + "')");
                    OracleDataReader odr1 = cmd1.ExecuteReader();
                    OracleDataReader odr2 = cmd2.ExecuteReader();
                    OracleDataReader odr3 = cmd3.ExecuteReader();
                    OracleDataReader odr4 = cmd4.ExecuteReader();
                    OracleDataReader odr5 = cmd5.ExecuteReader();
                    OracleDataReader odr6 = cmd6.ExecuteReader();
                    OracleDataReader odr7 = cmd7.ExecuteReader();
                    OracleDataReader odr8 = cmd8.ExecuteReader();
                    MessageBox.Show("Device Added");
                    Admin a = new Admin();
                    this.Hide();
                //}
                //catch
                //{
                //    MessageBox.Show("Please check data");
                //}

            }
        }
        private void finger_Checked(object sender, RoutedEventArgs e)
        {
            f7 = "Yes";
        }
        private void finger_Unchecked(object sender, RoutedEventArgs e)
        {
            f7 = "No";
        }

        private void accelero_Checked(object sender, RoutedEventArgs e)
        {
            f1 ="Yes";
        }


        private void accelero_Unchecked(object sender, RoutedEventArgs e)
        {
            f1 = "No";
        }



        private void gyro_Checked(object sender, RoutedEventArgs e)
        {
            f2 = "Yes";
        }

        private void gyro_Unchecked(object sender, RoutedEventArgs e)
        {
            f2 = "No";
        }

        private void proximity_Checked(object sender, RoutedEventArgs e)
        {
            f3 = "Yes";
        }
        private void proximity_Unchecked(object sender, RoutedEventArgs e)
        {
            f3 = "No";
        }



        private void compass_Checked(object sender, RoutedEventArgs e)
        {
            f4 = "Yes";
        }

        private void compass_Unchecked(object sender, RoutedEventArgs e)
        {
            f4 = "No";
        }

        private void infrared_Unchecked(object sender, RoutedEventArgs e)
        {
            f5 = "No";
        }

        private void infrared_Checked(object sender, RoutedEventArgs e)
        {
            f5 = "Yes";
        }

        private void heart_Checked(object sender, RoutedEventArgs e)
        {
            f6 = "Yes";
        }

        private void heart_Unchecked(object sender, RoutedEventArgs e)
        {
            f6 = "No";
        }

        private void baro_Unchecked(object sender, RoutedEventArgs e)
        {
            f8 = "No";
        }

        private void baro_Checked(object sender, RoutedEventArgs e)
        {
            f8 = "Yes";
        }

        private void water_Checked(object sender, RoutedEventArgs e)
        {
            f9 = "Yes";
        }

        private void water_Unchecked(object sender, RoutedEventArgs e)
        {
            f9 = "No";
        }

        private void dust_Unchecked(object sender, RoutedEventArgs e)
        {
            f10 = "No";
        }

        private void dust_Checked(object sender, RoutedEventArgs e)
        {
            f10 = "Yes";
        }

        private void fast_Checked(object sender, RoutedEventArgs e)
        {
            f11 = "Yes";
        }

        private void fast_Unchecked(object sender, RoutedEventArgs e)
        {
            f11 = "No";
        }

        private void dual_Unchecked(object sender, RoutedEventArgs e)
        {
            f12 = "No";
        }

        private void dual_Checked(object sender, RoutedEventArgs e)
        {
            f12 = "Yes";
        }

        private void g4_Checked(object sender, RoutedEventArgs e)
        {
            f13 = "Yes";
        }
        private void g4_Unchecked(object sender, RoutedEventArgs e)
        {
            f13 = "No";
        }
        private void g3_Checked(object sender, RoutedEventArgs e)
        {
            f14 = "Yes";
        }

        private void g3_Unchecked(object sender, RoutedEventArgs e)
        {
            f14 = "No";
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            brands.Content = "Mototrola";
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            brands.Content = "Micromax";
        }

        private void button_Copy7_Click(object sender, RoutedEventArgs e)
        {
            brands.Content = "Apple";
        }

        private void button_Copy5_Click(object sender, RoutedEventArgs e)
        {
            brands.Content = "Xiaomi";
        }

        private void button_Copy6_Click(object sender, RoutedEventArgs e)
        {
            brands.Content = "Asus";
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            brands.Content = "LG";
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            brands.Content = "Microsoft";
        }

        private void button_Copy9_Click(object sender, RoutedEventArgs e)
        {
            brands.Content = "Sony";
        }

        private void button_Copy4_Click(object sender, RoutedEventArgs e)
        {
            brands.Content = "Oneplus";
        }

        private void button_Copy8_Click(object sender, RoutedEventArgs e)
        {
            brands.Content = "Samsung";
        }

        private void button_Copy10_Click(object sender, RoutedEventArgs e)
        {
            brands.Content = "HTC";
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }
    }
}
