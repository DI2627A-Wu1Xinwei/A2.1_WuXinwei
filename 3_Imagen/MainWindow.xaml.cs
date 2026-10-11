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

namespace _3_Imagen
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

        private void Alta_Checked(object sender, RoutedEventArgs e)
        {
            if (imagen == null) return;
            imagen.Opacity = 1.0;
        }

        private void Media_Checked(object sender, RoutedEventArgs e)
        {
            if (imagen == null) return;
            imagen.Opacity = 0.5;
        }

        private void Baja_Checked(object sender, RoutedEventArgs e)
        {
            if (imagen == null) return;
            imagen.Opacity = 0.2;
        }

        private void Ajuste_Checked(object sender, RoutedEventArgs e)
        {
            if (imagen == null) return;
            RadioButton rb = (RadioButton)sender;
            imagen.Stretch = (Stretch)Enum.Parse(typeof(Stretch), (string)rb.Tag);
        }

    }
}