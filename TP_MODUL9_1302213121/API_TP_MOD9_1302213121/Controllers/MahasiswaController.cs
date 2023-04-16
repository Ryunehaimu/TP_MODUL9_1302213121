using Microsoft.AspNetCore.Mvc;

namespace API_TP_MOD9_1302213121.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> mhsList = new List<Mahasiswa>()
        {
            new Mahasiswa("Dede Rahmat Fitriansyah", "1302213121"),
            new Mahasiswa("Tangguh Laksana", "1302210025"),
            new Mahasiswa("Ghaza Gymnastiar Solihin", "1302210093"),
            new Mahasiswa("Fathur Rahman Kosasih", "1302210063"),
            new Mahasiswa("Muhammad Rizqi Firdaus", "1302210086")
        };

        // GET: api
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mhsList;
        }

        // GET api
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mhsList[id];
        }

        // POST api
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            mhsList.Add(value);
        }

        // PUT api
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa value)
        {
            mhsList[id] = value;
        }

        // DELETE api
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mhsList.RemoveAt(id);
        }
    }
}