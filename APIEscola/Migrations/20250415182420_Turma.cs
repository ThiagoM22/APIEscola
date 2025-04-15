using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIEscola.Migrations
{
    /// <inheritdoc />
    public partial class Turma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    TurmaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Inicio = table.Column<DateOnly>(type: "date", nullable: false),
                    Fim = table.Column<DateOnly>(type: "date", nullable: false),
                    sigla = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.TurmaId);
                    table.ForeignKey(
                        name: "FK_Turmas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "CursoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Turmas_CursoId",
                table: "Turmas",
                column: "CursoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turmas");
        }
    }
}
