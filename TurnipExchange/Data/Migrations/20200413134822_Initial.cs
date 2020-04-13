using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TurnipExchange.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeZone",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Created = table.Column<DateTime>(nullable: false),
                    Abbreviation = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UtcOffset = table.Column<string>(nullable: true),
                    UtcOffsetHours = table.Column<int>(nullable: false),
                    UtcOffsetMinutes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeZone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    SwitchAccountName = table.Column<string>(nullable: true),
                    SwitchFriendCode = table.Column<string>(nullable: true),
                    AcVillagerName = table.Column<string>(nullable: true),
                    AcIslandName = table.Column<string>(nullable: true),
                    Reputation = table.Column<int>(nullable: false),
                    TimeZoneId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_TimeZone_TimeZoneId",
                        column: x => x.TimeZoneId,
                        principalTable: "TimeZone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleOffer",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Created = table.Column<DateTime>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DodoCode = table.Column<string>(maxLength: 5, nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOffer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleOffer_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 1L, "ACDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australian Central Daylight Savings Time", "UTC+10:30", 10, 30 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 130L, "MYT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malaysia Time", "UTC+08", 8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 131L, "NCT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Caledonia Time", "UTC+11", 11, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 132L, "NDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Newfoundland Daylight Time", "UTC−02:30", -2, 30 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 133L, "NFT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norfolk Island Time", "UTC+11", 11, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 134L, "NOVT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Novosibirsk Time", "UTC+07", 7, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 135L, "NPT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nepal Time", "UTC+05:45", 5, 45 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 136L, "NST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Newfoundland Standard Time", "UTC−03:30", -3, 30 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 137L, "NT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Newfoundland Time", "UTC−03:30", -3, 30 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 138L, "NUT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Niue Time", "UTC−11", -11, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 139L, "NZDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Zealand Daylight Time", "UTC+13", 13, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 140L, "NZST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Zealand Standard Time", "UTC+12", 12, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 141L, "OMST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omsk Time", "UTC+06", 6, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 142L, "ORAT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oral Time", "UTC+05", 5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 143L, "PDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pacific Daylight Time (North America)", "UTC−07", -7, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 144L, "PET", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peru Time", "UTC−05", -5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 145L, "PETT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kamchatka Time", "UTC+12", 12, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 146L, "PGT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Papua New Guinea Time", "UTC+10", 10, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 147L, "PHOT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phoenix Island Time", "UTC+13", 13, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 148L, "PHT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philippine Time", "UTC+08", 8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 149L, "PKT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pakistan Standard Time", "UTC+05", 5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 150L, "PMDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saint Pierre and Miquelon Daylight Time", "UTC−02", -2, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 129L, "MVT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maldives Time", "UTC+05", 5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 151L, "PMST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saint Pierre and Miquelon Standard Time", "UTC−03", -3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 128L, "MUT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mauritius Time", "UTC+04", 4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 126L, "MST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malaysia Standard Time", "UTC+08", 8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 105L, "IST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Israel Standard Time", "UTC+02", 2, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 106L, "JST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japan Standard Time", "UTC+09", 9, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 107L, "KALT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kaliningrad Time", "UTC+02", 2, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 108L, "KGT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kyrgyzstan Time", "UTC+06", 6, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 109L, "KOST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kosrae Time", "UTC+11", 11, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 110L, "KRAT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Krasnoyarsk Time", "UTC+07", 7, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 111L, "KST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Korea Standard Time", "UTC+09", 9, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 112L, "LHST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lord Howe Standard Time", "UTC+10:30", 10, 30 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 113L, "LHST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lord Howe Summer Time", "UTC+11", 11, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 114L, "LINT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Line Islands Time", "UTC+14", 14, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 115L, "MAGT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magadan Time", "UTC+12", 12, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 116L, "MART", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marquesas Islands Time", "UTC−09:30", -9, 30 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 117L, "MAWT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mawson Station Time", "UTC+05", 5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 118L, "MDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mountain Daylight Time (North America)", "UTC−06", -6, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 119L, "MET", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Middle European Time", "UTC+01", 1, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 120L, "MEST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Middle European Summer Time", "UTC+02", 2, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 121L, "MHT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marshall Islands Time", "UTC+12", 12, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 122L, "MIST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Macquarie Island Station Time", "UTC+11", 11, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 123L, "MIT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marquesas Islands Time", "UTC−09:30", -9, 30 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 124L, "MMT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Myanmar Standard Time", "UTC+06:30", 6, 30 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 125L, "MSK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moscow Time", "UTC+03", 3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 127L, "MST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mountain Standard Time (North America)", "UTC−07", -7, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 152L, "PONT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pohnpei Standard Time", "UTC+11", 11, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 153L, "PST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pacific Standard Time (North America)", "UTC−08", -8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 154L, "PST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philippine Standard Time", "UTC+08", 8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 181L, "TVT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tuvalu Time", "UTC+12", 12, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 182L, "ULAST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ulaanbaatar Summer Time", "UTC+09", 9, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 183L, "ULAT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ulaanbaatar Standard Time", "UTC+08", 8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 184L, "UTC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coordinated Universal Time", "UTC±00", 0, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 185L, "UYST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uruguay Summer Time", "UTC−02", -2, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 186L, "UYT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uruguay Standard Time", "UTC−03", -3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 187L, "UZT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uzbekistan Time", "UTC+05", 5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 188L, "VET", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Venezuelan Standard Time", "UTC−04", -4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 189L, "VLAT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vladivostok Time", "UTC+10", 10, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 190L, "VOLT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volgograd Time", "UTC+04", 4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 191L, "VOST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vostok Station Time", "UTC+06", 6, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 192L, "VUT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vanuatu Time", "UTC+11", 11, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 193L, "WAKT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wake Island Time", "UTC+12", 12, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 194L, "WAST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "West Africa Summer Time", "UTC+02", 2, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 195L, "WAT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "West Africa Time", "UTC+01", 1, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 196L, "WEST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Western European Summer Time", "UTC+01", 1, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 197L, "WET", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Western European Time", "UTC±00", 0, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 198L, "WIT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Western Indonesian Time", "UTC+07", 7, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 199L, "WGST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "West Greenland Summer Time", "UTC-02", -2, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 200L, "WGT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "West Greenland Time", "UTC-03", -3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 201L, "WST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Western Standard Time", "UTC+08", 8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 180L, "TOT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tonga Time", "UTC+13", 13, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 179L, "TRT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkey Time", "UTC+03", 3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 178L, "TMT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkmenistan Time", "UTC+05", 5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 177L, "TLT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Timor Leste Time", "UTC+09", 9, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 155L, "PYST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paraguay Summer Time", "UTC−03", -3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 156L, "PYT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paraguay Time", "UTC−04", -4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 157L, "RET", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Réunion Time", "UTC+04", 4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 158L, "ROTT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rothera Research Station Time", "UTC−03", -3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 159L, "SAKT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sakhalin Island Time", "UTC+11", 11, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 160L, "SAMT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samara Time", "UTC+04", 4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 161L, "SAST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "South African Standard Time", "UTC+02", 2, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 162L, "SBT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Solomon Islands Time", "UTC+11", 11, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 163L, "SCT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seychelles Time", "UTC+04", 4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 164L, "SDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samoa Daylight Time", "UTC−10", -10, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 104L, "IST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Irish Standard Time", "UTC+01", 1, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 165L, "SGT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Singapore Time", "UTC+08", 8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 167L, "SRET", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Srednekolymsk Time", "UTC+11", 11, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 168L, "SRT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suriname Time", "UTC−03", -3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 169L, "SST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samoa Standard Time", "UTC−11", -11, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 170L, "SST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Singapore Standard Time", "UTC+08", 8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 171L, "SYOT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Showa Station Time", "UTC+03", 3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 172L, "TAHT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tahiti Time", "UTC−10", -10, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 173L, "THA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thailand Standard Time", "UTC+07", 7, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 174L, "TFT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "French Southern and Antarctic Time", "UTC+05", 5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 175L, "TJT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tajikistan Time", "UTC+05", 5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 176L, "TKT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tokelau Time", "UTC+13", 13, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 166L, "SLST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sri Lanka Standard Time", "UTC+05:30", 5, 30 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 202L, "YAKT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yakutsk Time", "UTC+09", 9, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 103L, "IST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indian Standard Time", "UTC+05:30", 5, 30 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 101L, "IRKT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Irkutsk Time", "UTC+08", 8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 28L, "BRST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brasília Summer Time", "UTC−02", -2, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 29L, "BRT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brasília Time", "UTC−03", -3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 30L, "BST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bangladesh Standard Time", "UTC+06", 6, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 31L, "BST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bougainville Standard Time", "UTC+11", 11, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 32L, "BST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "British Summer Time (British Standard Time from Feb 1968 to Oct 1971)", "UTC+01", 1, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 33L, "BTT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bhutan Time", "UTC+06", 6, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 34L, "CAT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Central Africa Time", "UTC+02", 2, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 35L, "CCT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cocos Islands Time", "UTC+06:30", 6, 30 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 36L, "CDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Central Daylight Time (North America)", "UTC−05", -5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 37L, "CDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cuba Daylight Time", "UTC−04", -4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 38L, "CEST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Central European Summer Time (Cf. HAEC)", "UTC+02", 2, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 39L, "CET", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Central European Time", "UTC+01", 1, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 40L, "CHADT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chatham Daylight Time", "UTC+13:45", 13, 45 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 41L, "CHAST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chatham Standard Time", "UTC+12:45", 12, 45 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 42L, "CHOT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Choibalsan Standard Time", "UTC+08", 8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 43L, "CHOST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Choibalsan Summer Time", "UTC+09", 9, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 44L, "CHST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chamorro Standard Time", "UTC+10", 10, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 45L, "CHUT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chuuk Time", "UTC+10", 10, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 46L, "CIST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clipperton Island Standard Time", "UTC−08", -8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 47L, "CIT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Central Indonesia Time", "UTC+08", 8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 48L, "CKT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cook Island Time", "UTC−10", -10, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 27L, "BOT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bolivia Time", "UTC−04", -4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 49L, "CLST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chile Summer Time", "UTC−03", -3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 26L, "BIT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baker Island Time", "UTC−12", -12, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 24L, "BDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brunei Time", "UTC+08", 8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 2L, "ACST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australian Central Standard Time", "UTC+09:30", 9, 30 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 3L, "ACT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acre Time", "UTC−05", -5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 4L, "ADT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlantic Daylight Time", "UTC−03", -3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 5L, "AEDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australian Eastern Daylight Savings Time", "UTC+11", 11, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 6L, "AEST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australian Eastern Standard Time", "UTC+10", 10, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 8L, "AFT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afghanistan Time", "UTC+04:30", 4, 30 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 9L, "AKDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alaska Daylight Time", "UTC−08", -8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 10L, "AKST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alaska Standard Time", "UTC−09", -9, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 11L, "ALMT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alma-Ata Time", "UTC+06", 6, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 12L, "AMST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon Summer Time (Brazil)", "UTC−03", -3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 13L, "AMT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon Time (Brazil)", "UTC−04", -4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 14L, "AMT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armenia Time", "UTC+04", 4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 15L, "ANAT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anadyr Time", "UTC+12", 12, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 16L, "AQTT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aqtobe Time", "UTC+05", 5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 17L, "ART", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Argentina Time", "UTC−03", -3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 18L, "AST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arabia Standard Time", "UTC+03", 3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 19L, "AST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlantic Standard Time", "UTC−04", -4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 20L, "AWST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australian Western Standard Time", "UTC+08", 8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 21L, "AZOST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Azores Summer Time", "UTC±00", 0, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 22L, "AZOT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Azores Standard Time", "UTC−01", -1, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 23L, "AZT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Azerbaijan Time", "UTC+04", 4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 25L, "BIOT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "British Indian Ocean Time", "UTC+06", 6, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 50L, "CLT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chile Standard Time", "UTC−04", -4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 51L, "COST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colombia Summer Time", "UTC−04", -4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 52L, "COT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colombia Time", "UTC−05", -5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 79L, "GALT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Galápagos Time", "UTC−06", -6, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 80L, "GAMT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gambier Islands Time", "UTC−09", -9, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 81L, "GET", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Georgia Standard Time", "UTC+04", 4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 82L, "GFT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "French Guiana Time", "UTC−03", -3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 83L, "GILT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gilbert Island Time", "UTC+12", 12, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 84L, "GIT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gambier Island Time", "UTC−09", -9, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 85L, "GMT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greenwich Mean Time", "UTC±00", 0, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 86L, "GST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Georgia and the South Sandwich Islands Time", "UTC−02", -2, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 87L, "GST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gulf Standard Time", "UTC+04", 4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 88L, "GYT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guyana Time", "UTC−04", -4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 89L, "HDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hawaii–Aleutian Daylight Time", "UTC−09", -9, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 90L, "HAEC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heure Avancée d'Europe Centrale French-language name for CEST", "UTC+02", 2, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 91L, "HST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hawaii–Aleutian Standard Time", "UTC−10", -10, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 92L, "HKT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hong Kong Time", "UTC+08", 8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 93L, "HMT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heard and McDonald Islands Time", "UTC+05", 5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 95L, "HOVT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hovd Time", "UTC+07", 7, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 96L, "ICT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indochina Time", "UTC+07", 7, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 97L, "IDLW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "International Day Line West time zone", "UTC−12", -12, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 98L, "IDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Israel Daylight Time", "UTC+03", 3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 99L, "IOT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indian Ocean Time", "UTC+03", 3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 100L, "IRDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iran Daylight Time", "UTC+04:30", 4, 30 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 78L, "FNT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fernando de Noronha Time", "UTC−02", -2, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 77L, "FKT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Falkland Islands Time", "UTC−04", -4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 76L, "FKST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Falkland Islands Summer Time", "UTC−03", -3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 75L, "FJT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fiji Time", "UTC+12", 12, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 53L, "CST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Central Standard Time (North America)", "UTC−06", -6, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 54L, "CST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "China Standard Time", "UTC+08", 8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 55L, "CST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cuba Standard Time", "UTC−05", -5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 56L, "CT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "China Time", "UTC+08", 8, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 57L, "CVT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cape Verde Time", "UTC−01", -1, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 58L, "CXT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christmas Island Time", "UTC+07", 7, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 59L, "DAVT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davis Time", "UTC+07", 7, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 60L, "DDUT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dumont d'Urville Time", "UTC+10", 10, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 61L, "DFT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AIX-specific equivalent of Central European Time[NB 1]", "UTC+01", 1, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 62L, "EASST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Easter Island Summer Time", "UTC−05", -5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 102L, "IRST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iran Standard Time", "UTC+03:30", 3, 30 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 63L, "EAST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Easter Island Standard Time", "UTC−06", -6, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 65L, "ECT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eastern Caribbean Time (does not recognise DST)", "UTC−04", -4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 66L, "ECT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ecuador Time", "UTC−05", -5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 67L, "EDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eastern Daylight Time (North America)", "UTC−04", -4, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 68L, "EEST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eastern European Summer Time", "UTC+03", 3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 69L, "EET", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eastern European Time", "UTC+02", 2, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 70L, "EGST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eastern Greenland Summer Time", "UTC±00", 0, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 71L, "EGT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eastern Greenland Time", "UTC−01", -1, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 72L, "EIT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eastern Indonesian Time", "UTC+09", 9, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 73L, "EST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eastern Standard Time (North America)", "UTC−05", -5, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 74L, "FET", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Further-eastern European Time", "UTC+03", 3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 64L, "EAT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "East Africa Time", "UTC+03", 3, 0 });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "Abbreviation", "Created", "Name", "UtcOffset", "UtcOffsetHours", "UtcOffsetMinutes" },
                values: new object[] { 203L, "YEKT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yekaterinburg Time", "UTC+05", 5, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TimeZoneId",
                table: "AspNetUsers",
                column: "TimeZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOffer_UserId",
                table: "SaleOffer",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "SaleOffer");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TimeZone");
        }
    }
}
