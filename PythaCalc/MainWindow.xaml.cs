using System;
using System.Windows;

//---------------------------------------------------
namespace PythaCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    // Hello there! If you can read this, then you have enough time on your hands to be looking at some very stupid and simple code.
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // This part is pretty essential.
            InitializeComponent();
        }

        // This happens when the Find Out button is clicked.
        private void findOutButton_Click(object sender, RoutedEventArgs e)
        {
            // Just making sure no blanks are left.
            if ((findOutBox1.Text == "") || (findOutBox2.Text == "") || (findOutBox3.Text == ""))
                MessageBox.Show("Please enter all required fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            // We get dirty here and start calculating. By the way, the actual calculations happen in ~/PythaCalc/Classses/Functions.cs
            // by the way, the 3 s's in "Classses" was a mistake.
            else
            {
                // Some magic happening over here. Converting string values in the text boxes into doubles and using them as arguments
                // for the findOut method.
                if (Functions.findOut(Convert.ToDouble(findOutBox1.Text),
                    Convert.ToDouble(findOutBox2.Text),
                    Convert.ToDouble(findOutBox3.Text)))
                {
                    // If the findOut method returns "true", this happens.
                    MessageBox.Show("The triangle is right.", "Result", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                // If the findOut method returns "false", this happens.
                else MessageBox.Show("The triangle is not right.", "Result", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        // This happens when the Find Hypotenuse button is clicked.
        private void hypoButton_Click(object sender, RoutedEventArgs e)
        {
            // Making sure no blanks are left.
            if ((hypoBox1.Text == "") || (hypoBox2.Text == "")) MessageBox.Show("Please enter all required fields.", "Error",
                                                                                MessageBoxButton.OK, MessageBoxImage.Error);
            // We start converting textbox strings to doubles and using them as arguments.
            else
            {
                // There's no error handling here yet. But I should put some. As the application will crash if you put in a letter instead of a character.
                MessageBox.Show("Result is: " + Convert.ToString(Functions.findHypo(Convert.ToDouble(hypoBox1.Text), Convert.ToDouble(hypoBox2.Text))),
                    "Result", MessageBoxButton.OK, MessageBoxImage.Information);                 
            }
        }

        // This happens when the Find Side button is clicked.
        private void sideButton_Click(object sender, RoutedEventArgs e)
        {
            // Making sure no blanks are left.
            if ((sideBox1.Text == "") || (sideBox2.Text == "")) MessageBox.Show("Please enter all required fields.", "Error",
                                                                                MessageBoxButton.OK, MessageBoxImage.Error);
            // Getting dirty with the converting and arguing.
            else
            {
                // This happens when two sides are the same. I don't know if two sides can have the same length in a right triangle
                // so I don't know what to do exactly. I used a negative value because it's impossible to have a length with a negative value.
                if (Functions.findSide(Convert.ToDouble(sideBox1.Text), Convert.ToDouble(sideBox2.Text)) < 0)
                {
                    MessageBox.Show("There's something wrong, it will probably be fixed soon.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                // This is obvious.
                else
                {
                    MessageBox.Show("Result is: " + Convert.ToString(Functions.findSide(Convert.ToDouble(sideBox1.Text), Convert.ToDouble(sideBox2.Text))), "Result",
                                     MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }       
    }
}
