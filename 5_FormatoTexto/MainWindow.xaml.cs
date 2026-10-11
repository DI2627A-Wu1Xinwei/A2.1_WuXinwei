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

namespace _5_FormatoTexto
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

        private void Texto_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (resultado == null) return;
            resultado.Text = texto.Text;
        }

        private void Negrita_Changed(object sender, RoutedEventArgs e)
        {
            if (resultado == null) return;
            resultado.FontWeight = negrita.IsChecked == true ? FontWeights.Bold : FontWeights.Normal;
        }

        private void Cursiva_Changed(object sender, RoutedEventArgs e)
        {
            if (resultado == null) return;
            resultado.FontStyle = cursiva.IsChecked == true ? FontStyles.Italic : FontStyles.Normal;
        }

        private void Azul_Checked(object sender, RoutedEventArgs e)
        {
            if (resultado == null) return;
            resultado.Foreground = Brushes.Blue;
        }

        private void Rojo_Checked(object sender, RoutedEventArgs e)
        {
            if (resultado == null) return;
            resultado.Foreground = Brushes.Red;
        }

        private void Verde_Checked(object sender, RoutedEventArgs e)
        {
            if (resultado == null) return;
            resultado.Foreground = Brushes.Green;
        }

    }
}