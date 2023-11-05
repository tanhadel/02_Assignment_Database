using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02_Assignment_Database.Migrations
{
    /// <inheritdoc />
    public partial class Le : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "PK_CompanyInfo",
                table: "CompanyInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressEntity",
                table: "AddressEntity");

            migrationBuilder.RenameTable(
                name: "TruckInfoEntity",
                newName: "TruckInfos");

            migrationBuilder.RenameTable(
                name: "CompanyInfo",
                newName: "CompanyInfos");

            migrationBuilder.RenameTable(
                name: "AddressEntity",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_TruckInfoEntity_CompanyId",
                table: "TruckInfos",
                newName: "IX_TruckInfos_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyInfo_AddressId",
                table: "CompanyInfos",
                newName: "IX_CompanyInfos_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_AddressEntity_AddressId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "TruckInfoEntity");

            migrationBuilder.RenameTable(
                name: "CompanyInfos",
                newName: "CompanyInfo");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "AddressEntity");

            migrationBuilder.RenameIndex(
                name: "IX_TruckInfos_CompanyId",
                table: "TruckInfoEntity",
                newName: "IX_TruckInfoEntity_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyInfos_AddressId",
                table: "CompanyInfo",
                newName: "IX_CompanyInfo_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_AddressId",
                table: "AddressEntity",
                newName: "IX_AddressEntity_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TruckInfoEntity",
                table: "TruckInfoEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyInfo",
                table: "CompanyInfo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressEntity",
                table: "AddressEntity",
                column: "Id");

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
    }
}
