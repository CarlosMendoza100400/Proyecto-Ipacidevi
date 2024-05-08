using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version_1
{
    public partial class RevisionClase : Form
    {
        string rutaPrincipal = @"C:\Users\propietario\OneDrive\Documentos\Proyecto-Ipacidevi\Version 1\Grupos"; // Cambia esto por la ruta de tu directorio principal
        string subdirectorio =""; 

        public RevisionClase(string nombreSubdirectorio)
        {
            InitializeComponent();

            this.subdirectorio =  nombreSubdirectorio ;
            
            //añador un \ al inicio del nombre del subdirectorio
            subdirectorio = @"\" + subdirectorio;

            // Obtener la ruta completa del subdirectorio
            string rutaSubdirectorio = Path.Combine(rutaPrincipal, nombreSubdirectorio); // Cambia esto por la ruta de tu directorio principal

            // Cargar los archivos .txt del subdirectorio en el ComboBox
            CargarArchivos(rutaSubdirectorio);
        }

        private void CargarArchivos(string rutaSubdirectorio)
        {
            try
            {
                // Obtener todos los archivos .txt en el subdirectorio
                string[] archivos = Directory.GetFiles(rutaSubdirectorio, "*.txt");

                // Agregar los nombres de los archivos .txt al ComboBox
                foreach (string archivo in archivos)
                {
                    comboBox1.Items.Add(Path.GetFileName(archivo));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los archivos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el nombre del archivo seleccionado
            string nombreArchivo = comboBox1.SelectedItem.ToString();

            // Obtener la ruta completa del archivo
            string rutaArchivo = Path.Combine(rutaPrincipal + subdirectorio, nombreArchivo); // Cambia esto por la ruta de tu directorio principal

            try
            {
                // Mostrar el contenido del archivo en el TextBox
                string contenido = File.ReadAllText(rutaArchivo);
                textBox1.Text = contenido;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
