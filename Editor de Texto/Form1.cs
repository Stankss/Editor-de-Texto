using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_Texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Abrir se usa para abrir archivos que se encuentran en el dispositivo
        private void Abrir_btn_Click(object sender, EventArgs e)
        {
            string r;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName);
            r = archivo.ReadLine();
            richTextBox1.Text = r.ToString();
        }
        //Guardar se usa para almacenar archivos creados por el editor de texto
        private void Guardar_btn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Nuevo Archivo.txt";
            var guardar = saveFileDialog1.ShowDialog();
            if( guardar == DialogResult.OK )
            {
                using (var guardar_archivo = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    guardar_archivo.WriteLine(richTextBox1.Text);
                }
            }
        }
        //Cerrar se usa para salir del editor
        private void Cerrar_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //Atras para volver a un cambio previo 
        private void Atras_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        //Adelante se usa para adelantarse a un cambio posterior
        private void Adelante_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
        //Copiar se usa para almacenar la informacion en el portapapeles sin alterarla
        private void Copiar_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        //Cortar se usa para almacenar la informacion en el portapapeles eliminandola el editor
        private void Cortar_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        //Pegar se usa para pegar la informacion almacenada del portapapeles
        private void Pegar_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        //Sombrea toda la informacion para manipularla
        private void SeleccionarTodo_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        //Sombrea toda la informacion para eliminarla
        private void EliminarTodo_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        //Permite cambiar el formato de la fuente
        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmt = fontDialog1.ShowDialog();
            if (frmt == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }
        //Permite cambiar el Tamaño de la fuente
        private void Seleccionar_Tamaño(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.SystemFontName, float.Parse
                    (ComboBox1.SelectedItem.ToString()),richTextBox1.Font.Style);
            }
        }
    }
}
