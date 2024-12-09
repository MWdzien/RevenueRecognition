using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevenueRecognition.Infrastructure.EF.Migrations
{
    /// <inheritdoc />
    public partial class Changed_IsDeleted_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "default",
                table: "Customers");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "default",
                table: "IndividualCustomers",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "default",
                table: "IndividualCustomers");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "default",
                table: "Customers",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
