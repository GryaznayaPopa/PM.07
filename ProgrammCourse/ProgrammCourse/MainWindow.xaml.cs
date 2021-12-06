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

namespace ProgrammCourse
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(loginBox.Text))
            {
                if(!String.IsNullOrEmpty(PassBox.Text))
                {
                    IQueryable<User> users = BDEnt.GetContext().User.Where(p => p.login == loginBox.Text && p.password == PassBox.Text );
                    if (users.Count() == 1)
                    {
                        MessageBox.Show($"Добро пожаловать, {users.First().name} {users.First().surname}");
                        Menu menus = new Menu(users.First());
                        menus.Show();
                        Close();
                    }
                    else MessageBox.Show("Неверный логин или пароль");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
