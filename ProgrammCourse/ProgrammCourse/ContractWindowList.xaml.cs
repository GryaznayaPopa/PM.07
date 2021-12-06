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
    /// Логика взаимодействия для ContractWindowList.xaml
    /// </summary>
    public partial class ContractWindowList : Window
    {
        private User users;
        public ContractWindowList(User users)
        {
            InitializeComponent();
            this.users = users;
            BDContractList();
            LabelUserFIO.Content = users.name + " " + users.surname + " " + users.patronymic;

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
        private void BDContractList()
        {
            var masContract = from Contract in BDEnt.GetContext().Contract
                              join Client in BDEnt.GetContext().Client on Contract.Client equals Client
                              join Payment_status in BDEnt.GetContext().Payment_status on Contract.Payment_status equals Payment_status
                              join Contract_status in BDEnt.GetContext().Contract_status on Contract.Contract_status equals Contract_status
                              select new
                              {
                                  ContractNumber = Contract.id_contract,
                                  ClientFIO = Contract.Client.name + " " + Contract.Client.surname+ " " + Contract.Client.patronymic, 
                                  DataPrepar = Contract.date_preparation,
                                  DataExec = Contract.date_execution,
                                  PayStatus = Contract.Payment_status.name_payment_status,
                                  ContractDetails = Contract.contract_details,
                                  ContractStat = Contract.Contract_status.contract_status_name
                              };
            dataGridContract.ItemsSource = masContract.ToList();
        }
        private void ExitButtonContract_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BackMenuContrButton_Click(object sender, RoutedEventArgs e)
        {
            Menu bmenu = new Menu(users);
            bmenu.Show();
            Close();
        }
    }
}
