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

namespace Calculator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int first = int.Parse(txbFirstNumber.Text);
            int second = int.Parse(SecondNumber.Text);
            lblSumResult.Content = first + " + " + second + " = " + (first + second);
        }

        private void Button_Click_Sub(object sender, RoutedEventArgs e)
        {
            int first = int.Parse(txbFirstNumber.Text);
            int second = int.Parse(SecondNumber.Text);
            lblSubResult.Content = first + " - " + second + " = " + (first - second);
        }
        private void Button_Click_Mul(object sender, RoutedEventArgs e)
        {
            int first = int.Parse(txbFirstNumber.Text);
            int second = int.Parse(SecondNumber.Text);
            lblMulResult.Content = first + " * " + second + " = " + (first * second);
        }
        private void Button_Click_Div(object sender, RoutedEventArgs e)
        {
            int first = int.Parse(txbFirstNumber.Text);
            int second = int.Parse(SecondNumber.Text);
            lblDivResult.Content = first + " / " + second + " = " + (first / second);
        }

    }
}
