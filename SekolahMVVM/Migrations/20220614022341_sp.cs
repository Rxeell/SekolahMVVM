using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SekolahMVVM.Migrations
{
    public partial class sp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SiswaPelajarans",
                columns: table => new
                {
                    IdSiswaPelajaran = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSiswa = table.Column<int>(type: "int", nullable: false),
                    IdPelajaran = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiswaPelajarans", x => x.IdSiswaPelajaran);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiswaPelajarans");
        }
    }
}
