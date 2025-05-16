using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto1 = textBox1.Text;
            string texto2 = textBox2.Text;
            string texto3 = textBox3.Text;

            string rutaArchivo = "FicheroFinal.txt";

            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                writer.WriteLine(texto1);
                writer.WriteLine(texto2);
                writer.WriteLine(texto3);
            }

            MessageBox.Show("Documento generado correctamente.");

        }
    }
}
