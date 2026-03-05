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

namespace slider_fontsize
{
    public partial class MainWindow : Window
    {

        string[] textsList = ["Dzień dobry", "Good morning", "Buenos dias"];
        int newIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
           
            MySlider.ValueChanged += MySlider_ValueChanged;
            OutputText.Content = textsList[newIndex];
            
        }

        private void MySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            OutputText.FontSize = MySlider.Value;
            SizeText.Content = "Rozmiar: " + (int)MySlider.Value;
        }

        private void NextText_Click(object sender, RoutedEventArgs e)
        {
            newIndex++;
            OutputText.Content = textsList[newIndex % textsList.Length];
        }
    }
}