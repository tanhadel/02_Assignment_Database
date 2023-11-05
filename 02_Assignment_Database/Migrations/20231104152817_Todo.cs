using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02_Assignment_Database.Migrations
{
    /// <inheritdoc />
    public partial class Todo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfo_Address_AddressId",
                table: "CompanyInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_TruckInfo_CompanyInfo_CompanyId",
                table: "TruckInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TruckInfo",
                table: "TruckInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "TruckInfo",
                newName: "TruckInfoEntity");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "AddressEntity");

            migrationBuilder.RenameIndex(
                name: "IX_TruckInfo_CompanyId",
                table: "TruckInfoEntity",
                newName: "IX_TruckInfoEntity_CompanyId");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "AddressEntity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TruckInfoEntity",
                table: "TruckInfoEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressEntity",
                table: "AddressEntity",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AddressEntity_AddressId",
                table: "AddressEntity",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressEntity_AddressEntity_AddressId",
                table: "AddressEntity",
                column: "AddressId",
                principalTable: "AddressEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfo_AddressEntity_AddressId",
                table: "CompanyInfo",
                column: "AddressId",
                principalTable: "AddressEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TruckInfoEntity_CompanyInfo_CompanyId",
                table: "TruckInfoEntity",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressEntity_AddressEntity_AddressId",
                table: "AddressEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfo_AddressEntity_AddressId",
                table: "CompanyInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_TruckInfoEntity_CompanyInfo_CompanyId",
                table: "TruckInfoEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TruckInfoEntity",
                table: "TruckInfoEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressEntity",
                table: "AddressEntity");

            migrationBuilder.DropIndex(
                name: "IX_AddressEntity_AddressId",
                table: "AddressEntity");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "AddressEntity");

            migrationBuilder.RenameTable(
                name: "TruckInfoEntity",
                newName: "TruckInfo");

            migrationBuilder.RenameTable(
                name: "AddressEntity",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_TruckInfoEntity_CompanyId",
                table: "TruckInfo",
                newName: "IX_TruckInfo_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TruckInfo",
                table: "TruckInfo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfo_Address_AddressId",
                table: "CompanyInfo",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TruckInfo_CompanyInfo_CompanyId",
                table: "TruckInfo",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
