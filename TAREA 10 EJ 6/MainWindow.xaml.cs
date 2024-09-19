using System.Windows;

namespace TAREA10EJ6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeCurrencies();
        }

        private void InitializeCurrencies()
        {
            // Agregar divisas para la demostración
            cmbFromCurrency.Items.Add("USD");
            cmbFromCurrency.Items.Add("EUR");
            cmbToCurrency.Items.Add("USD");
            cmbToCurrency.Items.Add("EUR");
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtAmount.Text, out double amount))
            {
                string fromCurrency = cmbFromCurrency.Text;
                string toCurrency = cmbToCurrency.Text;

                double conversionRate = GetConversionRate(fromCurrency, toCurrency);
                double result = amount * conversionRate;

                txtResult.Text = $"{amount} {fromCurrency} = {result} {toCurrency}";
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }

        private double GetConversionRate(string fromCurrency, string toCurrency)
        {
            // Aquí iría la lógica para obtener el tipo de cambio.
            // Valores de ejemplo:
            if (fromCurrency == "USD" && toCurrency == "EUR")
                return 0.85;
            if (fromCurrency == "EUR" && toCurrency == "USD")
                return 1.18;

            return 1; // Valor por defecto si las divisas son iguales.
        }
    }
}
