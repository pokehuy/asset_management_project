using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class updateDBver2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateBy",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AssignedDate",
                table: "ReturnRequest",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "ReturnRequest",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateBy",
                table: "ReturnRequest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Category",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateBy",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Assignment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateBy",
                table: "Assignment",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssetName",
                table: "Asset",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Asset",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateBy",
                table: "Asset",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsFirstLogin", "PasswordHash" },
                values: new object[] { false, "$2a$11$0fJjrDhQRGpqP7PyC8Prpud0epb7bzWzucebmovaoIQsQtxG8fkym" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$iHGGT/BHMG.zxAl2q27iUujxng8yVJw.ExJu56omrVT12yBTLTJMW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$bcY6ujLeT4XfsJQFksTXq.qs6AxOBnxDHdRO/W5/4M0rBRzaR8yNW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "$2a$11$YGJgNfROO8fLz1.8.UEsReh.RZmfE9QD.hmlYjWg8QSu66OH5Byl2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "$2a$11$GJmqyIWs/l5aeYd3F4YVsOVG58lxMH9pVVKa/M5c4cU8e62iSqd7e");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "$2a$11$abfPuiJGMbIT3XvQDYmbHuJfYz1vP8PNranLnyt7VwYJzs7bZBXA6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "$2a$11$XPevrOMZfMuXRqs843kTw.He9UBSu7q8Vj5JuaSI7lumVTw.VNHFa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "$2a$11$1nLh.XkAYVzVKcMljPalyeukHI5jPk3s9ydSf0iU.XrzosaYIzi12");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "$2a$11$2ty47eQ7zLLOXpfGGqOGneovu.uMMx.eqgkvB5I3AEFIeXEr22s.G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "$2a$11$2NgM/zEhFTKvq/OwfCuBDeT9JdcTOVXGWhHIydjczZN8xBFysca9m");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "PasswordHash",
                value: "$2a$11$AbaffkkGFePPr3lv.AZF8.A2MnuelpPadbm2movcBXH4GuX1kYbIO");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "PasswordHash",
                value: "$2a$11$2n.nkLBTfj2LWdOdQSRqL.3Z28//vKU/r4HHFLZEcQC74P2GPnZR.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AssignedDate",
                table: "ReturnRequest");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "ReturnRequest");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "ReturnRequest");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Asset");

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AssetName",
                table: "Asset",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsFirstLogin", "PasswordHash" },
                values: new object[] { true, "$2a$11$haLE2d4P4VlNLoFXai.kn.E8J.QA2mDiN81bw2MsO/PTifkKZC5Jy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$dOrMn0kNh0uSv2V.ns8VFOm/PUvBWk8sUZpT.1Pn80bT9U2XXsTPi");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$qpp7XZeUNXwMH3tXFsGm.O4EXDCHReMoL9.huvh0fO12FHg8etIuu");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "$2a$11$J/.Zl6KRgEYY7OgDRRQbgu6phOn9tMgtWE3akuL5QYqQjmTEvCgcG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "$2a$11$s1M/GhfXDogB8RU/RgRJKet1.DdPW6byKe3Os.LTE9LckjH8UVEjy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "$2a$11$z7DTOR8axJVxT/hYwD1i3.hVkUHlXCU82ND9ZpeYmX4ZsjefTp3nW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "$2a$11$Db.jnOCDntyN0/r25FmbM.09jajApmQ/fqNOa6MOr.N6VHExejH7S");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "$2a$11$t4B.fArl8qr.Mh3bq7XYAO4nErIcHIcTNDUliBbB3u3AYKjXag0cW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "$2a$11$7GZn2cvVsCNSLzAOqd0tb.XCmzcadYHK/sv20u/UzPTiPgRqA/Ol6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "$2a$11$TzBT2yaJey7vFHzzrn38rOgq4zIBQ3OsQwcVRjjDmeE0ZAY18zQ42");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "PasswordHash",
                value: "$2a$11$zDtmeFIUgRVHzdxbQ5PU0OFPLIjG6DcHmQFy0tnH/XJduJXe/2Hr.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "PasswordHash",
                value: "$2a$11$mSeRjjFGGCMCLsfv4MrDj.Mx4SmgnU0ht3z0XUqQjBuIq06Icc8Xi");
        }
    }
}
