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

namespace _4_CaracteresLimitados
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

        private const int Maximo = 140;

        private void Texto_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (contador == null) return;

            int longitud = texto.Text.Length;
            contador.Text = longitud + "/" + Maximo;

            texto.IsReadOnly = longitud >= Maximo;
        }

    }
}