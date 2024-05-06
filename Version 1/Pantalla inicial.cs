using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

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

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        // Método para manejar el cierre del formulario y liberar los recursos del temporizador
        // protected override void Dispose(bool disposing)

    }
}





