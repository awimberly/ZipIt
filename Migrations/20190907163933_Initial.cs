using Microsoft.EntityFrameworkCore.Migrations;

namespace ZipIt.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Zip = table.Column<string>(nullable: false),
                    Lat = table.Column<float>(nullable: false),
                    Lng = table.Column<float>(nullable: false),
                    CityName = table.Column<string>(nullable: true),
                    StateId = table.Column<string>(nullable: true),
                    StateName = table.Column<string>(nullable: true),
                    TimeZone = table.Column<string>(nullable: true),
                    CityZip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Zip);
                    table.ForeignKey(
                        name: "FK_Cities_Cities_CityZip",
                        column: x => x.CityZip,
                        principalTable: "Cities",
                        principalColumn: "Zip",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CityZip",
                table: "Cities",
                column: "CityZip");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
