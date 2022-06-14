using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SekolahMVVM.Migrations
{
    public partial class addrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SiswaPelajarans_IdPelajaran",
                table: "SiswaPelajarans",
                column: "IdPelajaran");

            migrationBuilder.CreateIndex(
                name: "IX_SiswaPelajarans_IdSiswa",
                table: "SiswaPelajarans",
                column: "IdSiswa");

            migrationBuilder.AddForeignKey(
                name: "FK_SiswaPelajarans_MataPelajaran_IdPelajaran",
                table: "SiswaPelajarans",
                column: "IdPelajaran",
                principalTable: "MataPelajaran",
                principalColumn: "IdPelajaran",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiswaPelajarans_Siswa_IdSiswa",
                table: "SiswaPelajarans",
                column: "IdSiswa",
                principalTable: "Siswa",
                principalColumn: "IdSiswa",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SiswaPelajarans_MataPelajaran_IdPelajaran",
                table: "SiswaPelajarans");

            migrationBuilder.DropForeignKey(
                name: "FK_SiswaPelajarans_Siswa_IdSiswa",
                table: "SiswaPelajarans");

            migrationBuilder.DropIndex(
                name: "IX_SiswaPelajarans_IdPelajaran",
                table: "SiswaPelajarans");

            migrationBuilder.DropIndex(
                name: "IX_SiswaPelajarans_IdSiswa",
                table: "SiswaPelajarans");
        }
    }
}
