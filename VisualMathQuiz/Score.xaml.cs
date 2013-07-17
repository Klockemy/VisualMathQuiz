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
    /// Interaction logic for Score.xaml
    /// </summary>
    public partial class Score : Window
    {
        public Score()
        {
            InitializeComponent();

            double score = 0.0;
            double dCorrect = 0.0;
            double dIncorrect = 0.0;
            double dNumber = 0.0;

            dNumber = Convert.ToDouble(MainWindow.numberQuestions);
            dCorrect = Convert.ToDouble(MainWindow.correct);
            dIncorrect = Convert.ToDouble(MainWindow.incorrect);

            score = (dCorrect / dNumber) * 100;
            lblNumScore.Content = (int)score + "%";
            lblNumCorAns.Content = Convert.ToString(MainWindow.correct);
            lblNumIncCor.Content = Convert.ToString(MainWindow.incorrect);

            if ((int)score == 100)
            {
                lblComment.Content = "Great Job!  You aced it!";
            }
            else if ((int)score >= 80)
            {
                lblComment.Content = "Good Work. Try for 100%!";
            } else if ((int)score >= 60) {
                lblComment.Content = "Be careful, you barely passed.";
            } else {
                lblComment.Content = "You really need to study up.";
            } // end if loop
        }

        private void menuAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Another C# programming project by\nKevin Lockemy, July 2013\nCopyright 2013, KLockemy Computers");
        }

        private void menuClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.numberQuestions = 0;
            MainWindow.i = 0;
        }
    }
}
