using Microsoft.AspNetCore.Mvc;

namespace modul9_1302223014.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> Mahasiswa = new List<Mahasiswa>()
        {
            new Mahasiswa("Aldi","130222222",new List<string>{"KPL","Proting","PBO"},2024),
            new Mahasiswa("Mika","130222333",new List<string>{"AKA","BasDat","LogMat"},2023),
            new Mahasiswa("Faz","130222444",new List<string>{"AlPro","StrukDat","PengPro"},2022)
        };

        [HttpGet(Name = "GetMahasiswa")]
        public IEnumerable<Mahasiswa> Get()
        {
            return Mahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            if (id < 0 || id >= Mahasiswa.Count)
            {
                NotFound();
            }
            return Mahasiswa[id];
        }

        [HttpDelete]
        public void Delete(int id)
        {
            Mahasiswa.RemoveAt(id);
        }

        [HttpPost]
        public void Post(Mahasiswa mahasiswa)
        {
            Mahasiswa.Add(mahasiswa);
        }
    }
}
