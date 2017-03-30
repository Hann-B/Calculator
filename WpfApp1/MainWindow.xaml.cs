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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Standard";
        }

        private void AddButton(object sender, RoutedEventArgs e)
        {
            //After two values are entered they are added together and labeld result
            var result = int.Parse(input1.Text) + int.Parse(input2.Text);
            OutputSolution.Text = result.ToString();
        }

        private void SubtractButton(object sender, RoutedEventArgs e)
        {
            //After two values are entered they are subtracted and labeld result
            var result = int.Parse(input1.Text) - int.Parse(input2.Text);
            OutputSolution.Text = result.ToString();
        }

        private void MultiplyButton(object sender, RoutedEventArgs e)
        {
            //After two values are entered they are multiplied and labeld result
            var result = int.Parse(input1.Text) * int.Parse(input2.Text);
            OutputSolution.Text = result.ToString();
        }

        private void DivideButton(object sender, RoutedEventArgs e)
        {
            //After two values are entered they are divided and labeld result
            var result = int.Parse(input1.Text) / int.Parse(input2.Text);
            OutputSolution.Text = result.ToString();
        }

        private void ModButton(object sender, RoutedEventArgs e)
        {
            //After two values are entered they are mod and labeld result
            var result = int.Parse(input1.Text) % int.Parse(input2.Text);
            OutputSolution.Text = result.ToString();
        }
    }
}
