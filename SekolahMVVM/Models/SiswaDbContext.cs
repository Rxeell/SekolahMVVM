using Microsoft.EntityFrameworkCore;

namespace SekolahMVVM.Models
{
    public class SiswaDbContext:DbContext
    {
        public SiswaDbContext(DbContextOptions<SiswaDbContext> options)  : base (options)  
        {}

        public DbSet<Siswa> Siswa { get; set; }
        public DbSet<MataPelajaran> MataPelajaran { get; set; }
    }
}
