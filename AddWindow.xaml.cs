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

namespace MED_MASKI
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        NamordnikEntities context;
        public AddWindow(NamordnikEntities context, Product currentProduct)
        {
            InitializeComponent();
            this.context = context;
            CmbProductTypeID.ItemsSource = context.Product.ToList();

            this.DataContext = currentProduct;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
