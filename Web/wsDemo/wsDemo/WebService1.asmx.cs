using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace wsDemo
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public string Query(int code)
        {
            return "Empleado: " + code + " - " + "Nombre: " + "Juan Perez";
        }
        [WebMethod]
        public double queryPrice(int code )
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=tcp:srvdeltaperu.database.windows.net;Initial Catalog=dbDeltaNov2023;Persist Security Info=True;User ID=adminsql;Password=Pa$$w0rd8787");
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT [ListPrice] FROM [SalesLT].[Product] where [ProductID] =" + code, con);

                return double.Parse(sqlCommand.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                throw;
            }


        }
            
    }
}
