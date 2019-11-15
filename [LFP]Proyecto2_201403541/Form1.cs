using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _LFP_Proyecto2_201403541
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Lexico lex = new Lexico();
        Sintactico sin = new Sintactico();        

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivo|*.cs";
            abrir.Title = "Abrir Archivo";
            abrir.FileName = "File";

            var dato = abrir.ShowDialog();
            if (dato == DialogResult.OK)
            {
                StreamReader leer = new StreamReader(abrir.FileName);
                richTextBox1.Text = leer.ReadToEnd();
                leer.Close();
            }            
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar los cambios", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = "Archivo|*.cs";
                guardar.Title = "Guardar Archivo";
                guardar.FileName = "Sin Titulo";

                var dato = guardar.ShowDialog();
                if (dato == DialogResult.OK)
                {
                    StreamWriter escribir = new StreamWriter(guardar.FileName);
                    foreach (object linea in richTextBox1.Lines)
                    {
                        escribir.WriteLine(linea);
                    }
                    escribir.Close();
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir de la aplicación", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void generarTraduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            lex.Scanner(richTextBox1.Text);
            sin.Parsear(lex.getToken());
            sin.Ejecutar();
        }

        private void tablaTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lex.Reporte1();            
        }

        private void tablaSímbolosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lex.Reporte3();
            sin.Reporte4();
        }

        private void tablaTokenErroresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lex.Reporte2();
        }

        private void limpiarDocumentosRecientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Lista> ListaA = new List<Lista>();
            List<Elista> ListaB = new List<Elista>();

            ListaA.Clear();            
            ListaB.Clear();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "LFP PRACTICA\n Uzzi Libni Aarón Pineda Solórzano\n carné:201403541 \n Sección: A-",
                "Acerca de...");
        }
        
    }
}