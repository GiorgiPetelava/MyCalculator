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

namespace MyCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Double FirstNumber;
        Double SecondNumber;
        Double Result;
        string Operation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            StringBuilder inputTextString = new StringBuilder(inputText.Text);

            if (!inputTextString[0].Equals('0'))
            {
                inputTextString.Append(btn.Content.ToString());
                inputText.Text = inputTextString.ToString();
            }
            else
            {
                inputTextString.Clear();
                inputTextString.Append(btn.Content.ToString());
                inputText.Text = inputTextString.ToString();
            }
        }

        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            inputText.Text = "0";
        }
        private void Button_Click_Sub(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(inputText.Text);
            inputText.Text = "0";
            Operation = "-";
        }
        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(inputText.Text);
            inputText.Text = "0";
            Operation = "+";
        }
        private void Button_Click_Div(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(inputText.Text);
            inputText.Text = "0";
            Operation = "/";
        }
        private void Button_Click_Mult(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(inputText.Text);
            inputText.Text = "0";
            Operation = "*";
        }
        private void Button_Click_Perc(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(inputText.Text);
            inputText.Text = "0";
            Operation = "%";
        }
        private void Button_Click_Eqv(object sender, RoutedEventArgs e)
        {

                SecondNumber = Convert.ToDouble(inputText.Text);

                if (Operation == "+")
                {
                    Result = (FirstNumber + SecondNumber);
                    inputText.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "-")
                {
                    Result = (FirstNumber - SecondNumber);
                    inputText.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "*")
                {
                    Result = (FirstNumber * SecondNumber);
                    inputText.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    inputText.Text = "Cannot divide by zero";
                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    inputText.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            if (Operation == "%")
            {
                Result = (FirstNumber * FirstNumber / 100);
                inputText.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

        }
        private void Button_Click_Bks(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
