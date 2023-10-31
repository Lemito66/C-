using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGeneric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista<int> example = new Lista<int>(5); // le pasamos el generico al constructor, siempre hay que pasarle el parámetro
            // Imprimir
            example.writeValue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employeer employeer = new Employeer();
            employeer.Id = 1;
            employeer.Name = "Emill";
            employeer.Address = "Calle 1";
            employeer.Telephone = 0969056274;
            employeer.Email = "lemito66@gmail.com";
            employeer.Gender = "Male";
            employeer.Salary = 3500;

            MessageBox.Show(employeer.Name + " " + employeer.Address + " " + employeer.Telephone + " " + employeer.Email + " " + employeer.Gender + " " + employeer.Salary);
        }
    }
}
