using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Colors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            KeyDown += MainWindow_KeyDown;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.Modifiers == ModifierKeys.Control)
            {
                switch (e.Key)
                {
                    case Key.R:
                        ChangeButtonColor(System.Windows.Media.Colors.Red);
                        break;
                    case Key.G:
                        ChangeButtonColor(System.Windows.Media.Colors.Green);
                        break;
                    case Key.B:
                        ChangeButtonColor(System.Windows.Media.Colors.Blue);
                        break;
                }
            }
        }

        private void ChangeButtonColor(Color color)
        {
            myButton.Background = new SolidColorBrush(color);
        }
    }
}

