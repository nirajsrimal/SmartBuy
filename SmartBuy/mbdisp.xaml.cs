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
    /// Interaction logic for mbdisp.xaml
    /// </summary>
    public partial class mbdisp : Window 
    {
        OracleConnection con = new OracleConnection("Data Source = orcl; User ID=system; Password=niraj");
        public mbdisp()
        {
            con.Open();
            InitializeComponent();
            addMobiles();
        }

        public void addMobiles()
        {
        
                OracleCommand cmd = new OracleCommand("select * from filter natural join device_photos", con);
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                int n = cmd.ExecuteNonQuery();
                int i = 0;
                Button[] bb = new Button[100];
                while (dr.Read())
                {
                    if ((dr["device_type"].ToString()).Equals("Phone"))
                    {
                        bb[i] = new Button();
                        bb[i].BorderBrush = null;
                        bb[i].Background = null;
                        StackPanel sp = new StackPanel();
                        string url = dr["device_photo"].ToString();
                        Uri u = new Uri(url, UriKind.Relative);
                        BitmapImage b = new BitmapImage();
                        b.BeginInit();
                        b.UriSource = u;
                        b.CacheOption = BitmapCacheOption.OnLoad;
                        b.EndInit();
                        Image img = new Image();
                        Label l = new Label();
                        Label l1 = new Label();
                        StackPanel sp0 = new StackPanel();
                        sp0.Width = 135;
                        sp0.Height = 350;
                        sp0.Margin = new Thickness(30, -1, 30, -1);
                        l.Content = new TextBlock() { Text = dr["device_model"].ToString(), TextWrapping = TextWrapping.Wrap };
                        l.FontWeight = FontWeights.Bold;
                        l.HorizontalAlignment = HorizontalAlignment.Center;
                        l1.Content = new TextBlock() { Text = "Price :  ₹ " + dr["device_price"].ToString(), TextWrapping = TextWrapping.Wrap };
                        l1.FontWeight = FontWeights.Bold;
                        l1.HorizontalAlignment = HorizontalAlignment.Center;

                        img.Source = b;
                        sp.Children.Add(img);
                        bb[i].Content = sp;
                        bb[i].Width = 130;
                        bb[i].Height = 290;
                        bb[i].Name = "d" + dr["device_id"].ToString().Trim();
                        bb[i].Click += (SourceChangedEventArgs, e) =>
                        {
                        // string id = bb[i].Name.ToString();
                        var button = SourceChangedEventArgs as Button;
                        //MessageBox.Show(button.Name.ToString().Remove(0, 1));
                        String sql1 = "delete from selected_device";
                        String sql2 = "insert into selected_device values(" + button.Name.ToString().Remove(0, 1) + ")";
                            OracleCommand cmd1 = new OracleCommand(sql1, con);
                            OracleCommand cmd2 = new OracleCommand(sql2, con);
                            cmd1.ExecuteNonQuery();
                            cmd2.ExecuteNonQuery();
                            motoxf mt = new motoxf();
                            mt.Show();
                            this.Hide();
                        };
                        sp0.Children.Add(bb[i]);
                        sp0.Children.Add(l);
                        sp0.Children.Add(l1);
                        wp.Children.Add(sp0);
                        i++;
                    }
                    else
                    {
                        bb[i] = new Button();
                        bb[i].BorderBrush = null;
                        bb[i].Background = null;
                        StackPanel sp = new StackPanel();
                        string url = dr["device_photo"].ToString();
                        Uri u = new Uri(url, UriKind.Relative);
                        BitmapImage b = new BitmapImage();
                        b.BeginInit();
                        b.UriSource = u;
                        b.CacheOption = BitmapCacheOption.OnLoad;
                        b.EndInit();
                        Image img = new Image();
                        Label l = new Label();
                        Label l1 = new Label();
                        StackPanel sp0 = new StackPanel();
                        sp0.Width = 165;
                        sp0.Height = 350;
                        sp0.Margin = new Thickness(30, -1, 30, 1);
                        l.Content = new TextBlock() { Text = dr["device_model"].ToString(), TextWrapping = TextWrapping.Wrap };
                        l.FontWeight = FontWeights.Bold;
                        l.HorizontalAlignment = HorizontalAlignment.Center;
                        l1.Content = new TextBlock() { Text = "Price :  ₹ " + dr["device_price"].ToString(), TextWrapping = TextWrapping.Wrap };
                        l1.FontWeight = FontWeights.Bold;
                        l1.HorizontalAlignment = HorizontalAlignment.Center;

                        img.Source = b;
                        sp.Children.Add(img);
                        bb[i].Content = sp;
                        bb[i].Width = 165;
                        bb[i].Height = 290;
                        bb[i].Name = "d" + dr["device_id"].ToString().Trim();
                        bb[i].Click += (SourceChangedEventArgs, e) =>
                        {
                        // string id = bb[i].Name.ToString();
                        var button = SourceChangedEventArgs as Button;
                        //MessageBox.Show(button.Name.ToString().Remove(0, 1));
                        String sql1 = "delete from selected_device";
                            String sql2 = "insert into selected_device values(" + button.Name.ToString().Remove(0, 1) + ")";
                            OracleCommand cmd1 = new OracleCommand(sql1, con);
                            OracleCommand cmd2 = new OracleCommand(sql2, con);
                            cmd1.ExecuteNonQuery();
                            cmd2.ExecuteNonQuery();
                            motoxf mt = new motoxf();
                            mt.Show();
                            this.Hide();
                        };
                        sp0.Children.Add(bb[i]);
                        sp0.Children.Add(l);
                        sp0.Children.Add(l1);
                        wp.Children.Add(sp0);
                        i++;
                    }
                }
                result.Content = "Showing " + i.ToString() + " results";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Filter a = new Filter();
            a.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            Main_Menu a = new Main_Menu();
            a.Show();
            this.Hide();
        }
        
    }
}
