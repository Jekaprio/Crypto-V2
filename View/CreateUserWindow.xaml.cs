using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using static Crypto_V2.View.Autorization;

namespace Crypto_V2.View
{
    public partial class CreateUserWindow : Window
    {
        public User CreatedUser { get; private set; }
        public static CreateUserWindow Instance;
        public CreateUserWindow()
        {
            Instance = this;
            InitializeComponent();
            MouseMove += Window_MouseMove;
            MouseUp += Window_MouseUp;
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            CreatedUser = new User
            {
                Username = UsernameTextBox.Text,
                Password = PasswordBox.Password
            };
            Close();
        }

        private bool isDraggind = false;
        private Point startPoint;
        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                isDraggind = true;
                startPoint = e.GetPosition(this);
            }
        }
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggind)
            {
                Point endPoint = e.GetPosition(this);
                double offsetX = endPoint.X - startPoint.X;
                double offsetY = endPoint.Y - startPoint.Y;

                Left += offsetX;
                Top += offsetY;
            }
        }
        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton != MouseButton.Left)
            {
                isDraggind = false;
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
