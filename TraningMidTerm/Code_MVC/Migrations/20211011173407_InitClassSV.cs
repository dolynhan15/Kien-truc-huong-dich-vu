using Microsoft.EntityFrameworkCore.Migrations;

namespace Code_MVC.Migrations
{
    public partial class InitClassSV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name_Lop",
                table: "Class_SV",
                newName: "Name_Lop");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name_Lop",
                table: "Class_SV",
                newName: "name_Lop");
        }
    }
}
