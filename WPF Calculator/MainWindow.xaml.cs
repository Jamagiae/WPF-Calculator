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

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double mathNumber1;
        double mathNumber2;
        double mathFinalAnswer;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            mathNumber1 = double.Parse(number1.Text);
            mathNumber2 = double.Parse(number2.Text);
            mathFinalAnswer = mathNumber1 + mathNumber2;

            answer.Text = Convert.ToString(mathFinalAnswer);

        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            mathNumber1 = double.Parse(number1.Text);
            mathNumber2 = double.Parse(number2.Text);
            mathFinalAnswer = mathNumber1 - mathNumber2;

            answer.Text = Convert.ToString(mathFinalAnswer);
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            mathNumber1 = double.Parse(number1.Text);
            mathNumber2 = double.Parse(number2.Text);
            mathFinalAnswer = mathNumber1 * mathNumber2;

            answer.Text = Convert.ToString(mathFinalAnswer);
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            mathNumber1 = double.Parse(number1.Text);
            mathNumber2 = double.Parse(number2.Text);
            mathFinalAnswer = mathNumber1 / mathNumber2;

            answer.Text = Convert.ToString(mathFinalAnswer);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            number1.Text = "";
            number2.Text = "";
            answer.Text = "";
        }
    }
}
