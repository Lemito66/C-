using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FourthCoffee.LogProcessor;

namespace DemoFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|PDF Files (*.pdf)|*.pdf";
            this.saveFileDialog1.Title = "Guardar Archivo de Texto";
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.CheckPathExists = true;
            this.saveFileDialog1.DefaultExt = "txt";

            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] colaboradores = new string[] { "Pedro", "Mario", "Luis", "Ricardo", "Pepe" };
                using (StreamWriter sw = new StreamWriter(this.saveFileDialog1.FileName.ToString().Trim()))
                {
                    foreach (string s in colaboradores)
                    {
                        sw.WriteLine(s);
                    }
                }
            }
            else
            {
                MessageBox.Show("Archivo no Creado !!!!");
            }

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(this.openFileDialog1.FileName.ToString().Trim()))
                {
                    string colaborador = "";
                    while ((colaborador = sr.ReadLine()) != null)
                    {
                        MessageBox.Show(colaborador);

                    }
                }
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var logLocator = new LogLocator("C:\\Materiales\\20483C-Part-1-Trainer-Files-Programming-in-C-\\20483-Programming-in-C-Sharp-master\\20483-Programming-in-C-Sharp-master\\Allfiles\\Mod06\\Democode\\Data\\Logs");

            var logCombinador = new LogCombiner(logLocator);

            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {

                logCombinador.CombineLogs(this.saveFileDialog1.FileName.ToString());

            }
                  

        }
    }
}
