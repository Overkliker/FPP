using System;
using System.Collections.Generic;
using System.Data;
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
using FPP.fppDataSetTableAdapters;

namespace FPP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        usersTableAdapter users = new usersTableAdapter();
        messagesChatTableAdapter mes = new messagesChatTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            UsersGrid.ItemsSource = users.GetData();
            UsersList.ItemsSource = mes.GetData();
            UsersList.DisplayMemberPath = "fUserID";

        }

        private void UsersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show((UsersList.SelectedItem as DataRowView).Row[3].ToString());
        }
    }
}
