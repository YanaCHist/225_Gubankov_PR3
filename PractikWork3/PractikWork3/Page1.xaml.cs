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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            AnswerTextBox.Clear();
            int n, first, last;

            if (String.IsNullOrEmpty(NumberTextBox.Text))
            {
                return;
            }
            try
            {
                n = int.Parse(NumberTextBox.Text);
                if(n >= 10 && n <= 99)
                {
                    first = n / 10;
                    last = n % 10;
                    if(first == last)
                    {
                        AnswerTextBox.Text += "Да";
                    }
                    else
                    {
                        AnswerTextBox.Text += "Нет";
                    }
                }
                else
                {
                    AnswerTextBox.Text += "Введите двузначное число";
                }
            }
            catch (FormatException)
            {
                AnswerTextBox.Text += "Введены не корректные данные";
            }
        }
    }
}
