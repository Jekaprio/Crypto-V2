using Crypto_V2.ViewModel;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using static CryptoModel;

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
                animation.Begin(ContentGrid);
            }
        }

        private void SaveToPdfButton_Click(object sender, RoutedEventArgs e)
        {
            if (Top10List != null && Top10List.Items.Count > 0)
            {
                var folderDialog = new System.Windows.Forms.FolderBrowserDialog();
                System.Windows.Forms.DialogResult result = folderDialog.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    string selectedFolderPath = folderDialog.SelectedPath;
                    PdfDocument doc = new PdfDocument();
                    doc.Info.Title = "Cryptocurrencies";
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

                    string programName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                    string currentDate = $"Date: {DateTime.Now:yyyy-MM-dd}";
                    string currentTime = $"Time: {DateTime.Now:HH:mm:ss}";

                    double textX = iconX + iconWidth + 10;
                    double textY = iconY + 10;

                    gfx.DrawString(programName, font, XBrushes.Black, textX, textY);
                    textY += 30;

                    gfx.DrawString(currentDate, font, XBrushes.Black, textX, textY);
                    textY += 20;

                    gfx.DrawString(currentTime, font, XBrushes.Black, textX, textY);

                    double x = 80;
                    double y = 150;

                    GridView gridView = Top10List.View as GridView;
                    foreach (GridViewColumn column in gridView.Columns)
                    {
                        gfx.DrawString(column.Header.ToString(), font, XBrushes.Black, x, y);
                        x += 110;
                    }

                    y += 40;

                    foreach (var item in Top10List.Items)
                    {
                        CryptoData listItem = item as CryptoData;
                        if (listItem != null)
                        {
                            x = 80;
                            gfx.DrawString(listItem.Rank, font, XBrushes.Black, x, y);
                            x += 110;
                            gfx.DrawString(listItem.Name, font, XBrushes.Black, x, y);
                            x += 110;
                            gfx.DrawString(listItem.Symbol, font, XBrushes.Black, x, y);
                            x += 110;
                            gfx.DrawString(listItem.PriceUsd, font, XBrushes.Black, x, y);
                        }
                        y += 25;
                    }

                    string fileName = $"Cryptocurrencies_{DateTime.Now:yyyy-MM-dd HH-mm-ss}.pdf";

                    string filePath = Path.Combine(selectedFolderPath, fileName);

                    try
                    {
                        doc.Save(filePath);
                        System.Diagnostics.Process.Start(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error when saving to PDF:", "Error" + ex.Message, MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("The ListView or its data source is empty.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
