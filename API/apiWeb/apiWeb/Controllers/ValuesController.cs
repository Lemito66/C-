using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiWeb.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            // devolver la suma de dos numeros
            return new string[] { "value1", "value2" };

            //return new string[] {  };

            //return id.ToString() + id2.ToString();
        }

        // GET api/values/5
        public string Get(int id, int id2, char value)
        {

            if (value == 's')
            {
                return (id + id2).ToString();
            }
            else if (value == 'r')
            {
                return (id - id2).ToString();
            }
            else if (value == 'm')
            {
                return (id * id2).ToString();
            }
            else if (value == 'd')
            {
                return (id / id2).ToString();
            }
            else
            {
                return "error";
            }   
            //return (id + id2).ToString();
        }

        public string Get(string key)
        {
            return "Hola: " + key;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
