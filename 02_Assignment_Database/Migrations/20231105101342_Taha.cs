using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02_Assignment_Database.Migrations
{
    /// <inheritdoc />
    public partial class Taha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Addresses_AddressId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfos_Addresses_AddressId",
                table: "CompanyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_TruckInfos_CompanyInfos_CompanyId",
                table: "TruckInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TruckInfos",
                table: "TruckInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyInfos",
                table: "CompanyInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "TruckInfos",
                newName: "TruckInfo");

            migrationBuilder.RenameTable(
                name: "CompanyInfos",
                newName: "CompanyInfo");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_TruckInfos_CompanyId",
                table: "TruckInfo",
                newName: "IX_TruckInfo_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyInfos_AddressId",
                table: "CompanyInfo",
                newName: "IX_CompanyInfo_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_AddressId",
                table: "Address",
                newName: "IX_Address_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TruckInfo",
                table: "TruckInfo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyInfo",
                table: "CompanyInfo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Address_AddressId",
                table: "Address",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Address_AddressId",
                table: "Address");

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
                name: "PK_CompanyInfo",
                table: "CompanyInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "TruckInfo",
                newName: "TruckInfos");

            migrationBuilder.RenameTable(
                name: "CompanyInfo",
                newName: "CompanyInfos");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_TruckInfo_CompanyId",
                table: "TruckInfos",
                newName: "IX_TruckInfos_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyInfo_AddressId",
                table: "CompanyInfos",
                newName: "IX_CompanyInfos_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_AddressId",
                table: "Addresses",
                newName: "IX_Addresses_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TruckInfos",
                table: "TruckInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyInfos",
                table: "CompanyInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Addresses_AddressId",
                table: "Addresses",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfos_Addresses_AddressId",
                table: "CompanyInfos",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TruckInfos_CompanyInfos_CompanyId",
                table: "TruckInfos",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
