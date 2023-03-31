using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloMvcApp.Migrations
{
    public partial class createOgrtCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Ogretmenler",
                table: "Ogretmenler");

            migrationBuilder.RenameTable(
                name: "Ogretmenler",
                newName: "tblOgretmenler");

            migrationBuilder.AlterColumn<string>(
                name: "Tckimlik",
                table: "tblOgretmenler",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Soyad",
                table: "tblOgretmenler",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "tblOgretmenler",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblOgretmenler",
                table: "tblOgretmenler",
                column: "Ogretmenid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblOgretmenler",
                table: "tblOgretmenler");

            migrationBuilder.RenameTable(
                name: "tblOgretmenler",
                newName: "Ogretmenler");

            migrationBuilder.AlterColumn<string>(
                name: "Tckimlik",
                table: "Ogretmenler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Soyad",
                table: "Ogretmenler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Ogretmenler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ogretmenler",
                table: "Ogretmenler",
                column: "Ogretmenid");
        }
    }
}
