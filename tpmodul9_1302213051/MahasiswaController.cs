using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_1302213051
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> List = new List<Mahasiswa>
        {
            new Mahasiswa ("Jannatin Nurrohmah", "1302213051"),
            new Mahasiswa ("Aisha Putri Nuryan", "1302213038"),
            new Mahasiswa ("Jean Rika Haryadi", "1302210004"),
            new Mahasiswa ("Novita Sabila Nugraha", "1302213030"),
            new Mahasiswa ("Muthia Khairunnisa", "1302213062")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return List;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return List[id];
        }

        [HttpPost]
        public void Post(Mahasiswa mhs)
        {
            List.Add(mhs);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            List.RemoveAt(id);
        }
    }
}
