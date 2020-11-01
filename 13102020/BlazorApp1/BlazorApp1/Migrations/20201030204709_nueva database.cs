using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Migrations
{
    public partial class nuevadatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    IDDetalle = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<string>(nullable: true),
                    Tiempo = table.Column<string>(nullable: true),
                    Recurso = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => x.IDDetalle);
                });

            migrationBuilder.CreateTable(
                name: "Recurso",
                columns: table => new
                {
                    IDRecurso = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true),
                    Usuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurso", x => x.IDRecurso);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    IDTarea = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(nullable: true),
                    Vencimiento = table.Column<string>(nullable: true),
                    Estimacion = table.Column<int>(nullable: false),
                    Responsable = table.Column<string>(nullable: true),
                    bo = table.Column<bool>(nullable: false)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalle");

            migrationBuilder.DropTable(
                name: "Recurso");

            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
