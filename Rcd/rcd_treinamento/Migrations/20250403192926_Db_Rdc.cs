using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rcd_treinamento.Migrations
{
    /// <inheritdoc />
    public partial class Db_Rdc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personagem",
                columns: table => new
                {
                    PersonagemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomePersonagem = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Habilidade = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagem", x => x.PersonagemId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeUsuario = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    NickName = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    PersonagemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_Personagem_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagem",
                        principalColumn: "PersonagemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PersonagemId",
                table: "Usuario",
                column: "PersonagemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Personagem");
        }
    }
}
