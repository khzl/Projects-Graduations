using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Threading.Tasks;


namespace DragonOCR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] langarr = {  "Arabic", "English" };
        string[] langarrmini = {  "ara", "eng" };

        string langnow = "eng";
        Thread thread_ocr;
        Thread thread_xulyocr;
        Thread thread_onload;
        string textscaned;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void _close(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
            //System.Environment.Exit(1);
        }

        private void _minimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        public void OnLoad()
        {
            while (true)
            {
                this.Dispatcher.Invoke(() =>
                {
                    int indexarr = Array.IndexOf(langarr, _ocrlang.Text);
                    langnow = langarrmini[indexarr];
                });
                Thread.Sleep(100);
            }
        }


        private void threadxulyocr()
        {
            string checkapikeystring = "";
            this.Dispatcher.Invoke(() =>
            {
                checkapikeystring = _apikey.Text;
            });
            if (checkapikeystring == "")
            {
                System.Windows.Forms.MessageBox.Show("Please type API-key!!");
            }
            else
            {
                this.Dispatcher.Invoke(() =>
                {
                    _process.Visibility = System.Windows.Visibility.Visible;
                    _trangthai.Content = "Running OCR Tesseract System...";
                });


                thread_ocr = new Thread(() => OCR(Directory.GetCurrentDirectory() + "\\scan.jpg", langnow));
                thread_ocr.IsBackground = true;
                thread_ocr.Start();
                while (thread_ocr.IsAlive)
                {
                    Thread.Sleep(100);
                }
                this.Dispatcher.Invoke(() =>
                {
                    _process.Visibility = System.Windows.Visibility.Hidden;
                    _trangthai.Content = "Done!";
                    _text.Text = textscaned;
                    if (_googlecheck.IsChecked == true)
                    {
                        System.Diagnostics.Process.Start("https://www.google.com/search?q=" + textscaned);
                    }
                    if (_copycheck.IsChecked == true)
                    {
                        System.Windows.Clipboard.SetText(textscaned);
                    }
                });
            }
        }


        // Button Snipping Tool
        // Use The Snipping Tool To Capture a Screen Region 
        private  void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            System.Drawing.Image bmp = clsSnippingTool.Snip();
            this.Show();

            if (bmp != null)
            {
                string imagePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "scan.jpg");

                if (File.Exists(imagePath))
                    File.Delete(imagePath);

                bmp.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);

                _trangthai.Content = "Running OCR....";
                _process.Visibility = Visibility.Visible;

                this.Show();
                thread_xulyocr = new Thread(() => threadxulyocr());
                thread_xulyocr.IsBackground = true;
                thread_xulyocr.Start();
            }
        }

        private void OCR(string path, string lang = "eng")
        {
            if (lang != "eng" && lang != "ara")
            {
                lang = "eng";
            }

            try
            {
                var client = new RestClient("https://api.ocr.space/parse/image");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddParameter("language", lang);
                request.AddFile("file", path);
                request.AddParameter("apikey", "Api Key Write Here");
                IRestResponse response = client.Execute(request);
                JObject o = JObject.Parse(response.Content);
                textscaned = (string)o["ParsedResults"][0]["ParsedText"];
            }
            catch
            {
                textscaned = "Api-key not working or Image do not support!!";
            }

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //this.Activate();

            _process.Visibility = System.Windows.Visibility.Hidden;
            this.Activate();
            thread_onload = new Thread(() => OnLoad());
            thread_onload.IsBackground = true;
            thread_onload.Start();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();

        }

        private void _copybt_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Clipboard.SetText(_text.Text);
            //System.Windows.Clipboard.SetText(textscaned);
        }

        // Upload Image Using a File Dialog 
        private  void _UploadImageButton_Click(object sender, RoutedEventArgs e)
        {

            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();

            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string FilePath = openFileDialog.FileName;

                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(FilePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.EndInit();
                _UploadImage.Source = bitmap;

                _trangthai.Content = "Processing OCR.....";
                _process.Visibility = Visibility.Visible;

                OCR(FilePath, langnow);

                _text.Text = textscaned;
                _trangthai.Content = "OCR Completed";
                _process.Visibility = Visibility.Hidden;
            }
        }
    }
}
