using Microsoft.AspNetCore.Mvc;

namespace modul10_1302223083.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController
    {
        // inisialisasi data mahasiswa berupa anggota kelompok
        private static List<Mahasiswa> mahasiswa = new List<Mahasiswa>()
        {
            new("Aaron Joseph Karel Daimbani","1302223083", "KPL", "2024"),
            new("Indra Mahesa","1302220067", "PBO", "2024"),
            new("Reinhard Efraim Situmeang","1302220001", "IMK", "2024"),
            new("Rifqi Alghifari","1302223028", "BasDat", "2024"),
            new("Wildan Syukri Niam","1302220005", "PP", "2024"),
            new("Yazid Al Ghozali","1302223047", "DasJarKom", "2024"),
        };

        // menggunakan IEnumerable untuk menampilkan seluruh list
        [HttpGet(Name = "GetMahasiswa")]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswa;
        }

        // menggunakan post untuk menambah data pada list mahasiswa
        [HttpPost]
        public void post([FromBody] Mahasiswa ListMahasiswa)
        {
            mahasiswa.Add(ListMahasiswa);
        }
        [HttpGet("{id}")]

        // menampilan data mahasiwa berdasarkan id yang diinput
        public Mahasiswa Get(int id)
        {
            return mahasiswa[id];
        }
        [HttpDelete("{id}")]


        // menggunakan delete untuk menghapus data list berdasarkan id
        public void delete(int id)
        {
            mahasiswa.RemoveAt(id);
        }

    }
}