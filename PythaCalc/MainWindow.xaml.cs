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
                    // This is a comment
                }
            }
        }
    }
}
