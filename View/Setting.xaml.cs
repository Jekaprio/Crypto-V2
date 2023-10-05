using Crypto_V2.ViewModel;
using System.IO;
using System;
using System.Windows;
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

        public void Privacy_click(object sedner, RoutedEventArgs e)
        {
            string privacyPolicyText = File.ReadAllText("Properties/Privacy_Policy.txt");
            string MitLicenseText = File.ReadAllText("Properties/MIT_License.txt");
            try
            {
                MessageBox.Show(privacyPolicyText, "Privacy Policy", MessageBoxButton.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error opening Privacy Policy, contact JEKARPIO.", "Error" + ex.Message, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void MIT_click(object sedner, RoutedEventArgs e)
        {
            string privacyPolicyText = File.ReadAllText("Properties/Privacy_Policy.txt");
            string MitLicenseText = File.ReadAllText("Properties/MIT_License.txt");
            try
            {
                MessageBox.Show(MitLicenseText, "MIT License", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening License, contact JEKARPIO.", "Error" + ex.Message, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

