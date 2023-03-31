using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloMvcApp.Migrations
{
    public partial class newprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brans",
                table: "tblOgretmenler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sinif",
                table: "tblOgrenciler",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brans",
                table: "tblOgretmenler");

            migrationBuilder.DropColumn(
                name: "Sinif",
                table: "tblOgrenciler");
        }
    }
}
