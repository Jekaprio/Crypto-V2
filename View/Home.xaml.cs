using Crypto_V2.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Crypto_V2.View
{
    public partial class Home : Page
    {
        public static Home Instance;
        public Home()
        {
            Instance = this;
            InitializeComponent();
            HomeViewModel viewModel = new HomeViewModel();
            DataContext = viewModel;
           

            Storyboard animation = (Storyboard)FindResource("PageEnterAnimation");
            if (animation != null)
            {
                // Запустіть анімацію
                animation.Begin(ContentGrid);
            }
        }

       


    }
}
