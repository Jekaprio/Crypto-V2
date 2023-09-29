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
                ResultTextBlock.Inlines.Clear();
                Hyperlink hyperlink = new Hyperlink(new Run($"Cryptocurrency found: {foundCrypto.Name} ({foundCrypto.Symbol})"));
                hyperlink.NavigateUri = new Uri(foundCrypto.explorer); // Додаємо URL до експлорера
                hyperlink.RequestNavigate += Hyperlink_RequestNavigate; // Обробник події для обробки натискання
                hyperlink.Style = (Style)Application.Current.Resources["HyperLinkStyle"];
                ResultTextBlock.Inlines.Add(hyperlink);
                ResultTextBlock.Inlines.Add(new LineBreak());
                ResultTextBlock.Inlines.Add($"Supply: {foundCrypto.Supply}");
                ResultTextBlock.Inlines.Add(new LineBreak());
                ResultTextBlock.Inlines.Add($"Price change in %: {foundCrypto.ChangePercent24Hr}");
            }
            else
            {
                ResultTextBlock.Text = "No cryptocurrency found";
            }
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            // Відкрити URL в браузері
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true; // Позначити подію обробленою, щоб TextBlock не сприймав її як звичайний текст
        }
       




    }
}
