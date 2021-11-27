using Microsoft.EntityFrameworkCore.Migrations;

namespace UTN.FRCU.ISI.TdP.AccountManager.Migrations
{
    public partial class adddocumentclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Clients",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Clients",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentNumber",
                table: "Clients",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DocumentType",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Accounts",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AccountMovements",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Type = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => new { x.Type, x.Number });
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_DocumentType_DocumentNumber",
                table: "Clients",
                columns: new[] { "DocumentType", "DocumentNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Document_DocumentType_DocumentNumber",
                table: "Clients",
                columns: new[] { "DocumentType", "DocumentNumber" },
                principalTable: "Document",
                principalColumns: new[] { "Type", "Number" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Document_DocumentType_DocumentNumber",
                table: "Clients");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropIndex(
                name: "IX_Clients_DocumentType_DocumentNumber",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "DocumentNumber",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "DocumentType",
                table: "Clients");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AccountMovements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
