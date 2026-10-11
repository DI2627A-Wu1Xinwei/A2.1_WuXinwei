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

namespace _2_CalculadoraBasica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Operador_TextChanged(object sender, TextChangedEventArgs e)
        {
            string op = operador.Text.Trim();

            calcular.IsEnabled = op == "+" || op == "-" || op == "*" || op == "/";
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(operando1.Text.Trim());
                double b = double.Parse(operando2.Text.Trim());
                double res;

                switch (operador.Text.Trim())
                {
                    case "+": res = a + b; break;
                    case "-": res = a - b; break;
                    case "*": res = a * b; break;
                    case "/":
                        if (b == 0)
                            throw new DivideByZeroException();
                        res = a / b;
                        break;
                    default:
                        throw new InvalidOperationException("Operador no válido");
                }

                resultado.Text = res.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Los operandos deben ser números válidos.", "Error",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir entre cero.", "Error",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("El número introducido es demasiado grande.", "Error",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message, "Error",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Limpiar_Click(object sender, RoutedEventArgs e)
        {
            operando1.Clear();
            operando2.Clear();
            operador.Clear();
            resultado.Clear();
            operando1.Focus();
        }
    }
}