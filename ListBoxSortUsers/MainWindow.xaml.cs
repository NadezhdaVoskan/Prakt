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

namespace ListBoxSortUsers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> list = new List<int>(); 
        public MainWindow()
        {
            InitializeComponent();
            tbNumber.PreviewTextInput += new TextCompositionEventHandler(tbNumber_PreviewTextInput);
           
        }

        private void btSort_Click(object sender, RoutedEventArgs e)
        {
            lbNumber.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void btAddNumber_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                list.Add(int.Parse(tbNumber.Text));
                lbNumber.ItemsSource = list;
                lbNumber.Items.Refresh();
                tbNumber.Clear();
            }
            catch { MessageBox.Show("Введите число!"); }
        }

        private void tbNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) { e.Handled = true; }
        }
    }
}
