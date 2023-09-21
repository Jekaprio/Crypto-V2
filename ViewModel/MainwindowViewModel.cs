using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Crypto_V2.ViewModel
{
    public class MainwindowViewModel
    {
        private readonly CryptoModel _cryptoModel;

        public MainwindowViewModel()   // Колекція CoinData
        {
            _cryptoModel = new CryptoModel();
            CoinCapData = new ObservableCollection<string>();
        }
        
        public ObservableCollection<string> CoinCapData {  get; set; }
       

        public async Task LoadCoinCapDataAsync()  // Завантаження даних і додавання в CoinCapData
        {
            string data = await _cryptoModel.GetCoinCapdataAsync();
            CoinCapData.Add(data);
        }
        
       

       
    }
}
