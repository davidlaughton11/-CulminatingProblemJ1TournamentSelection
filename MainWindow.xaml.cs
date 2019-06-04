/*David Laughton
 * June 4th 2019
 * J1 problem
 */

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

namespace CulminatingProblemJ1TournamentSelection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int score;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (OneInput.Text == "W")
            {
                score++;
            }
            if (TwoInput.Text == "W")
            {
                score++;
            }
            if (ThreeInput.Text == "W")
            {
                score++;
            }
            if (FourInput.Text == "W")
            {
                score++;
            }
            if (FiveInput.Text == "W")
            {
                score++;
            }
            if (SixInput.Text == "W")
            {
                score++;
            }
            if (score >= 5)
            {
                lblOutput.Content = "1";
            }
            if (score == 3 || score == 4)
            {
                lblOutput.Content = "2";
            }
            if (score == 2 || score == 1)
            {
                lblOutput.Content = "3";
            }
            if (score < 1)
            {
                lblOutput.Content = "-1";
            }
        }
    }
}
