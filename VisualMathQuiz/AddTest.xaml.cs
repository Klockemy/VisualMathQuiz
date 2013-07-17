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
    /// Interaction logic for AddTest.xaml
    /// </summary>
    public partial class AddTest : Window
    {
        public int addNumber1;
        public int addNumber2;
        public double addNewRand1;
        public double addNewRand2;
        public double addNewAns;
        public string addNewRand1String;
        public string addNewRand2String;

        Random addRandom = new Random();

        public AddTest()
        {
            InitializeComponent();
            MainWindow.i = 1;
            AddNew();

        }

        public void AddCheck()
        {
                if (Convert.ToInt32(txtbAddAnswer.Text) == addNewRand1 + addNewRand2){
                    MainWindow.correct++;
                    MessageBox.Show("Correct!");
                } else if (Convert.ToInt32(txtbAddAnswer.Text) != addNewRand1 + addNewRand2){
                    MainWindow.incorrect++;
                    MessageBox.Show("Sorry, That's Incorrect!");
                } // end if loop
                MainWindow.i++;
                if (MainWindow.i == (MainWindow.numberQuestions)+1){
                    btnAddFinish.IsEnabled = true;
                    btnAddNext.IsEnabled = false;
                    lblAddNum1 = null;
                    lblAddNum2 = null;
            }
        }

        public void AddNew()
        {
            lblAddQuesNum.Content = MainWindow.i;
            addNewRand1 = (int)(addRandom.NextDouble() * Addition.addFactor) + 1;
            addNewRand2 = (int)(addRandom.NextDouble() * Addition.addFactor) + 1;
            lblAddNum1.Content = addNewRand1;
            lblAddNum2.Content = addNewRand2;
            
        }

        private void menuAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Another C# programming project by\nKevin Lockemy, July 2013\nCopyright 2013, KLockemy Computers");
        }

        private void menuClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddNext_Click(object sender, RoutedEventArgs e)
        {
            AddCheck();
            if (MainWindow.i != (MainWindow.numberQuestions)+1)
            {
                AddNew();
            }
        }

        private void txtbAddAnswer_MouseEnter(object sender, MouseEventArgs e)
        {
            txtbAddAnswer.Text = null;
        }

        private void btnAddFinish_Click(object sender, RoutedEventArgs e)
        {
            Score frmScore = new Score();
            this.Close();
            frmScore.Show();
        }
    }
}
