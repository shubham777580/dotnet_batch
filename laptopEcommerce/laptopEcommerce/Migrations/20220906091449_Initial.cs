using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace laptopEcommerce.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Laptop_company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptop_company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Laptop_specs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Laptop_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Laptop_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Laptop_cpu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Laptop_gpu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LaptopCategory = table.Column<int>(type: "int", nullable: false),
                    Laptop_company_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptop_specs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laptop_specs_Laptop_company_Laptop_company_id",
                        column: x => x.Laptop_company_id,
                        principalTable: "Laptop_company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_specs_Laptop_company_id",
                table: "Laptop_specs",
                column: "Laptop_company_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Laptop_specs");

            migrationBuilder.DropTable(
                name: "Laptop_company");
        }
    }
}
