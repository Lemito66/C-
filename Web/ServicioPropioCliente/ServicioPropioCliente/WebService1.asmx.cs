using ServicioPropioCliente.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Resources;
using System.Web;
using System.Web.Services;

namespace ServicioPropioCliente
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
        public string queryMail(int code)
        {
            
                // otra forma de conectarme
                using (SqlConnection con = new SqlConnection(Resources.ResourceManager.GetString("db")))
                {
                    try
                    {
                        con.Open();
                        SqlCommand sqlCommand = new SqlCommand("SELECT [EmailAddress] FROM [SalesLT].[Customer] where [CustomerID] =" + code, con);

                        return sqlCommand.ExecuteScalar().ToString();
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }

                }
               
                    
                    
                }   

            
        }
    }

