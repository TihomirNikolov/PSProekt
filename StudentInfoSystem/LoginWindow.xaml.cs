using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UserLogin;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public User User { get; set; }

        public delegate void Login(User user);

        private Login login;
        public LoginWindow(Login login)
        {
            this.login = login;
            User = new User();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User.Username = Username.Text;
            User.Password = Username.Text;

            LoginValidation loginValidation = new LoginValidation(User.Username, User.Password, UserLogin.Program.Message);
            User validatedUser;
            if (loginValidation.ValidateUserInput(out validatedUser))
            {
                login?.Invoke(validatedUser);
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid data");
            }

        }
    }
}
