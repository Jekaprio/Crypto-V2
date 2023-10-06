using Crypto_V2.ViewModel;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Animation;
using System.Windows.Navigation;

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

        private void SaveToPdfButton_Click(object sender, RoutedEventArgs e)
        {
            var folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = folderDialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFolderPath = folderDialog.SelectedPath;
                PdfDocument doc = new PdfDocument();
                doc.Info.Title = "Crypto Details";
                PdfPage page = doc.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Agency FB", 20);
                string iconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "IMG.ico");
                XImage iconImage = XImage.FromFile(iconPath);

                double iconWidth = 40;
                double iconHeight = 40;
                double iconX = 20;
                double iconY = 20;

                gfx.DrawImage(iconImage, iconX, iconY, iconWidth, iconHeight);
                DateTime now = DateTime.Now;

                string currentDate = $"Date: {now:yyyy-MM-dd}";
                string currentTime = $"Time: {now:HH:mm:ss}";

                double textX = iconX + iconWidth + 10;
                double textY = iconY + 10;

                gfx.DrawString("Crypto V2", font, XBrushes.Black, textX, textY);
                textY += 30;
                gfx.DrawString(currentDate, font, XBrushes.Black, textX, textY);
                textY += 20;
                gfx.DrawString(currentTime, font, XBrushes.Black, textX, textY);

                double x = 80;
                double y = 150; 

                string resultText = Result_TextBlock.Text.ToString();
                string[] lines = resultText.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in lines)
                {
                    gfx.DrawString(line, font, XBrushes.Black, x, y);
                    y += 20; 
                }

                string fileName = $"CryptoDetails_{DateTime.Now:yyyy-MM-dd HH-mm-ss}.pdf";

                string filePath = Path.Combine(selectedFolderPath, fileName);

                try
                {
                    doc.Save(filePath);

                    System.Diagnostics.Process.Start(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error when saving to PDF: {ex.Message}");
                }
            }
        }
    }

}

