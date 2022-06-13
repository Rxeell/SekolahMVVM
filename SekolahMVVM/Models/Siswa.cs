using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SekolahMVVM.Models
{
    public class Siswa
    {
        [Key]
        public int IdSiswa { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string Name { get; set; }

        public string Gender { get; set; }

        public DateTime TanggalLahir { get; set; }

        public string TinggiBadan { get; set; }

        [Column(TypeName ="nvarchar(12)")]
        public string NomorHandphone { get; set; }

        public string Alamat { get; set; }

        [Column(TypeName ="nvarchar(1)")]
        public string GolonganDarah { get; set; }

        public string Hobi { get; set; }
    }
}
