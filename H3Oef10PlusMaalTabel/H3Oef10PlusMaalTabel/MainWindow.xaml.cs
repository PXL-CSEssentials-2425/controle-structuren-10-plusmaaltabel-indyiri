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

namespace H3Oef10PlusMaalTabel
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

        StringBuilder sb = new StringBuilder();

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Clear();

            int row;
            int col;
            int maxValue;

            string inputMaxValue = maxValueTextBox.Text;
        
            bool isInputMaxValueValid = int.TryParse(inputMaxValue, out maxValue);

            if (isInputMaxValueValid && maxValue > 2 && maxValue <= 20)
            {

                for (row = 0; row <= maxValue; row++)
                {
                    for (col = 0; col <= maxValue; col++)
                    {
                        if (row == 0)
                        {
                            sb.Append($"{col}\t"); //Print kolomnummers in rij 0
                        }
                        else if (col == 0)
                        {
                            sb.Append($"{row}\t"); //Print rijnummers in kolom 0
                        }
                        else
                        {
                            sb.Append($"{row + col}\t");
                        }
                    }
                    sb.AppendLine();
                }

                resultTextBox.Text = sb.ToString();
            }
            else 
            {
                resultTextBox.Text = "Geef een getal tussen 2 en 20 in";
            }           
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Clear();
            
            int row;
            int col;
            int maxValue;

            string inputMaxValue = maxValueTextBox.Text;

            bool isInputMaxValueValid = int.TryParse(inputMaxValue, out maxValue);

            if (isInputMaxValueValid && maxValue > 2 && maxValue <= 20)
            {

                for (row = 0; row <= maxValue; row++)
                {
                    for (col = 0; col <= maxValue; col++)
                    {
                        if (row == 0)
                        {
                            sb.Append($"{col}\t"); //Print kolomnummers in rij 0
                        }
                        else if (col == 0)
                        {
                            sb.Append($"{row}\t"); //Print rijnummers in kolom 0
                        }
                        else
                        {
                            sb.Append($"{row * col}\t");
                        }
                    }
                    sb.AppendLine();
                }

                resultTextBox.Text = sb.ToString();
            }
            else
            {
                resultTextBox.Text = "Geef een getal tussen 2 en 20 in";
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            sb.Clear();
            maxValueTextBox.Text = "10";
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}