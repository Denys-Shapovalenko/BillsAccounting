using Microsoft.EntityFrameworkCore.Migrations;

namespace BillsAccounting.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    SercviceId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    ToPay = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.SercviceId);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<int>(nullable: false),
                    Overpayment = table.Column<decimal>(nullable: false),
                    HotWaterAndHeatingId = table.Column<int>(nullable: false),
                    ElectricityId = table.Column<int>(nullable: false),
                    ColdWaterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_Bills_Services_ColdWaterId",
                        column: x => x.ColdWaterId,
                        principalTable: "Services",
                        principalColumn: "SercviceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_Services_ElectricityId",
                        column: x => x.ElectricityId,
                        principalTable: "Services",
                        principalColumn: "SercviceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_Services_HotWaterAndHeatingId",
                        column: x => x.HotWaterAndHeatingId,
                        principalTable: "Services",
                        principalColumn: "SercviceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_ColdWaterId",
                table: "Bills",
                column: "ColdWaterId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_ElectricityId",
                table: "Bills",
                column: "ElectricityId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_HotWaterAndHeatingId",
                table: "Bills",
                column: "HotWaterAndHeatingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
