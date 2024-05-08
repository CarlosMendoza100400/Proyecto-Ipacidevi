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
    public partial class PantallaClases : Form
    {
        private string rutaCarpeta = "";
        string rutaPrincipal = @"C:\Users\propietario\OneDrive\Documentos\Proyecto-Ipacidevi\Version 1\Grupos"; // Cambia esto por la ruta de tu directorio principal

        public PantallaClases()
        {
            InitializeComponent();

            // Inicializar el ComboBox con los subdirectorios
            CargarSubdirectorios();
        }

        private void CargarSubdirectorios()
        {
            // Obtener la ruta del directorio principal
            
            // Limpiar el ComboBox antes de cargar los subdirectorios
           comboBox1.Items.Clear();

            try
            {
                // Obtener los subdirectorios dentro del directorio principal
                string[] subdirectorios = Directory.GetDirectories(rutaPrincipal);

                // Agregar los nombres de los subdirectorios al ComboBox
                foreach (string subdirectorio in subdirectorios)
                {
                    comboBox1.Items.Add(Path.GetFileName(subdirectorio));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los subdirectorios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un subdirectorio
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un subdirectorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el nombre del subdirectorio seleccionado
            string nombreSubdirectorio = comboBox1.SelectedItem.ToString();

            // Obtener la ruta completa del subdirectorio seleccionado
            string rutaSubdirectorio = Path.Combine(rutaPrincipal, nombreSubdirectorio); // Cambia esto por la ruta de tu directorio principal

            // Obtener el contenido del cuadro de texto
            string contenido = textBox1.Text;

            // Generar el nombre del archivo (automático y autoincremental)
            int numeroClase = ObtenerNumeroClase(rutaSubdirectorio);
            string nombreArchivo = "Clase " + numeroClase + ".txt";

            try
            {
                // Crear el archivo de texto en el subdirectorio seleccionado
                string rutaArchivo = Path.Combine(rutaSubdirectorio, nombreArchivo);
                File.WriteAllText(rutaArchivo, contenido);

                MessageBox.Show("Archivo guardado exitosamente en " + nombreSubdirectorio, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //cerrar el formulario actual
            this.Close();
        }

        private int ObtenerNumeroClase(string rutaSubdirectorio)
        {
            // Verificar si el subdirectorio existe
            if (Directory.Exists(rutaSubdirectorio))
            {
                // Contar el número de archivos de texto en el subdirectorio
                string[] archivos = Directory.GetFiles(rutaSubdirectorio, "*.txt");
                return archivos.Length + 1;
            }
            else
            {
                return 1; // Si el subdirectorio no existe, comenzar desde 1
            }
        }


    }
}
