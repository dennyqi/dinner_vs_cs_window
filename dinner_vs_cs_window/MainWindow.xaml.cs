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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
//using System.Drawing.Imaging;
//using System.Drawing.Bitmap;
using System.IO;
using System.Data.SQLite; 
using System.Security.Cryptography.X509Certificates;
using System.Net;
//using System.Windows.Forms;
//using System.Security.Permissions;
using System.Threading;
using System.Diagnostics;
using MySql.Data.MySqlClient;


namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double count = 0;
        String path, imgpath, dbpath;
        string[] dishimage = new string[10];

        public MainWindow()
        {
            InitializeComponent();
            var date = DateTime.Now;
            //String filePath = @"C:\dqi\tftpd32\fish.jpg";
            //mydish.Source = new Uri(@"C:\dqi\tftpd32\fish.jpg", UriKind.Relative);
            today_date.Content = date.ToString();

            //change something from Sunnyvale
            //mycombox.SelectedIndex = 0;
            //Uri uri = new Uri(@"C:\dqi\tftpd32\fish.jpg", UriKind.Relative);
            //objImage.Source = new BitmapImage(new Uri("http://domain/images/myOwnImage.jpg", UriKind.Absolute));
            //Uri uri = new Uri(@"C:\dqi\tftpd32\fish.bmp", UriKind.Relative);
            //Uri uri = new Uri(@"C:/dqi/tftpd32/fish.jpg", UriKind.Absolute);
            //Uri uri = new Uri(@"C:\download\tftpd32\fish.jpg", UriKind.Relative);


            //Uri uri = new Uri(@"C:\dqi\tftpd32\fish.jpg");
            /*
                        // Create source
                        BitmapImage myBitmapImage = new BitmapImage();

                        // BitmapImage.UriSource must be in a BeginInit/EndInit block
                        myBitmapImage.BeginInit();
            */

            //ImageSource imgSource = new BitmapImage(uri);
            /*
                        BitmapImage myBitmapImage = new BitmapImage();
                        myBitmapImage.BeginInit();
                        myBitmapImage.UriSource = new Uri(@"C:\dqi\tftpd32\fish.jpg");
                        myBitmapImage.EndInit();
                        mydish.Source = myBitmapImage;
            */

            //BitmapImage imgSource = new BitmapImage(uri);
            //mydish.Source = imgSource;
            /*
                        // Create the image element.
                        Image simpleImage = new Image();
                        simpleImage.Width = 200;
                        simpleImage.Margin = new Thickness(5);
            */
            // Create source.

            path = Directory.GetCurrentDirectory();
            dbpath = path + "\\sqlite\\";
            imgpath = path + "\\image\\";
            //MessageBox.Show(path);
/*
            String dishimage = $"{imgpath}fishdish.jpg";
            //MessageBox.Show(imgpath);


            BitmapImage bi = new BitmapImage();
            // BitmapImage.UriSource must be in a BeginInit/EndInit block.
            bi.BeginInit();
            //bi.UriSource = new Uri(@"C:\download\tftpd32\fishyellow.jpg", UriKind.RelativeOrAbsolute);
            //bi.UriSource = new Uri($"{dishimage}", UriKind.RelativeOrAbsolute);
            //bi.UriSource = new Uri($"{dishimage}", UriKind.RelativeOrAbsolute);
            bi.UriSource = new Uri($"{imgpath}fishdish.jpg", UriKind.RelativeOrAbsolute);
            bi.EndInit();
            // Set the image source.
            //simpleImage.Source = bi;
            mydish.Source = bi;
*/
            init_menu();

            /*
                        //String filePath ="C:\\download\\tftpd32\\MyDatabase.sqlite";
                        String filePath = "C:\\download\\tftpd32\\dinner.sqlite";
                        if (!System.IO.File.Exists(filePath))
                        {
                            MessageBox.Show(filePath);
                            SQLiteConnection.CreateFile(filePath);
                        }

                        //SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                        SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={filePath}");
                        m_dbConnection.Open();

                        //string sql = "create table highscores (name varchar(20), score int)";
                        string sql = "create table menu (dish varchar(20), price numeric)";
                        SQLiteCommand command;
                        command = new SQLiteCommand(sql, m_dbConnection);
                        command.ExecuteNonQuery();

                        sql = "insert into menu (dish, price) values ('Spicy Fish', 10.00)";
                        command = new SQLiteCommand(sql, m_dbConnection);
                        command.ExecuteNonQuery();

                        sql = "insert into menu (dish, price) values ('Boiled Shrimp', 15.00)";
                        command = new SQLiteCommand(sql, m_dbConnection);
                        command.ExecuteNonQuery();

                        sql = "insert into menu (dish, price) values ('KongPao Chicken', 12.00)";
                        command = new SQLiteCommand(sql, m_dbConnection);
                        command.ExecuteNonQuery();

                        m_dbConnection.Close();
            */


            /*
                        m_dbConnection =
                        new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                        m_dbConnection.Open();
            */
        }

        private void count_orders(object sender, RoutedEventArgs e)
        {
            var date = DateTime.Now;
            int index = 0, count;
            string dinner, mystr;
            string orderman;

            today_date.Content = date.ToString();
            count = 0;
            if (leon_zhang.IsChecked.Value)
                count++;
            if (dennyqi.IsChecked.Value)
                count++;
            if (yirun.IsChecked.Value)
                count++;
            index = mycombox.SelectedIndex;
            dinner = mycombox.Text;
/*
            mystatusbar.ToolTip.ToString();
*/
            if (mypasswd.Password.Length > 0)
            {
                //index = 0;
                count = mypasswd.Password.Length;
                mystr = $"{count}";
                //MessageBox.Show(mystr);
                MessageBox.Show(mypasswd.Password.Length.ToString());
                mystr = mypasswd.Password.ToString();
                MessageBox.Show(mystr);
            }

            if (myusername.Text !="Please enter username")
                MessageBox.Show(myusername.Text);

            //mypasswd.GetValue();
            //MessageBox.Show(mypasswd.Password.ToString());
            //mystatusbar.Arrange = {0,100};
            //orderman = myradio.GetValue();

            //RadioButton myradiobutton[3];

            ///total_orders.Content = $"Total Orders: {count}";
            //total_orders.Content = $"Total Orders: {count}  Dinner: {index}  {dinner}";
            //total_orders.Content = $"Total Orders: {count}  \nDinner: {dinner}";
            /*
            orderman = myradio.Content;
            if ((bool)myradio.IsChecked)
                orderman = (string)myradio.Content.ToString();
            else if ((bool)myradio1.IsChecked)
                orderman = myradio1.Content.ToString();
            else if ((bool)myradio2.IsChecked)
                orderman = myradio2.Content.ToString();

            total_orders.Content = $"Total Orders: {count}\nDinner: {mycombox.Text}\nOrder Person: {orderman}";
*/
            //total_orders.Content = $"Total Orders: {count}\nDinner: {mycombox.Text}";


            //MessageBox.Show(myradio.Text);
            //MessageBox.Show(myradio.Content.ToString());
            //MessageBox.Show(myradio.Tag.ToString());
            ///MessageBox.Show(dinner);
        }

            private void leon_zhang_checked(object sender, RoutedEventArgs e)
            {
                /// total_orders.Content = "Total Orders: 1";
                count++;
                /// today_date.Content = $"{date: d} at {date: t}";
                /// total_orders.Content = $"Total Orders: {count}";
            }

            private void leon_zhang_unchecked(object sender, RoutedEventArgs e)
            {
                count--;
                /// today_date.Content = $"{date: d} at {date: t}";
                ///total_orders.Content = $"Total Orders: {count}";
            }

            private void dennyqi_unchecked(object sender, RoutedEventArgs e)
            {
                count--;
            }

            private void dennyqi_checked(object sender, RoutedEventArgs e)
            {
                count++;
            }

            private void myimage(object sender, EventArgs e)
            {
    /*
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                //   bitmap.UriSource = new Uri(@"C:\download\tftpd32\aei-white-2.png");
                bitmap.UriSource = new Uri(@"aei-white-2.png");
                bitmap.EndInit();
    */
    //actiontec.Source = bitmap;
        }

        private void myexit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void screenshot(object sender, RoutedEventArgs e)
        {
            /*
                        var fileName = String.Format("MyImage_{0:}.jpg", DateTime.Now.Ticks);
                        WriteableBitmap bmpCurrentScreenImage = new WriteableBitmap((int)this.ActualWidth, (int)this.ActualHeight);
                        bmpCurrentScreenImage.Render(LayoutRoot, new MatrixTransform());
                        bmpCurrentScreenImage.Invalidate();
                        SaveToMediaLibrary(bmpCurrentScreenImage, fileName, 100);
                        MessageBox.Show("Captured image " + fileName + " Saved Sucessfully", "WP Capture Screen", MessageBoxButton.OK);

                        currentFileName = fileName;
            */
            /*
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics graphics = Graphics.FromImage(bitmap as Image);

            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);

            bitmap.Save("c:\\screenshot.jpeg", ImageFormat.Jpeg);
            */

            /*
                        // Store the size of the map control
                        int Width = (int)MyMap.RenderSize.Width;
                        int Height = (int)MyMap.RenderSize.Height;
                        System.Windows.Point relativePoint = MyMap.TransformToAncestor(Application.Current.MainWindow).Transform(new System.Windows.Point(0, 0));
                        int X = (int)relativePoint.X;
                        int Y = (int)relativePoint.Y;

                        Bitmap Screenshot = new Bitmap(Width, Height);
                        Graphics G = Graphics.FromImage(Screenshot);
                        // snip wanted area
                        G.CopyFromScreen(X, Y, 0, 0, new System.Drawing.Size(Width, Height), CopyPixelOperation.SourceCopy);

                        string fileName = "C:\\myCapture.bmp";
                        System.IO.FileStream fs = System.IO.File.Open(fileName, System.IO.FileMode.OpenOrCreate);
                        Screenshot.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        fs.Close();
            */

            ///Bitmap bm = (Bitmap)Bitmap.FromFile(@"D:\Temp\MyImage.bmp");

        }

        private void newdish(object sender, DependencyPropertyChangedEventArgs e)
        {
            MessageBox.Show("new dish ?");
        }

        private void focuschanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            MessageBox.Show("new focus ?");
        }

        private void gotfocus(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("got focus ?");
        }

        private void selectchanged(object sender, SelectionChangedEventArgs e)
        {
            int index = 0;
            string dinner;
            //String filePath = @"C:\download\tftpd32\fish.jpg";
            String filePath = $"{imgpath}fish.jpg";

            index = mycombox.SelectedIndex;
            dinner = mycombox.Text;

            //MessageBox.Show($"select changed {index}:{dinner}");
            if (index == 0)
            {
                //filePath = @"C:\download\tftpd32\fish.jpg";
                filePath = $"{imgpath}fish.jpg";
            }
            else if (index == 1)
            {
                //filePath = @"C:\download\tftpd32\shrimp.jpg";
                filePath = $"{imgpath}shrimp.jpg";
            }
            else if (index == 2)
            {
                //filePath = @"C:\download\tftpd32\chicken.jpg";
                filePath = $"{imgpath}chicken.jpg";
            }
            else if (index == 3)
            {
                //filePath = @"C:\download\tftpd32\pork.jpg";
                filePath = $"{imgpath}pork.jpg";
            }
            else if (index == 4)
            {
                //filePath = @"C:\download\tftpd32\vege.jpg";
                filePath = $"{imgpath}vege.jpg";
            }

            filePath = $"{imgpath}{dishimage[index]}";
            //MessageBox.Show(filePath);
            //MessageBox.Show("first ?");

            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(filePath, UriKind.RelativeOrAbsolute);
            bi.EndInit();
            // Set the image source.
            //simpleImage.Source = bi;
            mydish.Source = bi;
        }

        private void mybrower_init(object sender, EventArgs e)
        {
            //Navigate("https://www.google.com");
            //mybrowser.Navigate(new Uri("https://docs.google.com/forms/d/e/1FAIpQLScTdzkph5DHlg4W3qZgoQ8gy0YNPDEMcuCpUJIkD1M4831_hw/viewanalytics?usp=form_confirm"));
            //mybrowser.Navigate(new Uri($"https://docs.google.com/forms/d/e/1FAIpQLScTdzkph5DHlg4W3qZgoQ8gy0YNPDEMcuCpUJIkD1M4831_hw/viewanalytics"));
        }

        private void mylist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void mydb(object sender, RoutedEventArgs e)
        {

            String filePath = $"{dbpath}dinner.sqlite";

            //MessageBox.Show(filePath);

            if (File.Exists(filePath))
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(filePath);
            }

            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show(filePath);
                SQLiteConnection.CreateFile(filePath);
            }

