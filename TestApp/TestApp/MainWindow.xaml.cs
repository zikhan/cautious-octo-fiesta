using System.Windows;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _output;
        public string Output {
            get => _output;
            set => _output = value;
        }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Output = "helloworld";
        }

        private void chkButton_Click(object sender, RoutedEventArgs e) => MessageBox.Show($"Output is {Output}");
    }
}
