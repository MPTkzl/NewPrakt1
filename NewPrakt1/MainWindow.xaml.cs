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
using NewPrakt1.qqqDataSetTableAdapters;

namespace NewPrakt1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        usersTableAdapter users = new usersTableAdapter();
        zakaziTableAdapter zakazi = new zakaziTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
            Users.ItemsSource = users.GetData();
            Combo.ItemsSource = zakazi.GetData();
            Combo.DisplayMemberPath = "kolvo";
        }

        private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (Combo.SelectedItem as DataRowView).Row[0];
            MessageBox.Show(cell.ToString());
        }
    }
}
