using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace laptopEcommerce.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Laptop_specs_Laptop_company_Laptop_company_id",
                table: "Laptop_specs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Laptop_specs",
                table: "Laptop_specs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Laptop_company",
                table: "Laptop_company");

            migrationBuilder.RenameTable(
                name: "Laptop_specs",
                newName: "laptop_Specs");

            migrationBuilder.RenameTable(
                name: "Laptop_company",
                newName: "laptop_company_variable");

            migrationBuilder.RenameIndex(
                name: "IX_Laptop_specs_Laptop_company_id",
                table: "laptop_Specs",
                newName: "IX_laptop_Specs_Laptop_company_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_laptop_Specs",
                table: "laptop_Specs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_laptop_company_variable",
                table: "laptop_company_variable",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_laptop_Specs_laptop_company_variable_Laptop_company_id",
                table: "laptop_Specs",
                column: "Laptop_company_id",
                principalTable: "laptop_company_variable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_laptop_Specs_laptop_company_variable_Laptop_company_id",
                table: "laptop_Specs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_laptop_Specs",
                table: "laptop_Specs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_laptop_company_variable",
                table: "laptop_company_variable");

            migrationBuilder.RenameTable(
                name: "laptop_Specs",
                newName: "Laptop_specs");

            migrationBuilder.RenameTable(
                name: "laptop_company_variable",
                newName: "Laptop_company");

            migrationBuilder.RenameIndex(
                name: "IX_laptop_Specs_Laptop_company_id",
                table: "Laptop_specs",
                newName: "IX_Laptop_specs_Laptop_company_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Laptop_specs",
                table: "Laptop_specs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Laptop_company",
                table: "Laptop_company",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Laptop_specs_Laptop_company_Laptop_company_id",
                table: "Laptop_specs",
                column: "Laptop_company_id",
                principalTable: "Laptop_company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
