using System.Collections;

namespace appClienteDemoForms
{
    public partial class Form1 : Form
    {
        // List Collections
        ArrayList listProducts = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products myproduct = new Products(1, "Coca Cola", 1.5, 100); // Instanciamos la clase Products

            listProducts.Add(myproduct); // Agregamos el objeto a la lista

            // ver en un mensaje cuando demos click en el boton
            //MessageBox.Show("Se agrego el producto: " + myproduct.Name + " a la lista");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Products item in listProducts)
            {
                //MessageBox.Show("Se agrego el producto: " + item.Name + " a la lista");
                lstProducts.Items.Add(item.Name + " " + "Precio: " + item.Price);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Products product1 = new Products(1, "Coca Cola", 1.5, 100);
            Products.generalExists = 1; // Las estaticas no dependen de las instancias, depende de las clase

            MessageBox.Show("Existencia general: " + Products.generalExists);
        }
    }
}