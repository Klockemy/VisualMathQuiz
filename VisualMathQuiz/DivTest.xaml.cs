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
    /// Interaction logic for DivTest.xaml
    /// </summary>
    public partial class DivTest : Window
    {
        public int divNumber1;
        public int divNumber2;
        public double divNewRand1;
        public double divNewRand2;
        public double divNewRand3;
        public double divNewAns;
        public string divNewRand1String;
        public string divNewRand2String;

        Random divRandom = new Random();

        public DivTest()
        {
            InitializeComponent();
            MainWindow.i = 1;
            DivNew();

        }

        public void DivCheck()
        {
                if (Convert.ToInt32(txtbDivAnswer.Text) == divNewRand3 / divNewRand2){
                    MainWindow.correct++;
                    MessageBox.Show("Correct!");
                } else if (Convert.ToInt32(txtbDivAnswer.Text) != divNewRand3 / divNewRand2){
                    MainWindow.incorrect++;
                    MessageBox.Show("Sorry, That's Incorrect!");
                } // end if loop
                MainWindow.i++;
                if (MainWindow.i == (MainWindow.numberQuestions)+1){
                    btnDivFinish.IsEnabled = true;
                    btnDivNext.IsEnabled = false;
                    lblDivNum1 = null;
                    lblDivNum2 = null;
            }
        }

        public void DivNew()
        {
            lblDivQuesNum.Content = MainWindow.i;
            divNewRand1 = (int)(divRandom.NextDouble() * 12) + 1;
            divNewRand2 = (int)Division.divFactor;
            divNewRand3 = (int)divNewRand1 * (int)divNewRand2;
            lblDivNum1.Content = divNewRand3;
            lblDivNum2.Content = divNewRand2;
            
        }

        private void menuAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Another C# programming project by\nKevin Lockemy, July 2013\nCopyright 2013, KLockemy Computers");
        }

        private void menuClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnDivNext_Click(object sender, RoutedEventArgs e)
        {
            DivCheck();
            if (MainWindow.i != (MainWindow.numberQuestions)+1)
            {
                DivNew();
            }
        }

        private void txtbDivAnswer_MouseEnter(object sender, MouseEventArgs e)
        {
            txtbDivAnswer.Text = null;
        }

        private void btnDivFinish_Click(object sender, RoutedEventArgs e)
        {
            Score frmScore = new Score();
            this.Close();
            frmScore.Show();
        }
    }
}
