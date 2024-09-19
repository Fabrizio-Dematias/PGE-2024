using System;
using System.IO;
using System.Windows.Forms;

namespace TAREA_10_EJ_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            // Crear un diálogo para seleccionar archivos
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*",
                Title = "Seleccione un archivo de texto"
            };

            // Si el usuario selecciona un archivo y hace clic en "OK"
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Leer el contenido del archivo seleccionado
                    string fileContent = File.ReadAllText(openFileDialog.FileName);

                    // Mostrar el contenido en el TextBox
                    txtFileContent.Text = fileContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
            }
        }
    }
}
