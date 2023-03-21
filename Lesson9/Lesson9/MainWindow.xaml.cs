using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lesson9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> lines = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            View.ItemsSource = lines;
        }

        private void Reverse(object sender, RoutedEventArgs e)
        {
            lines.Clear();
            lines = ReversWordsInlist(InputBox.Text);
            View.Items.Refresh();
        }

        private void Divide(object sender, RoutedEventArgs e)
        {
            lines.Clear();
            lines = SplitLineInList(InputBox.Text);
            View.Items.Refresh();
        }

        private List<string> SplitLineInList(string line)
        {
            string[] input = line.Split();
            List<string> result = new List<string>();
            foreach (string word in input)
            {
                result.Add(word);
            }
            return result;
        }

        private List<string> ReversWordsInlist(string line)
        {
            List<string> result = new List<string>();
            result = SplitLineInList(line);
            result.Reverse();
            return result;
        }
    }
}
