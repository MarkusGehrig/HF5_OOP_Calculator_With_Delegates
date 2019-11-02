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

namespace WpfApp2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        delegate double my_cal_del(double x, double y);

        public MainWindow()
        {
            InitializeComponent();
        }

        public double addition(double x, double y)
        {
            return x + y;
        }

        public double multiplication(double x, double y)
        {
            return x * y;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            my_cal_del my_del;

            //Addieren ??
            if (btnAdd.IsChecked == true)
            {
                my_del = addition;
            }
            else
            {
                my_del = multiplication;
            }

            try
            {
                double x = Convert.ToDouble(tb1.Text);
                double y = Convert.ToDouble(tb2.Text);
                tbResult.Text = my_del(x, y).ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
