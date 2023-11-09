using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoWebApp2
{
    public partial class InsertProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyProducts.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Insertar datos 
            // 1. Crear una instancia de la clase de acceso a datos
            // 2. Llamar al método de inserción
            // 3. Redireccionar a la página de productos

            try
            {
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = "Data Source=tcp:srvdeltaperu.database.windows.net;Initial Catalog=dbDeltaNov2023;Persist Security Info=True;User ID=adminsql;Password=Pa$$w0rd8787";
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO [dbo].[misProductos] ([Nombre] ,[Precio] ,[Existencias])  VALUES('" + this.txtName.Text + "'," + double.Parse(this.txtPrice.Text).ToString() + ", " + int.Parse(this.txtExists.Text).ToString() + ")";
                cmd.ExecuteNonQuery();
                Response.Write("REGISTRO AGREGADO CON EXITO !!!!!");
                txtName.Text = "";
                txtPrice.Text = "";
                txtExists.Text = "";
                conn.Close();
            }
            catch (Exception)
            {

                Response.Write("ERROR AL AGREGAR REGISTRO !!!!!");
            }
        }
    }
}