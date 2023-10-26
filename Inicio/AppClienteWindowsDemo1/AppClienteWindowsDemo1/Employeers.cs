using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppClienteWindowsDemo1
{
    public partial class Employeers : Form
    {
        public MiCodigoReusable.Employeer myEmployeer = new MiCodigoReusable.Employeer();

        public Employeers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myEmployeer.code = int.Parse(txtCode.Text); // Convierte el valor del campo txtCode a entero y lo asigna a la variable code de la estructura Employeer
            myEmployeer.salary = Convert.ToDouble(txtSalary.Text);
            myEmployeer.name = txtName.Text;
            myEmployeer.department = txtDepartment.Text;
            this.Close();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
