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
    /// Interaction logic for MultTest.xaml
    /// </summary>
    public partial class MultTest : Window
    {
        public int multNumber1;
        public int multNumber2;
        public double multNewRand1;
        public double multNewRand2;
        public double multNewAns;
        public string multNewRand1String;
        public string multNewRand2String;

        Random addRandom = new Random();

        public MultTest()
        {
            InitializeComponent();
            MainWindow.i = 1;
            MultNew();

        }

        public void AddCheck()
        {
                if (Convert.ToInt32(txtbMultAnswer.Text) == multNewRand1 * Multiplication.multFactor){
                    MainWindow.correct++;
                    MessageBox.Show("Correct!");
                } else if (Convert.ToInt32(txtbMultAnswer.Text) != multNewRand1 * Multiplication.multFactor){
                    MainWindow.incorrect++;
                    MessageBox.Show("Sorry, That's Incorrect!");
                } // end if loop
                MainWindow.i++;
                if (MainWindow.i == (MainWindow.numberQuestions)+1){
                    btnMultFinish.IsEnabled = true;
                    btnMultNext.IsEnabled = false;
                    lblMultNum1 = null;
                    lblMultNum2 = null;
            }
        }

        public void MultNew()
        {
            lblMultQuesNum.Content = MainWindow.i;
            multNewRand1 = (int)(addRandom.NextDouble() * 12) + 1;
            multNewRand2 = (int)(addRandom.NextDouble() * Multiplication.multFactor) + 1;
            lblMultNum1.Content = multNewRand1;
            lblMultNum2.Content = Multiplication.multFactor;
            
        }

        private void menuClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menuAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Another C# programming project by\nKevin Lockemy, July 2013\nCopyright 2013, KLockemy Computers");
        }

        private void txtbMultAnswer_MouseEnter(object sender, MouseEventArgs e)
        {
            txtbMultAnswer.Text = null;
        }

        private void btnMultNext_Click(object sender, RoutedEventArgs e)
        {
            AddCheck();
            if (MainWindow.i != (MainWindow.numberQuestions) + 1)
            {
                MultNew();
            }
        }

        private void btnMultFinish_Click(object sender, RoutedEventArgs e)
        {
            Score frmScore = new Score();
            this.Close();
            frmScore.Show();
        }
    }
}
