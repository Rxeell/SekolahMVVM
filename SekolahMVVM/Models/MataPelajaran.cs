using System.ComponentModel.DataAnnotations;

namespace SekolahMVVM.Models
{
    public class MataPelajaran
    {
        [Key]
        public int IdPelajaran { get; set; }

        public string NamaPelajaran { set; get; }
    }
}
