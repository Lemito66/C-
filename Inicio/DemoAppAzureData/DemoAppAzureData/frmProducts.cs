using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAppAzureData
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbDeltaNov2023DataSet.Product' Puede moverla o quitarla según sea necesario.
            this.productTableAdapter.Fill(this.dbDeltaNov2023DataSet.Product);

        }
    }
}
