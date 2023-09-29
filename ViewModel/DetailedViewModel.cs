using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_V2.ViewModel
{
    internal class DetailedViewModel
    {
        private readonly CryptoModel _cryptoModel;
      

        public DetailedViewModel()
        {
            _cryptoModel = new CryptoModel();
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