/*
            MessageBox.Show(dbpath);
            MessageBox.Show(filePath);
            return;
*/

            //SQLiteConnection.CreateFile(filePath);


            //SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={filePath}");
            m_dbConnection.Open();

            //string sql = "create table highscores (name varchar(20), score int)";
            string sql = "create table menu (dish varchar(20), image varchar(64), price numeric)";
            SQLiteCommand command;
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "insert into menu (dish, image, price) values ('Super Burrito', 'burrito.jpg', 12.00)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "insert into menu (dish, image, price) values ('Spicy Shrimp', 'spicyshrimp.jpg', 15.00)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "insert into menu (dish, image, price) values ('KungPao Chicken', 'kungpaochicken.jpg', 12.00)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "insert into menu (dish, image, price) values ('Steamed Fish', 'steamedfish.jpg', 10.00)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "insert into menu (dish, image, price) values ('Fried green bean', 'greenbean.jpg', 10.00)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            m_dbConnection.Close();
        }


        private void init_menu()
        {
            string sql;
            int idx = 0;
            SQLiteCommand command;
            //String filePath = "C:\\download\\tftpd32\\dinner.sqlite";
            String filePath = $"{dbpath}dinner.sqlite";

/*
            GC.Collect();
            GC.WaitForPendingFinalizers();
*/

            SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={filePath}");
            m_dbConnection.Open();

            sql = "select * from menu";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            SQLiteDataReader r = command.ExecuteReader();
            mycombox.Items.Clear();
            mylist.Items.Clear();
            while (r.Read())
            {
                string FileNames = (string)r["dish"];
                string image = (string)r["image"];
                dishimage[idx] = image;
                //MessageBox.Show(image);
                //MessageBox.Show(dishimage[idx]);
                idx++;
                //mycombox.SelectedValue = FileNames;
                mycombox.Items.Add(FileNames);
                mylist.Items.Add(FileNames + " " + image);
            }
            m_dbConnection.Close();
            mycombox.SelectedIndex = 0;
        }

        private void MyThreadMethod()
        {
            //MessageBox.Show("MyThreadMethod");
            //ConsoleManager.Show();
            //System.Diagnostics.Debug.WriteLine("hello", console.OutputBlock.Text);
            //System.Diagnostics.Debug.WriteLine("hello", "test");
            Console.WriteLine("First thread: ");
            //Console.ReadLine();
            //mylist.Items.Add("First thread:");
            //Thread.Sleep(5000);
            //myprogressbar.Value = 100;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myprogressbar.Minimum = 0;
            myprogressbar.Maximum = 200;
            myprogressbar.Value = 50;

            Thread t = new Thread(new ThreadStart(MyThreadMethod));
            t.Priority = ThreadPriority.Highest;
            //t.Priority = ThreadPriority.Lowest;
            t.Name = "mythread";
            t.Start();
            t.Join();

            //MessageBox.Show(t.IsAlive.ToString());
            //MessageBox.Show(t.IsAlive.ToString());


            //t.IsBackground = true;
            //Console.Read();
            //Console.ReadLine();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void fretch_menu(object sender, RoutedEventArgs e)
        {
            init_menu();
            //mycombox.SelectedIndex = 0;

            //mycombox.SelectedValue = FileNames;

            /*
                        using (SQLiteConnection connect = new SQLiteConnection(@"Data Source=C:\\download\\tftpd32\\dinner.sqlite"))
                        {
                            connect.Open();
                            using (SQLiteCommand fmd = connect.CreateCommand())
                            {
                                SQLiteCommand sqlComm = new SQLiteCommand(@"SELECT dish FROM menu");
                                SQLiteDataReader r = sqlComm.ExecuteReader();
                                while (r.Read())
                                {
                                    string FileNames = (string)r["dish"];

                                    //List<string> ImportedFiles = new List<string>();
                                }

                                connect.Close();
                            }
                        }
            */
        }

        private void myorder(object sender, RoutedEventArgs e)
        {

            // Create a request using a URL that can receive a post.   
            WebRequest request = WebRequest.Create("https://docs.google.com/forms/d/e/1FAIpQLScTdzkph5DHlg4W3qZgoQ8gy0YNPDEMcuCpUJIkD1M4831_hw/formResponse");
            // Set the Method property of the request to POST.  
            request.Method = "POST";
            // Create POST data and convert it to a byte array.  
            string postData = "entry.584591229=Denny Qi";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.  
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.  
            request.ContentLength = byteArray.Length;
            // Get the request stream.  
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.  
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.  
            dataStream.Close();
            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.  
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.  
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Display the content.  
            Console.WriteLine(responseFromServer);
            // Clean up the streams.  
            reader.Close();
            dataStream.Close();
            response.Close();
            /*
            //            Net::HTTP.post_form(URI.parse('https://somplace.example.com'), { 'foo'=>'bar', 'bas'=>'off'})

                        // this is what we are sending
                        string post_data = "foo=bar&baz=oof";

                        // this is where we will send it
                        string uri = "https://someplace.example.com";

                        // create a request
                        HttpWebRequest request = (HttpWebRequest)
                        WebRequest.Create(uri); request.KeepAlive = false;
                        request.ProtocolVersion = HttpVersion.Version10;
                        request.Method = "POST";

                        // turn our request string into a byte stream
                        byte[] postBytes = Encoding.ASCII.GetBytes(str);

                        // this is important - make sure you specify type this way
                        request.ContentType = "application/x-www-form-urlencoded";
                        request.ContentLength = postBytes.Length;
                        Stream requestStream = request.GetRequestStream();

                        // now send it
                        requestStream.Write(postBytes, 0, postBytes.Length);
                        requestStream.Close();

                        // grab te response and print it out to the console along with the status code
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        Console.WriteLine(new StreamReader(response.GetResponseStream()).ReadToEnd());
                        Console.WriteLine(response.StatusCode);
            */

        }


    }
}
