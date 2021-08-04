using Microsoft.EntityFrameworkCore.Migrations;

namespace CitySelection.WebApi.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GdpPerCapita = table.Column<int>(type: "int", nullable: false),
                    InequalityIndex = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Population = table.Column<int>(type: "int", nullable: false),
                    WikipediaUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnualPM2_5Concentration = table.Column<double>(type: "float", nullable: false),
                    CostOfLivingIndex = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    ClimateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_ClimateId",
                        column: x => x.ClimateId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Climates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temperature24hAvgHigh = table.Column<double>(type: "float", nullable: false),
                    Temperature24hAvgLow = table.Column<double>(type: "float", nullable: false),
                    RainyDays = table.Column<int>(type: "int", nullable: false),
                    MonthlySunshineHours = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Climates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Climates_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "GdpPerCapita", "InequalityIndex", "Name" },
                values: new object[,]
                {
                    { 1, 35957, 28.5, "Poland" },
                    { 2, 56956, 29.699999999999999, "Germany" },
                    { 3, 60461, 26.800000000000001, "Netherlands" },
                    { 4, 99239, 28.899999999999999, "Ireland" },
                    { 5, 61478, 27.5, "Denmark" },
                    { 6, 49492, 28.5, "France" },
                    { 7, 43376, 33.399999999999999, "Italy" },
                    { 8, 32950, 34.799999999999997, "Romania" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "AnnualPM2_5Concentration", "ClimateId", "CostOfLivingIndex", "CountryId", "EnglishName", "Name", "Population", "WikipediaUrl" },
                values: new object[,]
                {
                    { 1, 17.0, null, 52, 1, "Warsaw", "Warszawa", 1794, "https://en.wikipedia.org/wiki/Warsaw" },
                    { 2, 9.5, null, 79, 2, "Munich", "München", 2606, "https://en.wikipedia.org/wiki/Munich" },
                    { 3, 11.4, null, 84, 3, "Amsterdam", "Amsterdam", 1559, "https://en.wikipedia.org/wiki/Amsterdam" },
                    { 4, 8.0999999999999996, null, 83, 4, "Dublin", "Dublin", 1173, "https://en.wikipedia.org/wiki/Dublin" },
                    { 5, 10.199999999999999, null, 94, 5, "Copenhagen", "København", 1337, "https://en.wikipedia.org/wiki/Copenhagen" },
                    { 6, 11.300000000000001, null, 79, 6, "Lyon", "Lyon", 1171, "https://en.wikipedia.org/wiki/Lyon" },
                    { 7, 20.100000000000001, null, 78, 7, "Milan", "Milano", 3400, "https://en.wikipedia.org/wiki/Milan" },
                    { 8, 16.399999999999999, null, 42, 8, "Bucharest", "București", 2155, "https://en.wikipedia.org/wiki/Bucharest" }
                });

            migrationBuilder.InsertData(
                table: "Climates",
                columns: new[] { "Id", "CityId", "MonthlySunshineHours", "RainyDays", "Temperature24hAvgHigh", "Temperature24hAvgLow" },
                values: new object[,]
                {
                    { 1, 1, 1589, 163, 24.399999999999999, -4.2000000000000002 },
                    { 2, 2, 1777, 132, 24.399999999999999, -2.5 },
                    { 3, 3, 1662, 132, 22.100000000000001, 0.80000000000000004 },
                    { 4, 4, 1452, 129, 19.5, 2.2999999999999998 },
                    { 5, 5, 1630, 157, 22.199999999999999, -0.80000000000000004 },
                    { 6, 6, 2002, 104, 27.699999999999999, 0.29999999999999999 },
                    { 7, 7, 1915, 83, 29.199999999999999, -0.90000000000000002 },
                    { 8, 8, 2112, 109, 29.800000000000001, -4.7999999999999998 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ClimateId",
                table: "Cities",
                column: "ClimateId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Climates_CityId",
                table: "Climates",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Climates");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
