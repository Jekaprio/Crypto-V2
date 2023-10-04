using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Crypto_V2.View
{
    public partial class Autorization : Window
    {
        public static Autorization Instance;
        public Autorization()
        {
            InitializeComponent();
            Instance = this;
            MouseMove += Window_MouseMove;
            MouseUp += Window_MouseUp;
        }

        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string jsonFilePath = "Properties/users.json";
            List<User> users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(jsonFilePath));
            string enteredUsername = Login_TextBox.Text;
            string enteredPassword = Password_PassBox.Password;
            User user = users.FirstOrDefault(u => u.Username == enteredUsername && u.Password == enteredPassword);

            try
            {
                if (user != null)
                {
                    MessageBox.Show("Login successfully " + enteredUsername, "Autorization", MessageBoxButton.OK, MessageBoxImage.Information);

                    MainWindow objectWindow = new MainWindow();
                    Visibility = Visibility.Hidden;
                    objectWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Autorization", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Contact to @JEKAPRIO" + ex.Message, MessageBoxButton.OK, MessageBoxImage.Error);
            }
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

        private void CreateAccount_Click(object sender, RoutedEventArgs e)
        {
            CreateUserWindow createUserWindow = new CreateUserWindow();
            createUserWindow.ShowDialog();

            User newUser = createUserWindow.CreatedUser;

            if (newUser != null)
            {
                string jsonFilePath = "Properties/users.json";
                List<User> users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(jsonFilePath));

                try
                {
                    if (users.Any(u => u.Username == newUser.Username))
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.", "Registration", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        users.Add(newUser);

                        File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(users));

                        MessageBox.Show("Account created successfully.", "Registration", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, contact to @JEKARPIO", "Information" + ex.Message, MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }

}

