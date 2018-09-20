using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DockerNetTest.Controllers
{
    [Route("api/[controller]")]
    public class AwesomeController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            var client = new HttpClient();
            // var otherContainerApi = "http://172.17.0.3/api/values";
            // var response = await client.GetAsync(otherContainerApi);
            // string responseValues = await response.Content.ReadAsStringAsync();
            return new string[] { "values", "from", "new", "what" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
