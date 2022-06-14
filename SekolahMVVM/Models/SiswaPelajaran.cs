using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SekolahMVVM.Models
{
    public class SiswaPelajaran
    {
        [Key]
        public int IdSiswaPelajaran { get; set; }

        [ForeignKey("Siswa")]
        public int IdSiswa { get; set; }
        public Siswa Siswa { get; set; }

        [ForeignKey("MataPelajaran")]
        public int IdPelajaran { get; set; } 
        public MataPelajaran MataPelajaran { get; set; }    
    }
}
