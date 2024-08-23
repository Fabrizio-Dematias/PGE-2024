using System;
using System.Windows.Forms;

namespace testCalculator
{
    public partial class Form1 : Form
    {
        public delegate void OperationHandler(double a, double b);

        public event OperationHandler OnAddition;
        public event OperationHandler OnSubtraction;
        public event OperationHandler OnMultiplication;
        public event OperationHandler OnDivision;

        private double firstNumber;
        private double secondNumber;
        private string operation;

        public Form1()
        {
            InitializeComponent();

            OnAddition += Form1_OnAddition;
            OnSubtraction += Form1_OnSubtraction;
            OnMultiplication += Form1_OnMultiplication;
            OnDivision += Form1_OnDivision;
        }

        private void Form1_OnAddition(double a, double b)
        {
            textBox1.Text = (a + b).ToString();
        }

        private void Form1_OnSubtraction(double a, double b)
        {
            textBox1.Text = (a - b).ToString();
        }

        private void Form1_OnMultiplication(double a, double b)
        {
            textBox1.Text = (a * b).ToString();
        }

        private void Form1_OnDivision(double a, double b)
        {
            if (b != 0)
            {
                textBox1.Text = (a / b).ToString();
            }
            else
            {
                MessageBox.Show("No se puede dividir entre cero.");
            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBox1.Text += button.Text;
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                operation = (sender as Button).Text;
            }
            catch (FormatException)
            {
                MessageBox.Show("Entrada no válida. Por favor, ingresa un número válido.");
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
                textBox1.Clear();
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    secondNumber = Convert.ToDouble(textBox1.Text);

                    switch (operation)
                    {
                        case "+":
                            OnAddition?.Invoke(firstNumber, secondNumber);
                            break;
                        case "-":
                            OnSubtraction?.Invoke(firstNumber, secondNumber);
                            break;
                        case "*":
                            OnMultiplication?.Invoke(firstNumber, secondNumber);
                            break;
                        case "/":
                            OnDivision?.Invoke(firstNumber, secondNumber);
                            break;
                        default:
                            MessageBox.Show("Operación no válida.");
                            break;
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Entrada no válida. Por favor, ingresa un número válido.");
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
                textBox1.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            firstNumber = 0;
            secondNumber = 0;
            operation = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
