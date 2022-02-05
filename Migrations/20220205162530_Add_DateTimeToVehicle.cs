using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnetWithMosh.Migrations
{
    public partial class Add_DateTimeToVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "Vehicles",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastUpdate",
                table: "Vehicles",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
