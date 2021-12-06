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
using System.IO;

namespace ProgrammCourse
{
    /// <summary>
    /// Логика взаимодействия для ClientsList.xaml
    /// </summary>
    public partial class ClientsList : Window
    {
        private User users;
        public ClientsList(User users)
        {
            InitializeComponent();
            this.users = users;
            labelNFP.Content = users.name + " " + users.surname  + " " + users.patronymic;
            BDListClient();
            if (!String.IsNullOrEmpty(users.image))
            {
                try
                {
                    ImageUser.Source = new BitmapImage(new Uri(System.IO.Path.GetFullPath($"image/{users.image}")));
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Label label = sender as Label;
            WindowInfoClient WindowIC = new WindowInfoClient(label.Tag);
            WindowIC.Owner = this;
            WindowIC.Show();
        }
        private void BDListClient()
        {
            var masClient = from Client in BDEnt.GetContext().Client
                            select new
                            {
                                InforC = Client.id_client,
                                Name = Client.name,
                                Surname = Client.surname,
                                Patronymic = Client.patronymic,
                                NameCompany = Client.company_name,
                                PhoneNumber = Client.phone_number,
                                Email = Client.email
                            };
            DataGridClient.ItemsSource = masClient.ToList();
        }

        private void ButtonAddClientW_Click(object sender, RoutedEventArgs e)
        {
            ClientRegWindow crw = new ClientRegWindow();
            crw.Show();
        }

        private void ButtonListExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonListBack_Click(object sender, RoutedEventArgs e)
        {
            Menu bmenu = new Menu(users);
            bmenu.Show();
            Close();
        }
    }
}
