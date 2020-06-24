using AISDoeduSam.model;
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

namespace AISDoeduSam
{
    /// <summary>
    /// Логика взаимодействия для MainActivity.xaml
    /// </summary>
    public partial class MainActivity : Page
    {
        public MainActivity()
        {
            InitializeComponent();
            var context = new DBDoeduSamEntities();
            foreach (product prod in context.product)
            {
                MainPanel.Children.Add(new Item(prod.Name, Convert.ToString(prod.Price)));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
