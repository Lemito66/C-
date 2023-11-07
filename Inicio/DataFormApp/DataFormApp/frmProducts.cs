using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFormApp
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbDeltaNov2023Entities2 db = new dbDeltaNov2023Entities2();

            var query = from p in db.Products
                        select p;

            foreach (Product item in query)
            {
                //listBox1.Items.Add(item.Name + " " + item.ListPrice.ToString());
                listBox1.Items.Add($"Nombre: {item.Name} Lista de precio: {item.ListPrice.ToString()}");
            }
        }
    }
}
