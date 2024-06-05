using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Version_1
{
    public partial class Form1 : Form
    {
        private string[] imagePaths;
        private int currentIndex = 0;
        private System.Threading.Timer timer;

        public Form1()
        {
            InitializeComponent();
            LoadImages();
            timer = new System.Threading.Timer(Timer_Tick, null, 0, 5000); // Timer para cambiar la imagen cada 5 segundos
            textBox1.KeyDown += NombreTextBox_KeyDown;
        }

        private void NombreTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarCarpeta();
            }
        }
        private void LoadImages()
        {
            // Obtener la ruta de la carpeta de imágenes dentro del proyecto
            string imagePath = Path.Combine(Application.StartupPath, "Images");

            // Verificar si la carpeta existe
            if (Directory.Exists(imagePath))
            {
                // Obtener todas las rutas de archivos de imagen en la carpeta
                imagePaths = Directory.GetFiles(imagePath, "*.png");

                // Verificar si se encontraron imágenes
                if (imagePaths.Length > 0)
                {
                    // Mostrar la primera imagen
                    pictureBox1.ImageLocation = imagePaths[currentIndex];
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    MessageBox.Show("No se encontraron imágenes en la carpeta 'Images'.");
                }
            }
            else
            {
                MessageBox.Show("La carpeta 'Images' no existe en el directorio del proyecto.");
            }
        }

        private void Timer_Tick(object state)
        {
            // Cambiar al siguiente índice de imagen
            currentIndex = (currentIndex + 1) % imagePaths.Length;
            // Actualizar la imagen en el PictureBox
            pictureBox1.ImageLocation = imagePaths[currentIndex];
        }



        private void añadirGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rutaPrograma = @"C:\Users\propietario\OneDrive\Documentos\Proyecto-Ipacidevi\Version 1\Grupos";





            // Obtener la ubicación seleccionada por el usuario
            string ubicacion = rutaPrograma;

            // Solicitar al usuario el nombre de la carpeta
            string nombreCarpeta = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre de la carpeta:", "Crear Carpeta", "");

            if (!string.IsNullOrWhiteSpace(nombreCarpeta))
            {
                try
                {
                    // Combinar la ubicación y el nombre de la carpeta para crear la ruta completa
                    string rutaCompleta = Path.Combine(ubicacion, nombreCarpeta);

                    // Verificar si la carpeta ya existe
                    if (!Directory.Exists(rutaCompleta))
                    {
                        // Crear la carpeta
                        Directory.CreateDirectory(rutaCompleta);
                        MessageBox.Show("Carpeta creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La carpeta ya existe en la ubicación especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear la carpeta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre para la carpeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void revisarEstadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {


            // Limpiar el ListBox antes de agregar el contenido
            listBoxContenido.Items.Clear();
            comboboxcarpetas.Items.Clear();
            comboBox3.Items.Clear();

            // Obtener la ruta de la carpeta seleccionada por el usuario
            string rutaCarpeta = @"C:\Users\propietario\OneDrive\Documentos\Proyecto-Ipacidevi\Version 1\Grupos";


            try
            {
                // Verificar si la carpeta existe
                if (Directory.Exists(rutaCarpeta))
                {
                    // Obtener una lista de archivos y subdirectorios dentro de la carpeta

                    string[] subdirectorios = Directory.GetDirectories(rutaCarpeta);



                    // Agregar los nombres de los subdirectorios al ListBox
                    foreach (string subdirectorio in subdirectorios)
                    {
                        listBoxContenido.Items.Add(Path.GetFileName(subdirectorio));
                        comboboxcarpetas.Items.Add(Path.GetFileName(subdirectorio));
                        comboBox3.Items.Add(Path.GetFileName(subdirectorio));
                    }

                    // MessageBox.Show("Contenido de la carpeta mostrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La carpeta especificada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el contenido de la carpeta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el nombre del subdirectorio seleccionado en el ComboBox
            string nombreSubdirectorio = comboboxcarpetas.SelectedItem.ToString();
            string rutaCarpeta = @"C:\Users\propietario\OneDrive\Documentos\Proyecto-Ipacidevi\Version 1\Grupos";


            // Obtener la ruta completa del subdirectorio seleccionado
            string rutaSubdirectorio = Path.Combine(rutaCarpeta, nombreSubdirectorio);

            // Solicitar al usuario el nombre de la nueva carpeta
            string nombreNuevaCarpeta = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del alumno:", "Crear Carpeta", "");

            if (!string.IsNullOrWhiteSpace(nombreNuevaCarpeta))
            {
                try
                {
                    // Combinar la ruta del subdirectorio y el nombre de la nueva carpeta para crear la ruta completa
                    string rutaNuevaCarpeta = Path.Combine(rutaSubdirectorio, nombreNuevaCarpeta);

                    // Verificar si la carpeta ya existe
                    if (!Directory.Exists(rutaNuevaCarpeta))
                    {
                        // Crear la nueva carpeta dentro del subdirectorio seleccionado
                        Directory.CreateDirectory(rutaNuevaCarpeta);
                        MessageBox.Show("Carpeta creada exitosamente en " + nombreSubdirectorio, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La carpeta ya existe en el subdirectorio seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear la carpeta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre para la carpeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crearClaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaClases pantallaClases = new PantallaClases();

            pantallaClases.ShowDialog();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el nombre del subdirectorio seleccionado
            string nombreSubdirectorio = comboBox3.SelectedItem.ToString();

            // Abrir el Form3 y pasarle el nombre del subdirectorio
            RevisionClase form3 = new RevisionClase(nombreSubdirectorio);
            form3.Show();
        }



        private void BuscarCarpeta()
        {
            string nombreCarpetaBuscada = textBox1.Text;

            // Directorio raíz del programa
            string directorioRaiz = @"C:\Users\propietario\OneDrive\Documentos\Proyecto-Ipacidevi\Version 1";

            // Buscar recursivamente la carpeta
            string carpetaEncontrada = BuscarCarpeta(nombreCarpetaBuscada, directorioRaiz);

            if (!string.IsNullOrEmpty(carpetaEncontrada))
            {
                string textoDespuesDeGrupos = null;
                int indiceGrupos = carpetaEncontrada.IndexOf("Grupos");

                if (indiceGrupos != -1)
                {
                    // Obtiene la subcadena que viene después de "Grupos"
                     textoDespuesDeGrupos = carpetaEncontrada.Substring(indiceGrupos + "Grupos".Length + 1);
                }

                textBox2.Text = textoDespuesDeGrupos;
                //Avanzar a la pantalla de trabajo
            }
            else
            {
                MessageBox.Show("Carpeta no encontrada.");
            }
        }

        private string BuscarCarpeta(string nombreCarpeta, string directorio)
        {
            // Buscar en el directorio actual
            string[] carpetas = Directory.GetDirectories(directorio);
            foreach (string carpeta in carpetas)
            {
                if (Path.GetFileName(carpeta).Equals(nombreCarpeta, StringComparison.OrdinalIgnoreCase))
                {
                    return directorio;
                }
            }

            // Buscar en las subcarpetas
            foreach (string carpeta in carpetas)
            {
                string carpetaEncontrada = BuscarCarpeta(nombreCarpeta, carpeta);
                if (!string.IsNullOrEmpty(carpetaEncontrada))
                {
                    return carpetaEncontrada;
                }
            }

            return null;
        }
    }

}





