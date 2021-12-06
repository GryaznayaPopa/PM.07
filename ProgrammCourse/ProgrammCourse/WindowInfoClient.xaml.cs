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
    /// Логика взаимодействия для WindowInfoClient.xaml
    /// </summary>
    public partial class WindowInfoClient : Window
    {
        private int код;
        public WindowInfoClient(object tag)
        {
            InitializeComponent();
            код = (int)tag;
            var result = BDEnt.GetContext().Client.Where(p => p.id_client == код);
            labelName.Content = result.First().name;
            LabIdClient.Content = tag.ToString();
            labelSurname.Content = result.First().surname;
            labelPatronymic.Content = result.First().patronymic;
            labelCompanyname.Content = result.First().company_name;
            labelphonenumb.Content = result.First().phone_number;
            labelEmail.Content = result.First().email;
            if (!String.IsNullOrEmpty(result.First().image))
            {
                try
                {
                    ImageClient.Source = new BitmapImage(new Uri(System.IO.Path.GetFullPath($"imageClient/{result.First().image}")));
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CloseButtoneClientInfo_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
