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

namespace LoanCalculation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double temp;
            if (!double.TryParse(textBox.Text, out temp))
            {
                System.Windows.MessageBox.Show("只能输入数字", "提示");
            }
        }

        private void textBox_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            double temp;
            if (!double.TryParse(textBox.Text, out temp))
            {
                System.Windows.MessageBox.Show("只能输入数字", "提示");
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox_Copy.Text = "";
            datePickerCtl.Text = "";
            datePickerCtl_Copy.Text = "";
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
