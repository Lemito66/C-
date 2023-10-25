namespace AppClienteWindowsDemo1
{
    public partial class Form1 : Form
    {
        //MiCodigoReusable.Employeer myEmployeer = new MiCodigoReusable.Employeer();
        MiCodigoReusable.Employeer[] myEmployeer = new MiCodigoReusable.Employeer[4];

        enum weekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //weekDays day = weekDays.Monday;
            weekDays day = (weekDays)3; // Otra forma
            MessageBox.Show("El valor de la variable día es: " + day.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            myEmployeer[0].code = 1;
            myEmployeer[0].name = "Juan";
            myEmployeer[0].salary = 1000;
            myEmployeer[0].department = "Ventas";
            //MessageBox.Show("El empleado " + myEmployeer.name + " trabaja en el departamento de " + myEmployeer.department);

            myEmployeer[1].code = 1;
            myEmployeer[1].name = "Jorge";
            myEmployeer[1].salary = 1000;
            myEmployeer[1].department = "Ventas";


            myEmployeer[2].code = 1;
            myEmployeer[2].name = "Mario";
            myEmployeer[2].salary = 1000;
            myEmployeer[2].department = "Ventas";

            myEmployeer[3].code = 1;
            myEmployeer[3].name = "Marlene";
            myEmployeer[3].salary = 1000;
            myEmployeer[3].department = "Ventas"; */

            Employeers frm = new Employeers();
            frm.ShowDialog(); // Muestra el formulario de Employeer
            myEmployeer[index] = frm.myEmployeer; // Asigna el valor de la variable myEmployeer del formulario Employeer al arreglo myEmployeer
            index++; // Incrementa el índice del arreglo
        }

        private void button3_Click(object sender, EventArgs e)
        {
           //MessageBox.Show("El empleado " + myEmployeername + " tiene un salario de: " + myEmployeer.salary.ToString());
           for (int i = 0; i < myEmployeer.Length; i++)
            {
                MessageBox.Show("El empleado " + myEmployeer[i].name + " tiene un salario de: " + myEmployeer[i].salary.ToString());
            }   
        }
    }
}