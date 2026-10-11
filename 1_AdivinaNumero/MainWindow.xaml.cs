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

namespace _1_AdivinaNumero
{
    
    public partial class MainWindow : Window
    {
        private readonly Random random = new Random();
        private int numeroAAdivinar;

        public MainWindow()
        {
            InitializeComponent();
            NuevoJuego();

        }

        private void Comprobar_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtNumero.Text, out int intento))
            {
                resultado.Text = "Introduce un número válido";
                return;
            }

            if (intento == numeroAAdivinar)
                resultado.Text = "¡Has acertado!";
            else if (intento < numeroAAdivinar)
                resultado.Text = "Te has quedado corto";
            else
                resultado.Text = "Te has pasado";
        }

        private void Reiniciar_Click(object sender, RoutedEventArgs e)
        {
            NuevoJuego();
        }

        private void NuevoJuego()
        {
            numeroAAdivinar = random.Next(1, 101);
            txtNumero.Clear();
            resultado.Text = "";
            txtNumero.Focus();
        }
    }
}