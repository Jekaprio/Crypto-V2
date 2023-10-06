using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace Crypto_V2.ViewModel
{
    internal class DetailedViewModel
    {
        private readonly CryptoModel _cryptoModel;

        public ObservableCollection<CryptoModel.CryptoData> CryptoDataList { get; set; }

        public DetailedViewModel()
        {
            _cryptoModel = new CryptoModel();
            CryptoDataList = new ObservableCollection<CryptoModel.CryptoData>();
        }

        public CryptoModel.CryptoData SearchCryptoByNameOrSymbol(string searchTerm)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchTerm))
                    return null;
                var allCryptos = _cryptoModel.GetAllCryptoDataAsync().Result;
                var foundCrypto = allCryptos.FirstOrDefault(crypto => crypto.Name == searchTerm || crypto.Symbol == searchTerm);

                return foundCrypto;
            }
            catch (Exception)
            {
                MessageBox.Show("API don't work, check internet connection", "Details", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
        }
    }
}