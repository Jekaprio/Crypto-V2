using Crypto_V2.ViewModel;
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

namespace Crypto_V2
{
    public partial class MainWindow : Window
    {
        public readonly HttpClient _httpClient;

        public MainWindow()
        {
            InitializeComponent();
            _httpClient = new HttpClient();

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
            catch (WebException ex)
            {
                MessageBox.Show("Статус API: Виникла помилка при доступі до API", "Статус API", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

      
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}

