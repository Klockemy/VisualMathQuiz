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

namespace VisualMathQuiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int numberQuestions;
        public static int correct = 0;
        public static int incorrect = 0;
        public static int i = 1;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void menuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menuAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Another C# programming project by\nKevin Lockemy, July 2013\nCopyright 2013, KLockemy Computers");
        }

        private void btnAddition_Click(object sender, RoutedEventArgs e)
        {
            Addition frmAdd = new Addition();
            frmAdd.ShowDialog();
        }

        private void btnSubtraction_Click(object sender, RoutedEventArgs e)
        {
            Subtraction frmSub = new Subtraction();
            frmSub.ShowDialog();
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            Multiplication frmMult = new Multiplication();
            frmMult.ShowDialog();
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            Division frmDiv = new Division();
            frmDiv.ShowDialog();
        }
    }
}
