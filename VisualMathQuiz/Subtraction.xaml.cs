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
using System.Windows.Shapes;

namespace VisualMathQuiz
{
    /// <summary>
    /// Interaction logic for Subtraction.xaml
    /// </summary>
    public partial class Subtraction : Window
    {
        public static int subFactor;

        public Subtraction()
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

        private void txtbNumAdd_MouseEnter(object sender, MouseEventArgs e)
        {
            txtbNumSub.Text = null;
        }

        private void cmbAddBigProblems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAddTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow.numberQuestions = Convert.ToInt32(txtbNumSub.Text);
                if ((string)cmbSubBigProblems.SelectionBoxItem == "Ones")
                {
                    subFactor = 10;
                }
                else if ((string)cmbSubBigProblems.SelectionBoxItem == "Tens")
                {
                    subFactor = 100;
                }
                else if ((string)cmbSubBigProblems.SelectionBoxItem == "Hundreds")
                {
                    subFactor = 1000;
                } // end if
                this.Close();
                SubTest newSubTest = new SubTest();
                newSubTest.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please use only numbers.");
            } // end catch
        }
    }
}
