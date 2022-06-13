using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SekolahMVVM.Migrations
{
    public partial class AddMataPelajaran : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MataPelajaran",
                columns: table => new
                {
                    IdPelajaran = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaPelajaran = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MataPelajaran", x => x.IdPelajaran);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MataPelajaran");
        }
    }
}
