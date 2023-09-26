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
    }
}
