using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class updateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StaffCode",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreateBy",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "TokenLogout",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnedDate",
                table: "ReturnRequest",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "AcceptedById",
                table: "ReturnRequest",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "ReturnRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreateBy",
                table: "ReturnRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreateBy",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Assignment",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Assignment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "Assignment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreateBy",
                table: "Assignment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Asset",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssetCode",
                table: "Asset",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "Asset",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreateBy",
                table: "Asset",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$haLE2d4P4VlNLoFXai.kn.E8J.QA2mDiN81bw2MsO/PTifkKZC5Jy");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "ReturnRequest");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "ReturnRequest");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Asset");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StaffCode",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "TokenLogout",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnedDate",
                table: "ReturnRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AcceptedById",
                table: "ReturnRequest",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Assignment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Assignment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Asset",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AssetCode",
                table: "Asset",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$UH5.MHAObnB3WbbHlg30leP5xAHrv141zBDETeQTiOTHfKOkidFRm");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$FqK.qEmblwYC9Y36zeNfLu7VDIxgBdvvhUWBeVIkX9tRBPw/zjz4G");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$UC2z5FkocRovMTIiAoZbuutjF5oEZr7hxyXs87pPQdf2rrAS9Qncy");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "$2a$11$Z7LNq0lQMgpvWQk.puAGHOALQVaVx.6wXo30h/ic1t6OFXFdcpr5a");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "$2a$11$1cbjCNrXEtyR1RbHEk9bge/vzse/OjTNKgdT4MOdvfqcwTRRrg922");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "$2a$11$NE2gn5tsDJK1l1BO3j.WOuA51YKPYY3eirUR6mDlfLNMzxgBBX5WG");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "$2a$11$/fmulqSZdtBDKuqolEOCOO80.hL7rzcFs6hWCjyfYO9HntJ.0oBla");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "$2a$11$rfVIfRNWfSdDknBbmy8g9.0D0b/laHau0t3gLfk5Kz3gpI2bawHvC");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "$2a$11$rnkhQCFXRofLYu8doxE4ne3iWeKH8YO7cFBYM1WDE3CfXb1aGVieW");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "$2a$11$WtnVFcJSWZqdFEZVqwFPBeeJf49EdHVmZ0lsnjgj8CaEGf4wgDEfa");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "PasswordHash",
                value: "$2a$11$Jbwza6rsxUzIB.lvwTfC8OeWWZGQZH9v3LhbJOk0CzoURNvGpBaES");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "PasswordHash",
                value: "$2a$11$h0wTzzoJDxtDSjJ/1pUYN.2o/GLdFKZMU.uWILsSgWOIBER1POHdy");
        }
    }
}
