using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SekolahMVVM.Models
{
    public class Siswa
    {
        [Key]
        public int IdSiswa { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public DateTime TanggalLahir { get; set; }

        [Required]
        public string TinggiBadan { get; set; }

        [Column(TypeName ="nvarchar(12)")]

        [Required]
        public string NomorHandphone { get; set; }

        [Required]
        public string Alamat { get; set; }

        [Column(TypeName ="nvarchar(1)")]
        [Required]
        public string GolonganDarah { get; set; }

        public string Hobi { get; set; }
    }
}
