using Microsoft.EntityFrameworkCore.Migrations;

namespace EBPlatform.Migrations
{
    public partial class DelAttriProductPComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PComment",
                table: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PComment",
                table: "Product",
                nullable: true);
        }
    }
}
