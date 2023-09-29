 using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Timers;

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

            _updateTimer = new Timer(60000);
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
                //MessageBox.Show("Дані успішно завантажено. Кількість записів:" + CryptoDataList.Count); // Перевірка на кількість завантажених даних
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Помилка при завантаженні даних з API: " + ex.Message);
            }
        }
    }
}

