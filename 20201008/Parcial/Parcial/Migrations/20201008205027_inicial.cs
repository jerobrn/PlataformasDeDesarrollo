using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    IDTarea = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(nullable: true),
                    Vencimiento = table.Column<DateTime>(nullable: false),
                    Estimacion = table.Column<int>(nullable: false),
                    Responsable = table.Column<string>(nullable: true),
                    String = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.IDTarea);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IDUser = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    User = table.Column<string>(nullable: true),
                    Clave = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IDUser);
                });

            migrationBuilder.CreateTable(
                name: "Recurso",
                columns: table => new
                {
                    IDRecurso = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true),
                    UsuarioIDUser = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurso", x => x.IDRecurso);
                    table.ForeignKey(
                        name: "FK_Recurso_Usuario_UsuarioIDUser",
                        column: x => x.UsuarioIDUser,
                        principalTable: "Usuario",
                        principalColumn: "IDUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    IDDetalle = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Tiempo = table.Column<string>(nullable: true),
                    RecursoIDRecurso = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => x.IDDetalle);
                    table.ForeignKey(
                        name: "FK_Detalle_Recurso_RecursoIDRecurso",
                        column: x => x.RecursoIDRecurso,
                        principalTable: "Recurso",
                        principalColumn: "IDRecurso",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_RecursoIDRecurso",
                table: "Detalle",
                column: "RecursoIDRecurso");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_UsuarioIDUser",
                table: "Recurso",
                column: "UsuarioIDUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalle");

            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Recurso");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
