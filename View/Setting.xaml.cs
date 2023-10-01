using Crypto_V2.ViewModel;
using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Crypto_V2.Properties;
using Crypto_V2.View;

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




