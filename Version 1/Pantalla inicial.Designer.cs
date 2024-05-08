namespace Version_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            profesorToolStripMenuItem = new ToolStripMenuItem();
            administrarGruposToolStripMenuItem = new ToolStripMenuItem();
            añadirGrupoToolStripMenuItem = new ToolStripMenuItem();
            revisarEstadisticasToolStripMenuItem = new ToolStripMenuItem();
            listBoxContenido = new ToolStripComboBox();
            añadirAlumnoToolStripMenuItem = new ToolStripMenuItem();
            comboboxcarpetas = new ToolStripComboBox();
            administrarClasesToolStripMenuItem = new ToolStripMenuItem();
            crearClaseToolStripMenuItem = new ToolStripMenuItem();
            revisarClaseToolStripMenuItem = new ToolStripMenuItem();
            comboBox3 = new ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(110, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(573, 259);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { profesorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // profesorToolStripMenuItem
            // 
            profesorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administrarGruposToolStripMenuItem, administrarClasesToolStripMenuItem });
            profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            profesorToolStripMenuItem.Size = new Size(63, 20);
            profesorToolStripMenuItem.Text = "Profesor";
            // 
            // administrarGruposToolStripMenuItem
            // 
            administrarGruposToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { añadirGrupoToolStripMenuItem, revisarEstadisticasToolStripMenuItem, añadirAlumnoToolStripMenuItem });
            administrarGruposToolStripMenuItem.Name = "administrarGruposToolStripMenuItem";
            administrarGruposToolStripMenuItem.Size = new Size(180, 22);
            administrarGruposToolStripMenuItem.Text = "Administrar grupos";
            // 
            // añadirGrupoToolStripMenuItem
            // 
            añadirGrupoToolStripMenuItem.Name = "añadirGrupoToolStripMenuItem";
            añadirGrupoToolStripMenuItem.Size = new Size(180, 22);
            añadirGrupoToolStripMenuItem.Text = "Añadir grupo";
            añadirGrupoToolStripMenuItem.Click += añadirGrupoToolStripMenuItem_Click;
            // 
            // revisarEstadisticasToolStripMenuItem
            // 
            revisarEstadisticasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listBoxContenido });
            revisarEstadisticasToolStripMenuItem.Name = "revisarEstadisticasToolStripMenuItem";
            revisarEstadisticasToolStripMenuItem.Size = new Size(180, 22);
            revisarEstadisticasToolStripMenuItem.Text = "Revisar estadisticas";
            revisarEstadisticasToolStripMenuItem.DropDownOpened += revisarEstadisticasToolStripMenuItem_Click;
            revisarEstadisticasToolStripMenuItem.Click += revisarEstadisticasToolStripMenuItem_Click;
            // 
            // listBoxContenido
            // 
            listBoxContenido.Name = "listBoxContenido";
            listBoxContenido.Size = new Size(121, 23);
            // 
            // añadirAlumnoToolStripMenuItem
            // 
            añadirAlumnoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { comboboxcarpetas });
            añadirAlumnoToolStripMenuItem.Name = "añadirAlumnoToolStripMenuItem";
            añadirAlumnoToolStripMenuItem.Size = new Size(180, 22);
            añadirAlumnoToolStripMenuItem.Text = "Añadir alumno";
            añadirAlumnoToolStripMenuItem.DropDownOpened += revisarEstadisticasToolStripMenuItem_Click;
            // 
            // comboboxcarpetas
            // 
            comboboxcarpetas.Name = "comboboxcarpetas";
            comboboxcarpetas.Size = new Size(121, 23);
            comboboxcarpetas.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            // 
            // administrarClasesToolStripMenuItem
            // 
            administrarClasesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearClaseToolStripMenuItem, revisarClaseToolStripMenuItem });
            administrarClasesToolStripMenuItem.Name = "administrarClasesToolStripMenuItem";
            administrarClasesToolStripMenuItem.Size = new Size(180, 22);
            administrarClasesToolStripMenuItem.Text = "Administrar clases";
            // 
            // crearClaseToolStripMenuItem
            // 
            crearClaseToolStripMenuItem.Name = "crearClaseToolStripMenuItem";
            crearClaseToolStripMenuItem.Size = new Size(180, 22);
            crearClaseToolStripMenuItem.Text = "Crear clase";
            crearClaseToolStripMenuItem.Click += crearClaseToolStripMenuItem_Click;
            // 
            // revisarClaseToolStripMenuItem
            // 
            revisarClaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { comboBox3 });
            revisarClaseToolStripMenuItem.Name = "revisarClaseToolStripMenuItem";
            revisarClaseToolStripMenuItem.Size = new Size(180, 22);
            revisarClaseToolStripMenuItem.Text = "Revisar clase";
            revisarClaseToolStripMenuItem.DropDownOpening += revisarEstadisticasToolStripMenuItem_Click;
            // 
            // comboBox3
            // 
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem profesorToolStripMenuItem;
        private ToolStripMenuItem administrarGruposToolStripMenuItem;
        private ToolStripMenuItem añadirGrupoToolStripMenuItem;
        private ToolStripMenuItem administrarClasesToolStripMenuItem;
        private ToolStripMenuItem crearClaseToolStripMenuItem;
        private ToolStripMenuItem revisarClaseToolStripMenuItem;
        private ToolStripMenuItem revisarEstadisticasToolStripMenuItem;
        private ToolStripComboBox listBoxContenido;
        private ToolStripMenuItem añadirAlumnoToolStripMenuItem;
        private ToolStripComboBox comboboxcarpetas;
        private ToolStripComboBox comboBox3;
    }
}
