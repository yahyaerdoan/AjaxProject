using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AjaxProject.WebUl.Migrations
{
    public partial class UpdatePropertyname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stoct",
                table: "Products",
                newName: "Stock");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Products",
                newName: "Stoct");
        }
    }
}
