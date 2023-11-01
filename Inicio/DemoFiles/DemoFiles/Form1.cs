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
using System.Runtime.Serialization.Formatters.Binary;

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

            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog1.CheckPathExists = true;
            //this.saveFileDialog1.Title = "Save a text file";
            this.saveFileDialog1.CheckFileExists = true;
            

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

        MyClass myClass;

        private void button3_Click(object sender, EventArgs e)
        {
            // Serialize an object
            myClass = new MyClass(1, "Hello");
            serialize(myClass);
            MessageBox.Show("Object serialized");

        }

        public static void serialize(MyClass MC)
        {
            Stream stream = File.Open("MyClass.obj", FileMode.Create);
            BinaryFormatter bwritter = new BinaryFormatter();

            bwritter.Serialize(stream, MC);
            stream.Close();
        }

        public static MyClass deserialize(MyClass MC)
        {
            Stream streamReader = File.Open("MyClass.obj", FileMode.Open);
            BinaryFormatter breader = new BinaryFormatter();
            MyClass mcD = breader.Deserialize(streamReader) as MyClass;
            streamReader.Close();
            return mcD;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyClass _myClass = deserialize(myClass);
            MessageBox.Show(myClass.MyFirstProperty.ToString() + " " + myClass.MySecondProperty);

        }
    }
}
