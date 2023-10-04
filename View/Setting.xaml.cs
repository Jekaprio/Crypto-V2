using Crypto_V2.ViewModel;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Crypto_V2.View
{
    public partial class Setting : Page
    {
        public static Setting Instance;
        public Setting()
        {

            Instance = this;
            InitializeComponent();
            DataContext = this;
            DataContext = new SettingViewModel();
            Storyboard animation = (Storyboard)FindResource("PageEnterAnimation");
            if (animation != null)
            {

                animation.Begin(ContentGrid);
            }

            var systemFonts = Fonts.SystemFontFamilies;

            foreach (FontFamily fontFamily in systemFonts)
            {
                FontComboBox.Items.Add(fontFamily.Source);
            }
        }




        public void FontComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedFontName = FontComboBox.SelectedItem.ToString();
            FontFamily selectedFontFamily = new FontFamily(selectedFontName);

            MainWindow mainWindow = MainWindow.Instance;
            Autorization autorization = Autorization.Instance;
            CreateUserWindow createUserWindow = CreateUserWindow.Instance;
            Detailed detailed = Detailed.Instance;
            Home home = Home.Instance;
            Setting setting = Setting.Instance;

            if (FontComboBox.SelectedItem != null)
            {
                mainWindow.Home_Button.FontFamily = selectedFontFamily;
                mainWindow.Details_Button.FontFamily = selectedFontFamily;
                mainWindow.Setting_Button.FontFamily = selectedFontFamily;
                mainWindow.API_Button.FontFamily = selectedFontFamily;
                mainWindow.Exit_Button.FontFamily = selectedFontFamily;
                mainWindow.TextBlockHello.FontFamily = selectedFontFamily;
            }
        }
    }

}

