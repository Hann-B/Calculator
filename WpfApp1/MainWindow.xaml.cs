using System;
using System.Collections.Generic;
using System.IO;
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
            var resultAdd = double.Parse(input1.Text) + double.Parse(input2.Text);
            OutputSolution.Text = resultAdd.ToString();
        }

        private void SubtractButton(object sender, RoutedEventArgs e)
        {
            //After two values are entered they are subtracted and labeld result
            var resultSubtract = double.Parse(input1.Text) - double.Parse(input2.Text);
            OutputSolution.Text = resultSubtract.ToString();
        }

        private void MultiplyButton(object sender, RoutedEventArgs e)
        {
            //After two values are entered they are multiplied and labeld result
            var resultMultiply = double.Parse(input1.Text) * double.Parse(input2.Text);
            OutputSolution.Text = resultMultiply.ToString();
        }

        private void DivideButton(object sender, RoutedEventArgs e)
        {
            //After two values are entered they are divided and labeld result
            var resultDivide = double.Parse(input1.Text) / double.Parse(input2.Text);
            OutputSolution.Text = resultDivide.ToString();
        }

        private void ModButton(object sender, RoutedEventArgs e)
        {
            //After two values are entered they are mod and labeld result
            var resultMod = double.Parse(input1.Text) % double.Parse(input2.Text);
            OutputSolution.Text = resultMod.ToString();
         }

        public void StoreMathToFile()
        {
            //store calculations to memory
            var path = "calcMem.txt";
            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(OutputSolution.Text);
            }
        }
        public void ReadMathFromFile()
        {
            var path = "calcMem.txt";
            using (var reader = new StreamReader(path))
            {
                OutputSolution.Text=reader.ReadLine();
            }
        }
        private void MemoryAddButton(object sender, RoutedEventArgs e)
        {
            StoreMathToFile();
        }

        private void MemoryRecallButton(object sender, RoutedEventArgs e)
        {
            ReadMathFromFile();
        }

        private void MemoryClearButton(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("calcMem.txt", "");
        }
    }
}
