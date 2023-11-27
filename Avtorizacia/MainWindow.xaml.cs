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
using System.Xml.Linq;

namespace Avtorizacia
{

    public partial class MainWindow : Window
    {
        List<User> users;
        public MainWindow()
        {
            InitializeComponent();
            users = new List<User>();
            users.Add(new User("Kostya", "admin", "123456", "M"));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string login = txtLogin.Text;
            string password = txtPassword.Password;

            foreach (User user in users)
            {


                if (login == user.login && password == user.password)
                {
                    MessageBox.Show("Вход выполнен успешно");
                }
                else
                {
                    Exaption.Text = "Неверный логин или пароль";
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string name = "";
            string email = "";
            string gender = "";
            string password = "";
            string confirmPassword = "";

            if (txtName.Text == "")
            {
                MessageBox.Show("Введите имя");
            }
            else
            {
                name = txtName.Text;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Введите email");
            }
            else
            {
                email = txtEmail.Text;
            }

            if (cmbGender.Name == "")
            {
                MessageBox.Show("Выберите пол");
            }
            else
            {
                gender = cmbGender.Name;
            }

            if (txtRegPassword.Password == "")
            {
                MessageBox.Show("Введите пароль");
            }
            else
            {
                password = txtRegPassword.Password;
            }




            if (txtRegPasswordConfirm.Password == "")
            {
                MessageBox.Show("Введите пароль повторно");
            }
            else
            {
                confirmPassword = txtRegPasswordConfirm.Password;

            }

            if (password != "" && confirmPassword != "")
            {
                if (password == confirmPassword)
                {
                    password = confirmPassword;
                }
                else
                {
                    MessageBox.Show("Повтор пароля");
                }
            }


            if (M.IsChecked == true)
            {
                gender = "M";
            }
            if (G.IsChecked == true)
            {
                gender = "G";
            }

            if (name != "" && email != "" && gender != "" && password != "" && confirmPassword != "")
            {
                users.Add(new User(name, email, password, gender));
                MessageBox.Show("Регистрация прошла успешна");
            }
        }
    }
}
