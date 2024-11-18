using Microsoft.AspNetCore.Mvc;
using MusicRecordREST.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicRecordREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordsController : ControllerBase
    {
        private readonly MusicRecordRepositoryList _musicRecords;

        public MusicRecordsController(MusicRecordRepositoryList recordsRepositoryList)
        {
            _musicRecords = recordsRepositoryList;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<IEnumerable<MusicRecord>> Get()
        {
            List<MusicRecord> list = _musicRecords.GetAll();
            return Ok(list);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
