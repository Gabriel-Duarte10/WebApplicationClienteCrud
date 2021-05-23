using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationClienteCrud.Data.Migrations
{
    public partial class client : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    CLI_ID = table.Column<Guid>(nullable: false),
                    CLI_NOME = table.Column<string>(nullable: false),
                    CLI_DATANASCIMENTO = table.Column<DateTime>(nullable: false),
                    CLI_ATIVO = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.CLI_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
