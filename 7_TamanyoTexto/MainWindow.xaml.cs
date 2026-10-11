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

namespace _7_TamanyoTexto
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

        private void Tamanyo_Checked(object sender, RoutedEventArgs e)
        {
            if (texto == null) return;

            RadioButton rb = (RadioButton)sender;
            texto.FontSize = Convert.ToDouble(rb.Tag);
        }

    }
}