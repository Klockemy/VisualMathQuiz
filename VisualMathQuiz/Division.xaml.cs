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
    /// Interaction logic for Division.xaml
    /// </summary>
    public partial class Division : Window
    {
        public static int divFactor = 0;

        public Division()
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

        private void btnDivTest_Click(object sender, RoutedEventArgs e)
        {
            divFactor = Convert.ToInt32(cmbDivFactor.SelectionBoxItem);
            try
            {
                MainWindow.numberQuestions = Convert.ToInt32(txtbDivNum.Text);
                DivTest newDivTest = new DivTest();
                newDivTest.ShowDialog();
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please use only numbers.");
            } // end catch
        }

        private void txtbDivNum_MouseEnter(object sender, MouseEventArgs e)
        {
            txtbDivNum.Text = null;
        }
    }
}
