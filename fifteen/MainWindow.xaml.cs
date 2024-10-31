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

namespace fifteen
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ConversionType_Checked(object sender, RoutedEventArgs e)
        {
            if (sender == CtoFCheckbox)
                FtoCCheckbox.IsChecked = false;
            else if (sender == FtoCCheckbox)
                CtoFCheckbox.IsChecked = false;
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double input = double.Parse(otvet.Text);
                double rewenie;

                if (CtoFCheckbox.IsChecked == true)
                {
                    rewenie = (input * 9 / 5) + 32;
                    ot.Text = $"Результат: {rewenie:F2} °F";
                }
                else if (FtoCCheckbox.IsChecked == true)
                {
                    rewenie = (input - 32) * 5 / 9;
                    ot.Text = $"Результат: {rewenie:F2} °C";
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите тип конверсии");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректное значение температуры");
            }
        }
    }
}