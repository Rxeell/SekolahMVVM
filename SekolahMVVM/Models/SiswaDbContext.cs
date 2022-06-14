using Microsoft.EntityFrameworkCore;

namespace SekolahMVVM.Models
{
    public class SiswaDbContext : DbContext
    {
        public SiswaDbContext(DbContextOptions<SiswaDbContext> options) : base(options)
        { }

        public DbSet<Siswa> Siswa { get; set; }
        public DbSet<MataPelajaran> MataPelajaran { get; set; }
        public DbSet<SiswaPelajaran> SiswaPelajarans { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // configures one-to-many relationship
        //    modelBuilder.Entity<SiswaPelajaran>()
        //        .HasRequired<Siswa>(s => s.Siswa)
        //        .WithMany(g => g.Students)
        //        .HasForeignKey<int>(s => s.CurrentGradeId);
        //}

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<SiswaPelajaran>().HasKey(c => new { c.IdPelajaran, c.IdSiswa });

        //    base.OnModelCreating(builder);
        //}
    }
}