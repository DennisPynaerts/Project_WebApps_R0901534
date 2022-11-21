using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_WebApps_R0901534_ASP.Migrations
{
    public partial class InitialCreate : Migration
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
                name: "Circuits",
                columns: table => new
                {
                    CircuitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(maxLength: 30, nullable: false),
                    Afbeelding = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuits", x => x.CircuitId);
                });

            migrationBuilder.CreateTable(
                name: "Klasses",
                columns: table => new
                {
                    KlasseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    MinPI = table.Column<int>(nullable: false),
                    MaxPI = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klasses", x => x.KlasseId);
                });

            migrationBuilder.CreateTable(
                name: "Merken",
                columns: table => new
                {
                    MerkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merken", x => x.MerkId);
                });

            migrationBuilder.CreateTable(
                name: "OverMijs",
                columns: table => new
                {
                    OverMijId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitelPersInfo = table.Column<string>(maxLength: 40, nullable: false),
                    TekstPersInfo = table.Column<string>(nullable: false),
                    TitelAppInfo = table.Column<string>(maxLength: 40, nullable: false),
                    TekstAppInfo = table.Column<string>(nullable: false),
                    Afbeelding1 = table.Column<string>(nullable: false),
                    Afbeelding2 = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverMijs", x => x.OverMijId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                name: "Autos",
                columns: table => new
                {
                    AutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasisPI = table.Column<int>(nullable: false),
                    PK = table.Column<int>(nullable: false),
                    Aandrijflijn = table.Column<string>(nullable: true),
                    Bouwjaar = table.Column<int>(nullable: false),
                    TotalePI = table.Column<int>(nullable: false),
                    Kostprijs = table.Column<int>(nullable: false),
                    MerkId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autos", x => x.AutoId);
                    table.ForeignKey(
                        name: "FK_Autos_Merken_MerkId",
                        column: x => x.MerkId,
                        principalTable: "Merken",
                        principalColumn: "MerkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    ModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(maxLength: 30, nullable: false),
                    MerkId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.ModelId);
                    table.ForeignKey(
                        name: "FK_Models_Merken_MerkId",
                        column: x => x.MerkId,
                        principalTable: "Merken",
                        principalColumn: "MerkId",
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
                    Nickname = table.Column<string>(nullable: true),
                    Emailadres = table.Column<string>(nullable: true),
                    Wachtwoord = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false),
                    OverMijId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_OverMijs_OverMijId",
                        column: x => x.OverMijId,
                        principalTable: "OverMijs",
                        principalColumn: "OverMijId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                name: "GebruikerAutos",
                columns: table => new
                {
                    GebruikerAutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutoId = table.Column<int>(nullable: false),
                    GebruikerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GebruikerAutos", x => x.GebruikerAutoId);
                    table.ForeignKey(
                        name: "FK_GebruikerAutos_Autos_AutoId",
                        column: x => x.AutoId,
                        principalTable: "Autos",
                        principalColumn: "AutoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GebruikerAutos_AspNetUsers_GebruikerId",
                        column: x => x.GebruikerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AutoKlasses",
                columns: table => new
                {
                    AutoKlasseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GebruikerAutoId = table.Column<int>(nullable: false),
                    KlasseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoKlasses", x => x.AutoKlasseId);
                    table.ForeignKey(
                        name: "FK_AutoKlasses_GebruikerAutos_GebruikerAutoId",
                        column: x => x.GebruikerAutoId,
                        principalTable: "GebruikerAutos",
                        principalColumn: "GebruikerAutoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoKlasses_Klasses_KlasseId",
                        column: x => x.KlasseId,
                        principalTable: "Klasses",
                        principalColumn: "KlasseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Laptimes",
                columns: table => new
                {
                    LaptimeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutoKlasseId = table.Column<int>(nullable: false),
                    CircuitId = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    Rondetijd = table.Column<string>(maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptimes", x => x.LaptimeId);
                    table.ForeignKey(
                        name: "FK_Laptimes_AutoKlasses_AutoKlasseId",
                        column: x => x.AutoKlasseId,
                        principalTable: "AutoKlasses",
                        principalColumn: "AutoKlasseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Laptimes_Circuits_CircuitId",
                        column: x => x.CircuitId,
                        principalTable: "Circuits",
                        principalColumn: "CircuitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_OverMijId",
                table: "AspNetUsers",
                column: "OverMijId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoKlasses_GebruikerAutoId",
                table: "AutoKlasses",
                column: "GebruikerAutoId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoKlasses_KlasseId",
                table: "AutoKlasses",
                column: "KlasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Autos_MerkId",
                table: "Autos",
                column: "MerkId");

            migrationBuilder.CreateIndex(
                name: "IX_GebruikerAutos_AutoId",
                table: "GebruikerAutos",
                column: "AutoId");

            migrationBuilder.CreateIndex(
                name: "IX_GebruikerAutos_GebruikerId",
                table: "GebruikerAutos",
                column: "GebruikerId");

            migrationBuilder.CreateIndex(
                name: "IX_Laptimes_AutoKlasseId",
                table: "Laptimes",
                column: "AutoKlasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Laptimes_CircuitId",
                table: "Laptimes",
                column: "CircuitId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_MerkId",
                table: "Models",
                column: "MerkId");
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
                name: "Laptimes");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AutoKlasses");

            migrationBuilder.DropTable(
                name: "Circuits");

            migrationBuilder.DropTable(
                name: "GebruikerAutos");

            migrationBuilder.DropTable(
                name: "Klasses");

            migrationBuilder.DropTable(
                name: "Autos");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Merken");

            migrationBuilder.DropTable(
                name: "OverMijs");
        }
    }
}
