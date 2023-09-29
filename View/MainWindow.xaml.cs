using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
using Crypto_V2.ViewModel;

namespace Crypto_V2
{
    public partial class MainWindow : Window
    {
        public readonly HttpClient _httpClient;

        public MainWindow()
        {
            InitializeComponent();
           
            _httpClient = new HttpClient();
            
            this.MouseMove += Window_MouseMove;
            this.MouseUp += Window_MouseUp;
        }

        private void CheckApiStatus(object sender, RoutedEventArgs e)  // Перевірка працездатності API 
        {
            string apiUrl = "https://api.coincap.io/v2/assets";

            try
            {
                using (WebClient client = new WebClient())
                {
                    string response = client.DownloadString(apiUrl);
                    MessageBox.Show("Статус API: API праює нормально (HTTP 200 OK)", "Статус API", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (WebException)
            {
                MessageBox.Show("Статус API: Виникла помилка при доступі до API", "Статус API", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

      
        private void CloseButton_Click(object sender, RoutedEventArgs e) // Закрити програму 
        {
            this.Close();
        }

        private bool isDraggind = false; // Контролювати програму в TitleBar мишею
        private Point startPoint;

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left) 
            {
                isDraggind = true;
                startPoint = e.GetPosition(this);
            }
        }


        private void Window_MouseMove(object sender, MouseEventArgs e) 
        {
            if(isDraggind)
            {
                Point endPoint = e.GetPosition(this);
                double offsetX = endPoint.X - startPoint.X;
                double offsetY = endPoint.Y - startPoint.Y;

                Left += offsetX;
                Top += offsetY;
            }
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton != MouseButton.Left) 
            {
                isDraggind = false;
            }
        }

       private void Home_Click(object sender, RoutedEventArgs e)  // Відкрити сторінку Home
        {
            MainFrame.Navigate(new Uri("View/Home.xaml", UriKind.Relative));
            TextBlockHello.Background = Brushes.Transparent;
            TextBlockHello.Foreground = Brushes.Transparent;
        }

        private void Details_Click(object sender, RoutedEventArgs e) // Відкрити стоірнку Details
        {
            MainFrame.Navigate(new Uri("View/Detailed.xaml", UriKind.Relative));
            TextBlockHello.Background = Brushes.Transparent;
            TextBlockHello.Foreground = Brushes.Transparent;
        }

        private void Setting_Click(object sender, RoutedEventArgs e) // Відкрити сторінку Setting
        {
            MainFrame.Navigate(new Uri("View/Setting.xaml", UriKind.Relative));
            TextBlockHello.Background = Brushes.Transparent;
            TextBlockHello.Foreground = Brushes.Transparent; 
        }
    }
}

