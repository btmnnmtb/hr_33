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
using hr_33.pr1poCCCCDataSetTableAdapters;

namespace hr_33
{
    /// <summary>
    /// Логика взаимодействия для second.xaml
    /// </summary>
    
    public partial class second : Window
    {
        table_222TableAdapter table_111Adapter = new table_222TableAdapter();   

        public second()
        {
            InitializeComponent();
            table_2.ItemsSource = table_111Adapter.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            table_2.ItemsSource = table_111Adapter.SearchByName(Poi.Text);   
            
            

        }
    }
}