using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnetWithMosh.Migrations
{
    public partial class ConvertMakeNameDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Makes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
