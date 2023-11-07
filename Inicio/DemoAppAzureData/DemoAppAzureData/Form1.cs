using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAppAzureData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Server=tcp:srvdeltaperu.database.windows.net,1433;Initial Catalog=dbDeltaNov2023;Persist Security Info=False;User ID=adminsql;Password=Pa$$w0rd8787;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                connection.Open();
                //MessageBox.Show("Conexión exitosa");
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT *   FROM [SalesLT].[Product]", connection);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
