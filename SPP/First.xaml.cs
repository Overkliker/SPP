using SPP.fppDataSetTableAdapters;
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

namespace SPP
{
    /// <summary>
    /// Логика взаимодействия для First.xaml
    /// </summary>
    public partial class First : Page
    {
        usersTableAdapter users = new usersTableAdapter();
        public First()
        {
            InitializeComponent();
            UsersGrid.ItemsSource = users.GetData();
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            var data = users.GetData();
            users.InsertQuery(data[data.Count - 1].id + 1, NewText.Text, $"{NewText.Text}@mail.com");
            UsersGrid.ItemsSource = users.GetData();
        }
    }
}
