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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            AnswerTextBox.Clear();

            int a, b, c, count_minus = 0, count_plus = 0;

            if (String.IsNullOrEmpty(NumberATextBox.Text) || String.IsNullOrEmpty(NumberBTextBox.Text) || String.IsNullOrEmpty(NumberCTextBox.Text))
            {
                return;
            }

            if (!int.TryParse(NumberATextBox.Text, out a))
            {
                AnswerTextBox.Text += "Введены не корректные данные\n";
            }

            if (!int.TryParse(NumberBTextBox.Text, out b))
            {
                AnswerTextBox.Text += "Введены не корректные данные\n";
            }

            if (!int.TryParse(NumberCTextBox.Text, out c))
            {
                AnswerTextBox.Text += "Введены не корректные данные\n";
            }

            if(a > 0)
            {
                count_plus++;
            }
            else
            {
                count_minus++;
            }
            if (b > 0)
            {
                count_plus++;
            }
            else
            {
                count_minus++;
            }
            if (c > 0)
            {
                count_plus++;
            }
            else
            {
                count_minus++;
            }
            AnswerTextBox.Text += $"Положительных чисел - {count_plus}, отрицательных чисел - {count_minus}";

        }
    }
}
