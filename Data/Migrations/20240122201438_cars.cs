using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class cars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
    name: "cars",
    columns: table => new
    {
        CarId = table.Column<int>(type: "INTEGER", nullable: false)
            .Annotation("Sqlite:Autoincrement", true),
        Model = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
        Manufacturer = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
        EngineCapacity = table.Column<double>(type: "REAL", nullable: false),
        Power = table.Column<int>(type: "INTEGER", nullable: false),
        RegistrationNumber = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
        Owner = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_cars", x => x.CarId);
    });

            migrationBuilder.InsertData(
    table: "cars",
    columns: new[] { "Model", "Manufacturer", "EngineCapacity", "Power", "RegistrationNumber", "Owner" },
    values: new object[,]
    {
        { "Volvo XC60", "Volvo", 2.0, 250, "XD 3248", "Adam Nowak" },
        { "Audi A4", "Audi", 1.8, 200, "KLI 46578", "Jan Nowak" }
    });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cars");

            migrationBuilder.DeleteData(
        table: "cars",
        keyColumn: "CarId",
        keyValue: 1);

            migrationBuilder.DeleteData(
                table: "cars",
                keyColumn: "CarId",
                keyValue: 2);

        }
    }
}
