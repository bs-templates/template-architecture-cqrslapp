using Microsoft.EntityFrameworkCore.Migrations;

namespace BAYSOFT.Migrations
{
    public partial class InitialDefaultDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SampleID",
                table: "Samples",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Samples",
                newName: "SampleID");
        }
    }
}
