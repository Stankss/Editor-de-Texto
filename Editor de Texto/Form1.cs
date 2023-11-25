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

        private void Abrir_btn_Click(object sender, EventArgs e)
        {
            string r;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName);
            r = archivo.ReadLine();
            richTextBox1.Text = r.ToString();
        }

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

        private void Cerrar_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Atras_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void Adelante_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void Copiar_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void Cortar_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void Pegar_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void SeleccionarTodo_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void EliminarTodo_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmt = fontDialog1.ShowDialog();
            if (frmt == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

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
