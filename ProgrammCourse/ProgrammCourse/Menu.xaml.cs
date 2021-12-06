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
using System.Windows.Shapes;

namespace ProgrammCourse
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        private User users;
        public Menu(User users)
        {
            InitializeComponent();
            this.users = users;
            UserLabelFIO.Content = users.name + " " + users.surname + " " + users.patronymic;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow maimw = new MainWindow();
            maimw.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //clientlist
        {
            ClientsList clw = new ClientsList(users);
            clw.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //contractlist
        {
            ContractWindowList cwl = new ContractWindowList(users);
            cwl.Show();
            Close();
        }
    }
}
