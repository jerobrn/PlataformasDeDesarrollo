using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Migrations
{
    public partial class integraciondeClases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    UsuarioIDUser = table.Column<int>(nullable: true),
                    IdUsuario = table.Column<int>(nullable: false)
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
                    IdRecursos = table.Column<int>(nullable: false),
                    RecursoIDRecurso = table.Column<int>(nullable: true),
                    IDTarea = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    IDTarea = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(nullable: true),
                    Vencimiento = table.Column<DateTime>(nullable: false),
                    Estimacion = table.Column<int>(nullable: false),
                    IdRecursos = table.Column<int>(nullable: false),
                    ResponsableIDRecurso = table.Column<int>(nullable: true),
                    DetalleIDDetalle = table.Column<int>(nullable: true),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.IDTarea);
                    table.ForeignKey(
                        name: "FK_Tarea_Detalle_DetalleIDDetalle",
                        column: x => x.DetalleIDDetalle,
                        principalTable: "Detalle",
                        principalColumn: "IDDetalle",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tarea_Recurso_ResponsableIDRecurso",
                        column: x => x.ResponsableIDRecurso,
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

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_DetalleIDDetalle",
                table: "Tarea",
                column: "DetalleIDDetalle");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_ResponsableIDRecurso",
                table: "Tarea",
                column: "ResponsableIDRecurso");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Detalle");

            migrationBuilder.DropTable(
                name: "Recurso");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
