using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace Crypto_V2.ViewModel
{
    internal class HomeViewModel
    {
        private readonly CryptoModel _cryptoModel;
        private readonly Timer _updateTimer;

        public HomeViewModel()
        {
            _cryptoModel = new CryptoModel();
            CryptoDataList = new ObservableCollection<CryptoModel.CryptoData>();
            LoadTop10CryptoDataAsync();
            _updateTimer = new Timer(30000);
            _updateTimer.Elapsed += async (sender, e) => await LoadTop10CryptoDataAsync();
            _updateTimer.AutoReset = true;
            _updateTimer.Enabled = true;
        }

        public ObservableCollection<CryptoModel.CryptoData> CryptoDataList { get; set; }

        public async Task LoadTop10CryptoDataAsync()
        {
            try
            {
                List<CryptoModel.CryptoData> data = await _cryptoModel.GetTop10CryptoDataAsync();
                Application.Current.Dispatcher.Invoke(() =>
                {
                    CryptoDataList.Clear();
                    foreach (var cryptoData in data)
                    {
                        CryptoDataList.Add(cryptoData);
                    }
                });
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("API don't work, check internet connection", "Home", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

