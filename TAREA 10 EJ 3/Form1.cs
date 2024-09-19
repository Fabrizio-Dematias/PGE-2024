using System;
using System.Windows.Forms;

namespace RegistroGastos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Solo USD como opción de moneda
            cbMoneda.Items.Add("USD");
            cbMoneda.SelectedIndex = 0; // Pre-selecciona USD
        }

        // Función para convertir el total de gastos en moneda local a USD
        private double ConvertirMoneda(double valorMonedaLocal)
        {
            // Tasa de conversión: 1 unidad de moneda local = 0.85 USD
            double tasaConversion = 0.85;
            return valorMonedaLocal * tasaConversion;
        }

        // Evento para agregar gasto en moneda local
        private void btnAgregarGasto_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la descripción del gasto y el valor ingresado en la moneda local
                string descripcion = txtDescripcion.Text;
                double valorMonedaLocal = double.Parse(txtValor.Text);

                if (string.IsNullOrEmpty(descripcion))
                {
                    MessageBox.Show("Debe ingresar una descripción.");
                    return;
                }

                // Agregar el gasto en la moneda local a la tabla
                dataGridGastos.Rows.Add(descripcion, valorMonedaLocal.ToString("F2"));

                // Limpiar campos
                txtDescripcion.Clear();
                txtValor.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor numérico válido para el gasto.");
            }
        }

        // Evento para realizar la conversión del total a USD
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double totalMonedaLocal = 0;

            // Sumar todos los gastos registrados en moneda local
            foreach (DataGridViewRow row in dataGridGastos.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    totalMonedaLocal += Convert.ToDouble(row.Cells[1].Value);
                }
            }

            // Convertir el total a USD usando la tasa de conversión
            double totalConvertidoUSD = ConvertirMoneda(totalMonedaLocal);

            // Mostrar el total convertido a USD
            lblTotalConvertido.Text = $"Total en USD: {totalConvertidoUSD:C2}";
        }
    }
}
