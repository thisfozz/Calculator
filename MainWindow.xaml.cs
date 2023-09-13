using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string currentOperation = "";
        private double firstNumber = 0;
        private double currentNumber = 0;
        private bool isAdding = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            string buttonText = ((Button)sender).Content.ToString();
            if (Result.Text == "0" || isAdding)
            {
                Result.Text = buttonText;
                isAdding = false;
            }
            else
            {
                Result.Text += buttonText;
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Result.Text, out double currentNumber))
            {
                firstNumber = currentNumber;
                isAdding = true;
                currentOperation = "plus";
            }
        }

        private void Muliply_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Result.Text, out double currentNumber))
            {
                firstNumber = currentNumber;
                isAdding = true;
                currentOperation = "multiply";
            }
        }

        private void Degree_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Result.Text, out double currentNumber))
            {
                firstNumber = currentNumber;
                isAdding = true;
                currentOperation = "degree";
            }
        }


        private void Substruct_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Result.Text, out double currentNumber))
            {
                firstNumber = currentNumber;
                isAdding = true;
                currentOperation = "substruct";
            }
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Result.Text, out double currentNumber))
            {
                double result = 0;

                if (currentOperation == "plus")
                {
                    result = firstNumber + currentNumber;
                }
                else if (currentOperation == "multiply")
                {
                    result = firstNumber * currentNumber;
                }
                else if (currentOperation == "degree")
                {
                    if (currentNumber != 0)
                    {
                        result = firstNumber / currentNumber;
                    }
                    else
                    {
                        result = 0;
                    }
                }
                else if(currentOperation == "substruct")
                {
                    result = firstNumber - currentNumber;
                }

                Result.Text = result.ToString();
                isAdding = false;
            }
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = "";
        }
    }
}
