using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevenueRecognition.Infrastructure.EF.Migrations
{
    /// <inheritdoc />
    public partial class Customer_Email_PrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyCustomers_Customers_CustomerId",
                schema: "default",
                table: "CompanyCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_IndividualCustomers_Customers_CustomerId",
                schema: "default",
                table: "IndividualCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IndividualCustomers",
                schema: "default",
                table: "IndividualCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                schema: "default",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyCustomers",
                schema: "default",
                table: "CompanyCustomers");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                schema: "default",
                table: "IndividualCustomers");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                schema: "default",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                schema: "default",
                table: "CompanyCustomers");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "default",
                table: "IndividualCustomers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "default",
                table: "CompanyCustomers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IndividualCustomers",
                schema: "default",
                table: "IndividualCustomers",
                column: "Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                schema: "default",
                table: "Customers",
                column: "Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyCustomers",
                schema: "default",
                table: "CompanyCustomers",
                column: "Email");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyCustomers_Customers_Email",
                schema: "default",
                table: "CompanyCustomers",
                column: "Email",
                principalSchema: "default",
                principalTable: "Customers",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IndividualCustomers_Customers_Email",
                schema: "default",
                table: "IndividualCustomers",
                column: "Email",
                principalSchema: "default",
                principalTable: "Customers",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyCustomers_Customers_Email",
                schema: "default",
                table: "CompanyCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_IndividualCustomers_Customers_Email",
                schema: "default",
                table: "IndividualCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IndividualCustomers",
                schema: "default",
                table: "IndividualCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                schema: "default",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyCustomers",
                schema: "default",
                table: "CompanyCustomers");

            migrationBuilder.DropColumn(
                name: "Email",
                schema: "default",
                table: "IndividualCustomers");

            migrationBuilder.DropColumn(
                name: "Email",
                schema: "default",
                table: "CompanyCustomers");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                schema: "default",
                table: "IndividualCustomers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                schema: "default",
                table: "Customers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                schema: "default",
                table: "CompanyCustomers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_IndividualCustomers",
                schema: "default",
                table: "IndividualCustomers",
                column: "CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                schema: "default",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyCustomers",
                schema: "default",
                table: "CompanyCustomers",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyCustomers_Customers_CustomerId",
                schema: "default",
                table: "CompanyCustomers",
                column: "CustomerId",
                principalSchema: "default",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IndividualCustomers_Customers_CustomerId",
                schema: "default",
                table: "IndividualCustomers",
                column: "CustomerId",
                principalSchema: "default",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
