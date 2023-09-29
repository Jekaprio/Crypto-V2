using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CryptoModel;

namespace Crypto_V2.ViewModel
{
    internal class DetailedViewModel
    {
        private readonly CryptoModel _cryptoModel;

        [JsonProperty("explorer")]
        public string Explorer { get; set; }

        public ObservableCollection<CryptoModel.CryptoData> CryptoDataList { get; set; }

        public DetailedViewModel()
        {
            _cryptoModel = new CryptoModel();
            CryptoDataList = new ObservableCollection<CryptoModel.CryptoData>();
        }

        public List<CryptoModel.CryptoData> GetAllCryptos()
        {
            return _cryptoModel.GetAllCryptoDataAsync().Result;
        }

        public CryptoModel.CryptoData SearchCryptoByNameOrSymbol(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return null;

            var allCryptos = _cryptoModel.GetAllCryptoDataAsync().Result;
            var foundCrypto = allCryptos.FirstOrDefault(crypto => crypto.Name == searchTerm || crypto.Symbol == searchTerm);

            return foundCrypto;
        }

       

    }
}
