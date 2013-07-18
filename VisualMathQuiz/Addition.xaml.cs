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
    /// Interaction logic for Addition.xaml
    /// </summary>
    public partial class Addition : Window
    {
        
        public static int addFactor;

        public Addition()
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
            txtbNumAdd.Text = null;
        }

        private void btnAddTest_Click(object sender, RoutedEventArgs e)
        {
                try
                {
                    MainWindow.numberQuestions = Convert.ToInt32(txtbNumAdd.Text);
                    if ((string)cmbAddBigProblems.SelectionBoxItem == "Ones")
                    {
                        addFactor = 10;
                    }
                    else if ((string)cmbAddBigProblems.SelectionBoxItem == "Tens")
                    {
                        addFactor = 100;
                    }
                    else if ((string)cmbAddBigProblems.SelectionBoxItem == "Hundreds")
                    {
                        addFactor = 1000;
                    } // end if
                    this.Close();
                    var newAddTest = new AddTest();
                    newAddTest.Show();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please use only numbers.");
                } // end catch
        }

    }
}
