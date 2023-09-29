using Crypto_V2.ViewModel;
using System.Windows.Controls;

namespace Crypto_V2.View
{
    public partial class Setting : Page
    {
        public Setting()
        {
            InitializeComponent();
            SettingViewModel viewModel = new SettingViewModel();
            DataContext = viewModel;
        }
    }
}
