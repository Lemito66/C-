using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoForms
{
    public partial class Form1 : Form
    {
        ArrayList employeers = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employeer employeer = new Employeer();
            employeer.Name = txtName.Text;
            try
            {
                
                employeer.Age = Convert.ToInt32(txtAge.Text);
                employeer.Salary = Convert.ToDouble(txtSalary.Text);
                employeers.Add(employeer);
                employeer.IncreaseSalary(10);

                // Limpiar el formulario cada vez que ingresamos un empleado
                txtName.Text = "";
                txtAge.Text = "";
                txtSalary.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar los datos");
            }
            

            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ver si la lista employeers está vacia
            if (employeers.Count == 0)
            {
                MessageBox.Show("No hay empleados");
                return;
            }
            // Mostrar un mensaje en pantalla
            foreach (Employeer employeer in employeers)
            {
                //MessageBox.Show(employeer.Name + " " + employeer.Age + " " + employeer.Salary);
                if (employeer.Salary > 1000)
                {
                    MessageBox.Show(employeer.Name + " " + employeer.Age + " " + employeer.Salary);
                    
                }
                else
                {
                    MessageBox.Show("El salario de: " + employeer.Name + "es inferior a 1000");
                }
            }
        }

        private void saveEmployeer_Click(object sender, EventArgs e)
        {
            SaveEmployeer saveEmployeer = new SaveEmployeer();
            saveEmployeer.Show();

        }
    }
}
