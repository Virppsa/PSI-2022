using Microsoft.AspNetCore.Mvc;
using MailRemoverAPI.Util;

namespace MailRemoverAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class fileReadTesting : ControllerBase
    {
        // GET: api/<fileReadTesting>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            FileReadClass readerClassInit = new FileReadClass();
            readerClassInit.FileName = "json.json";
            readerClassInit.FilePath = @"C:\Users\Greta\Source\Repos\Virppsa\PSI-2022\MailRemoverAPI\MailRemoverAPI\Controllers\json.json";
            return new string[] { readerClassInit.readFile() };
           
            //return new string[] { "value1", "value2" };
        }

        // GET api/<fileReadTesting>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<fileReadTesting>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<fileReadTesting>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<fileReadTesting>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
