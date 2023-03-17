using SPP.fppDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SPP
{
    /// <summary>
    /// Логика взаимодействия для SP.xaml
    /// </summary>
    public partial class SP : Page
    {
        chatsTableAdapter chats = new chatsTableAdapter();
        usersTableAdapter users = new usersTableAdapter();
        public SP()
        {
            InitializeComponent();
            ChatsGrid.ItemsSource = chats.GetData();
            FU.ItemsSource = users.GetData();
            FU.DisplayMemberPath = "id";
            SU.ItemsSource = users.GetData();
            SU.DisplayMemberPath = "id";
        }

        private void ChangeBtn1_Click(object sender, RoutedEventArgs e)
        {
            if (FU.SelectedIndex != -1 && SU.SelectedIndex != -1)
            {
                var idNew = chats.GetData();
                int fUser = users.GetData()[FU.SelectedIndex].id;

                int sUser = users.GetData()[SU.SelectedIndex].id;
                Debug.WriteLine(SU.SelectedIndex);
                chats.InsertQuery(idNew[idNew.Count - 1].id + 1, fUser, sUser);
                ChatsGrid.ItemsSource = chats.GetData();
            }

        }
    }
}
