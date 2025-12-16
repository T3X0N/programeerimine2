using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KooliProjekt.Application.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToKasutaja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kasutajanimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parool = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToKasutaja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToKoostisosa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nimetus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ühik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ühikuhind = table.Column<float>(type: "real", nullable: false),
                    kogus = table.Column<float>(type: "real", nullable: false),
                    summa = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToKoostisosa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToLogiKande",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kuupäev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kirjeldus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kasutaja = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToLogiKande", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToMaitsmistelogikande",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kuupäev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kasutaja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hinne = table.Column<float>(type: "real", nullable: false),
                    selgitus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToMaitsmistelogikande", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToÕllepruulimine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    partiikood = table.Column<int>(type: "int", nullable: false),
                    partiikuupäev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kirjeldus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    koostisosad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    logi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maitsemislogi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kokkuvõtte = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToÕllepruulimine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToÕllesort",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kirjeldus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    õllepruuliminejaproovipartiid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToÕllesort", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToKasutaja");

            migrationBuilder.DropTable(
                name: "ToKoostisosa");

            migrationBuilder.DropTable(
                name: "ToLogiKande");

            migrationBuilder.DropTable(
                name: "ToMaitsmistelogikande");

            migrationBuilder.DropTable(
                name: "ToÕllepruulimine");

            migrationBuilder.DropTable(
                name: "ToÕllesort");
        }
    }
}
