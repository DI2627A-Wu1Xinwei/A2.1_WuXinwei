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

namespace _8_CuadrosTexto
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

        private void Ayuda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                TextBlock ayuda;

                if (sender == nombre)
                    ayuda = ayudaNombre;
                else
                    ayuda = ayudaApellido;

                if (ayuda.Visibility == Visibility.Visible)
                    ayuda.Visibility = Visibility.Hidden;
                else
                    ayuda.Visibility = Visibility.Visible;

                e.Handled = true;
            }
        }

        private void Edad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                int numero;

                if (int.TryParse(edad.Text.Trim(), out numero))
                    errorEdad.Visibility = Visibility.Hidden;
                else
                    errorEdad.Visibility = Visibility.Visible;

                e.Handled = true;
            }
                }

    }
}