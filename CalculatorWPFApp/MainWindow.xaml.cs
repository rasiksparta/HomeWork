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
using CalculatorDLL;

namespace CalculatorWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CalculatorFunction calculator;
        public MainWindow()
        {
            InitializeComponent();
            calculator = new CalculatorFunction();
        }

        double firstNumber, secondNumber;

        private void Operation_choice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                firstNumber = double.Parse(first_number.Text);
            }catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            try
            {
                secondNumber = double.Parse(second_number.Text);

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            string operation = operation_choice.Text.Trim();
            
            double result;
            switch (operation)
            {
                case "Divide":
                    result = calculator.Divide(firstNumber, secondNumber);
                    break;
                case "Multiplication":
                    result = calculator.Multiply(firstNumber, secondNumber);
                    break;
                case "Summation":
                    result = calculator.Add(firstNumber, secondNumber);
                    break;
                case "Subtraction":
                    result = calculator.Subtract(firstNumber, secondNumber);
                    break;
                default:
                    result = double.NaN;
                    break;
            }

            string resultString = result.ToString();
            
            if(resultString.Length < 14)
            {
                result_box.Text = resultString;
            }
            else
            {
                result_box.Text = result.ToString().Substring(0, 13);
            }
        }
    }
}
