using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  // for File, FileInfo, Directory, DirectoryInfo

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
            

            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK) // OK button pressed
            {
                string filename = this.saveFileDialog1.FileName.ToString().Trim();
                string[] employeers = new string[] { "Emill", "Mary", "Peter", "Paul" };
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (string name in employeers)
                    {
                        sw.WriteLine(name);
                    }
                }
                MessageBox.Show("File saved");

            }
            else
            {
                MessageBox.Show("No file selected");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Read all lines from a file
            /* string[] lines = File.ReadAllLines("employeers.txt");
            foreach (string line in lines)
            {
                MessageBox.Show(line);
            } */

            if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                
                using (StreamReader sr = new StreamReader(this.openFileDialog1.FileName.ToString().Trim()))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        MessageBox.Show(line);
                    }
                }
            }

            
        }
    }
}
