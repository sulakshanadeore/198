using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class ValuesController : ApiController
    {
        public static List<string> list = new List<string>();
        // GET api/values


        static ValuesController()
        {
            list.Add("Welcome");
            list.Add("World");
            list.Add("Hello");
            list.Add("Greetings");
        }
        public IEnumerable<string> Get()
        {

            
            //return new string[] { "value1", "value2" };
            return list;
        }

        // GET api/values/5
        public string Get(int id)
        {
            string s = null;
            if (id == 1)
            {
                s = "Welcome";
            }
            else if (id == 2)
            {
                s = "World";
            }
            else if (id == 3)
            {
                s = "Hello";
            }
            else
            {
                s = "Greetings";
            }
            //return "value" + id;
            return s;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            list.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
           //int index= list.FindIndex(i => i == id.ToString());
            list.RemoveAt(id);
            list.Insert(id, value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
          
            list.RemoveAt(id);

        }
    }
}
