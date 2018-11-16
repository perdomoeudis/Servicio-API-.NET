using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace servicio1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Pedido> Get()
        {
            using (var db = new chifa())
            {
                var query = from b in db.Pedido
                            orderby b.iPrecio
                            select b;
                return query.ToList();
            }

           // return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
