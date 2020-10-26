using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicio_2_DINT
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int operando1 = int.Parse(operando1TextBox.Text);
            int operando2 = int.Parse(operando2TextBox.Text);
            string operador = operadorTextBox.Text;
            int resultado = 0;
            switch (operador)
            {
                case "/":
                    resultado = operando1 / operando2;
                    break;
                case "+":
                    resultado = operando1 + operando2;
                    break;
                case "-":
                    resultado = operando1 - operando2;
                    break;
                case "*":
                    resultado = operando1 * operando2;
                    break;
            }
            resultadoTextBox.Text = resultado.ToString();
        }
        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            operando1TextBox.Text = "";
            operando2TextBox.Text = "";
            operadorTextBox.Text = "";
            resultadoTextBox.Text = "";
        }
    }
}
