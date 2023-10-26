using System.Collections;

namespace DemoAppAcademica
{
    public partial class Form1 : Form
    {
        ArrayList listStudents = new ArrayList();
        Student myStudent = new Student();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myStudent.Code = Convert.ToInt32(txtCode.Text);
            myStudent.Name = txtName.Text;
            myStudent.ScoreOne = Convert.ToDouble(txtScoreOne.Text);
            myStudent.ScoreTwo = Convert.ToDouble(txtScoreTwo.Text);
            myStudent.FinalScore = myStudent.ScoreTwo;
            myStudent.Status = myStudent.FinalScore >= 7.0 ? "Aprobado" : "Reprobado";
            listStudents.Add(myStudent);
            MessageBox.Show("Estudiante creado satisfactoriamente");
            //MessageBox.Show(myStudent.Name + " " + myStudent.FinalScore + " " + myStudent.Status);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mostrar datos del estudiante
            foreach (Student student in listStudents)
            {
                MessageBox.Show("Estudiante que tiene la nota 2 de : " + student.FinalScore + " se encuentra: " + student.Status);
                //MessageBox.Show(student.Name + " " + student.FinalScore + " " + student.Status);
            }
        }
    }
}