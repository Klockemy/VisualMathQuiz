using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VisualMathQuiz
{
    /// <summary>
    /// Interaction logic for Multiplication.xaml
    /// </summary>
    public partial class Multiplication : Window
    {
        public static int multFactor = 0;

        public Multiplication()
        {
            InitializeComponent();
            MainWindow.correct = 0;
            MainWindow.incorrect = 0;
        }

        private void menuClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menuAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Another C# programming project by\nKevin Lockemy, July 2013\nCopyright 2013, KLockemy Computers");
        }

        private void btnMultTest_Click(object sender, RoutedEventArgs e)
        {
            multFactor = Convert.ToInt32(cmbMultFactor.SelectionBoxItem);
            try
            {
                MainWindow.numberQuestions = Convert.ToInt32(txtbMultNum.Text);
                MultTest newMultTest = new MultTest();
                newMultTest.ShowDialog();
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please use only numbers.");
            }

            
        }

        private void txtbMultNum_MouseEnter(object sender, MouseEventArgs e)
        {
            txtbMultNum.Text = null;
        }
    }
}
