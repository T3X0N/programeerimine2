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
                    Kasutajanimi = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Parool = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
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
                    Nimetus = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    ühik = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
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
                    kuupäev = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    kirjeldus = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    kasutajanimi = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
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
                    kuupäev = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    kasutajanimi = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    hinne = table.Column<float>(type: "real", nullable: false),
                    selgitus = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
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
                    partiikuupäev = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    kirjeldus = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    koostisosad = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    logi = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    maitsemislogi = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    kokkuvõtte = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
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
                    kasutajanimi = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    kirjeldus = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    õllepruuliminejaproovipartiid = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
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
