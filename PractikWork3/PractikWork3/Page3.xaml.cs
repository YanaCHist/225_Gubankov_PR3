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

namespace PractikWork3
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            AnswerTextBox.Clear();

            double a, b, c;
            double? s = null;

            if (String.IsNullOrEmpty(NumberATextBox.Text) || String.IsNullOrEmpty(NumberBTextBox.Text) || String.IsNullOrEmpty(NumberCTextBox.Text))
            {
                return;
            }

            if (!double.TryParse(NumberATextBox.Text, out a))
            {
                AnswerTextBox.Text += "Введены не корректные данные\n";
            }

            if (!double.TryParse(NumberBTextBox.Text, out b))
            {
                AnswerTextBox.Text += "Введены не корректные данные\n";
            }

            if (!double.TryParse(NumberCTextBox.Text, out c))
            {
                AnswerTextBox.Text += "Введены не корректные данные\n";
            }

            if(a > b && a > c)
            {
                if(b > c)
                {
                    s = a + b;
                }
                else
                {
                    s = a + c;
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    s = a + b;
                }
                else
                {
                    s = b + c;
                }
            }
            else if (c > b && c > a)
            {
                if (b > a)
                {
                    s = c + b;
                }
                else
                {
                    s = a + c;
                }
            }
            AnswerTextBox.Text += s;
        }
    }
}
