using Crypto_V2.ViewModel;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using static CryptoModel;

namespace Crypto_V2.View
{

    public partial class Detailed : Page
    {
        public static Detailed Instance;
        private readonly CryptoModel _cryptoModel;
       
        public Detailed()
        {
            InitializeComponent();
            Instance = this;
            _cryptoModel = new CryptoModel();
            DetailedViewModel viewModel = new DetailedViewModel();
            DataContext = viewModel;

            Storyboard animation = (Storyboard)FindResource("PageEnterAnimation");
            if (animation != null)
            {
                // Запустіть анімацію
                animation.Begin(ContentGrid);
            }
        }

        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = Search_TextBox.Text;
            var detailedViewModel = new DetailedViewModel();
            var foundCrypto = await Task.Run(() => detailedViewModel.SearchCryptoByNameOrSymbol(searchTerm));
            if (foundCrypto != null)
            {
                Result_TextBlock.Inlines.Clear();
                Result_TextBlock.Inlines.Add(new Bold(new Run("Cryptocurrency found:  ")));
                Hyperlink hyperlink = new Hyperlink(new Run($"{foundCrypto.Name} ({foundCrypto.Symbol})"));
                hyperlink.NavigateUri = new Uri(foundCrypto.explorer); 
                hyperlink.RequestNavigate += Hyperlink_RequestNavigate; 
                hyperlink.Style = (Style)Application.Current.Resources["HyperLink_Style"];
                Result_TextBlock.Inlines.Add(hyperlink);
                Result_TextBlock.Inlines.Add(new LineBreak());
                Result_TextBlock.Inlines.Add(new Bold(new Run("Volume:  ")));
                Result_TextBlock.Inlines.Add($"{foundCrypto.Supply}");
                Result_TextBlock.Inlines.Add(new LineBreak());
                Result_TextBlock.Inlines.Add(new Bold(new Run("Price change:  ")));
                Result_TextBlock.Inlines.Add($"{foundCrypto.ChangePercent24Hr} %");
            }
            else
            {
                Result_TextBlock.Text = "No cryptocurrency found";
            }   
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

    }
}
