using Crypto_V2.ViewModel;
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

namespace Crypto_V2.View
{
  
    public partial class Detailed : Page
    {
        public Detailed()
        {
            InitializeComponent();
            DetailedViewModel viewModel = new DetailedViewModel();
            DataContext = viewModel;
        }

        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = SearchTextBox.Text;
            var detailedViewModel = new DetailedViewModel();
            var foundCrypto = await Task.Run(() => detailedViewModel.SearchCryptoByNameOrSymbol(searchTerm));
            if (foundCrypto != null)
            {
                ResultTextBlock.Text = $"Cryptocurrency found: {foundCrypto.Name} ({foundCrypto.Symbol})";
            }
            else
            {
                ResultTextBlock.Text = "No cryptocurrency found";
            }
        }
      

    }
}
