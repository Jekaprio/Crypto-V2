using Crypto_V2.ViewModel;
using System.Windows.Controls;


namespace Crypto_V2.View
{
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            HomeViewModel viewModel = new HomeViewModel();
            DataContext = viewModel;
        }
    }
}
