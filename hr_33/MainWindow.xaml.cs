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

namespace hr_33
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
       
    public partial class MainWindow : Window
    {
        private pr1poCCCCEntities table = new pr1poCCCCEntities(); 
        public MainWindow()
        {

            InitializeComponent();
            table_1.ItemsSource = table.table_222.ToList();
            ttt.ItemsSource = table.table_111.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            table_1.ItemsSource = table.table_222.ToList().Where(item => Convert.ToString(item.car_god_proizvod).Contains(Poisk.Text));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            table_1.ItemsSource = table.table_222.ToList();

        }

        private void ttt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ttt.SelectedItem != null)
            {
                var seleceted = ttt.SelectedItem as table_111;
                table_1.ItemsSource = table.table_222.ToList().Where(item => item.table_111 == seleceted);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            second sec = new second(); 
            sec.Show();
            Close();
        }

        private void table_1_SelectionChanged()
        {

        }
    }
}