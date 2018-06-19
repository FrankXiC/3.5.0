using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TESTABP.Migrations
{
    public partial class update_Person : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AppPersons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "AppPersons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AppPersons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "AppPersons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "AppPersons");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "AppPersons");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AppPersons");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "AppPersons");
        }
    }
}
