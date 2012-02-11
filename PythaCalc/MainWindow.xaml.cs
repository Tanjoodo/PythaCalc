using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PythaCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void findOutButton_Click(object sender, RoutedEventArgs e)
        {
            if ((findOutBox1.Text == "") || (findOutBox2.Text == "") || (findOutBox3.Text == ""))
                MessageBox.Show("Please enter all required fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            else
            {
                if (Functions.findOut(Convert.ToDouble(findOutBox1.Text),
                    Convert.ToDouble(findOutBox2.Text),
                    Convert.ToDouble(findOutBox3.Text)))
                {
                    MessageBox.Show("The triangle is a right one", "Result", MessageBoxButton.OK, MessageBoxImage.Information);
                   
                }
            }
        }

        private void hypoButton_Click(object sender, RoutedEventArgs e)
        {
            if ((hypoBox1.Text == "") || (hypoBox2.Text == "")) MessageBox.Show("Please enter all required fields.", "Error",
                                                                                MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                MessageBox.Show("Result is: " + Convert.ToString(Functions.findHypo(Convert.ToDouble(hypoBox1.Text), Convert.ToDouble(hypoBox2.Text))),
                    "Result", MessageBoxButton.OK, MessageBoxImage.Information);                 
            }
        }

        private void sideButton_Click(object sender, RoutedEventArgs e)
        {

            if ((sideBox1.Text == "") || (sideBox2.Text == "")) MessageBox.Show("Please enter all required fields.", "Error",
                                                                                MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                if (Functions.findSide(Convert.ToDouble(sideBox1.Text), Convert.ToDouble(sideBox2.Text)) < 0)
                {
                    MessageBox.Show("There's something wrong, it will probably be fixed soon.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show("Result is: " + Convert.ToString(Functions.findSide(Convert.ToDouble(sideBox1.Text), Convert.ToDouble(sideBox2.Text))), "Result",
                                     MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
                

        }

     

       

     

        
    }
}
