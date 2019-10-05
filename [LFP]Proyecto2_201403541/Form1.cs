﻿using System;
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

        }

        private void tablaTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tablaSímbolosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tablaTokenErroresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "LFP PRACTICA\n Uzzi Libni Aarón Pineda Solórzano\n carné:201403541 \n Sección: A-",
                "Acerca de...");
        }        
    }
}
