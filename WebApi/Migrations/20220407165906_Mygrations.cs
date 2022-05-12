using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class Mygrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prefix = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TokenLogout",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TokenLogout", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDisabled = table.Column<bool>(type: "bit", nullable: false),
                    IsFirstLogin = table.Column<bool>(type: "bit", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Specification = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    InstalledDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asset_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetId = table.Column<int>(type: "int", nullable: false),
                    AssignToId = table.Column<int>(type: "int", nullable: false),
                    AssignedById = table.Column<int>(type: "int", nullable: false),
                    AssignedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsInProgress = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignment_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignment_User_AssignedById",
                        column: x => x.AssignedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignment_User_AssignToId",
                        column: x => x.AssignToId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReturnRequest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetId = table.Column<int>(type: "int", nullable: false),
                    RequestedById = table.Column<int>(type: "int", nullable: false),
                    AcceptedById = table.Column<int>(type: "int", nullable: false),
                    ReturnedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnRequest_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnRequest_User_AcceptedById",
                        column: x => x.AcceptedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnRequest_User_RequestedById",
                        column: x => x.RequestedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName", "Prefix" },
                values: new object[,]
                {
                    { 1, "Laptop", "LA" },
                    { 2, "Desktop", "DE" },
                    { 3, "Printer", "PR" },
                    { 4, "Scanner", "SC" },
                    { 5, "Network", "NE" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "DoB", "Firstname", "Gender", "IsDisabled", "IsFirstLogin", "JoinDate", "Lastname", "Location", "PasswordHash", "StaffCode", "Type", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(1991, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ed", "Male", false, true, new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pendlebery", "Hochiminh", "$2a$11$UH5.MHAObnB3WbbHlg30leP5xAHrv141zBDETeQTiOTHfKOkidFRm", "SD0001", 0, "edp" },
                    { 2, new DateTime(1992, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Courtney", "Male", true, false, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "O'Loinn", "Hochiminh", "$2a$11$FqK.qEmblwYC9Y36zeNfLu7VDIxgBdvvhUWBeVIkX9tRBPw/zjz4G", "SD0002", 1, "courtneyo" },
                    { 3, new DateTime(1991, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eudora", "Female", true, false, new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Renahan", "Hanoi", "$2a$11$UC2z5FkocRovMTIiAoZbuutjF5oEZr7hxyXs87pPQdf2rrAS9Qncy", "SD0003", 0, "eudorar" },
                    { 4, new DateTime(1991, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bevin", "Male", false, false, new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hugueville", "Hochiminh", "$2a$11$Z7LNq0lQMgpvWQk.puAGHOALQVaVx.6wXo30h/ic1t6OFXFdcpr5a", "SD0004", 1, "bevinh" },
                    { 5, new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew", "Male", false, true, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Broadis", "Hochiminh", "$2a$11$1cbjCNrXEtyR1RbHEk9bge/vzse/OjTNKgdT4MOdvfqcwTRRrg922", "SD0005", 1, "andrewb" },
                    { 6, new DateTime(1994, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tades", "Male", false, false, new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zecchi", "Hanoi", "$2a$11$NE2gn5tsDJK1l1BO3j.WOuA51YKPYY3eirUR6mDlfLNMzxgBBX5WG", "SD0006", 1, "tadesz" },
                    { 7, new DateTime(1999, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vernor", "Male", true, false, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huson", "Hochiminh", "$2a$11$/fmulqSZdtBDKuqolEOCOO80.hL7rzcFs6hWCjyfYO9HntJ.0oBla", "SD0007", 1, "vernorh" },
                    { 8, new DateTime(1990, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rufe", "Male", false, false, new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yole", "Hochiminh", "$2a$11$rfVIfRNWfSdDknBbmy8g9.0D0b/laHau0t3gLfk5Kz3gpI2bawHvC", "SD0008", 1, "rufey" },
                    { 9, new DateTime(1994, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orton", "Male", true, false, new DateTime(2021, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Woodyear", "Hochiminh", "$2a$11$rnkhQCFXRofLYu8doxE4ne3iWeKH8YO7cFBYM1WDE3CfXb1aGVieW", "SD0009", 1, "ortonw" },
                    { 10, new DateTime(2000, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peyter", "Male", true, false, new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carmichael", "Hochiminh", "$2a$11$WtnVFcJSWZqdFEZVqwFPBeeJf49EdHVmZ0lsnjgj8CaEGf4wgDEfa", "SD0010", 1, "peyterc" },
                    { 11, new DateTime(1995, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kathy", "Female", false, true, new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pitchers", "Hanoi", "$2a$11$Jbwza6rsxUzIB.lvwTfC8OeWWZGQZH9v3LhbJOk0CzoURNvGpBaES", "SD0011", 1, "kathyp" },
                    { 12, new DateTime(1991, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beau", "Male", true, true, new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thorndycraft", "Hochiminh", "$2a$11$h0wTzzoJDxtDSjJ/1pUYN.2o/GLdFKZMU.uWILsSgWOIBER1POHdy", "SD0012", 1, "beaut" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asset_CategoryId",
                table: "Asset",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_AssetId",
                table: "Assignment",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_AssignedById",
                table: "Assignment",
                column: "AssignedById");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_AssignToId",
                table: "Assignment",
                column: "AssignToId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnRequest_AcceptedById",
                table: "ReturnRequest",
                column: "AcceptedById");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnRequest_AssetId",
                table: "ReturnRequest",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnRequest_RequestedById",
                table: "ReturnRequest",
                column: "RequestedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "ReturnRequest");

            migrationBuilder.DropTable(
                name: "TokenLogout");

            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
