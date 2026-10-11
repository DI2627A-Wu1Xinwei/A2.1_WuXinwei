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

namespace _6_Opacidad
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

        private void Imagen_Opacidad(object sender, MouseEventArgs e)
        {
            Image imagen = (Image)sender;
            imagen.Opacity = imagen.IsMouseOver ? 1.0 : 0.5;
        }

    }
}