using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Güzellik_Merkezi.Migrations
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
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Sifre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
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
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hizmetlers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResimYolu = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Baslik = table.Column<string>(nullable: true),
                    Hizmet = table.Column<string>(nullable: true),
                    Hizmet1 = table.Column<string>(nullable: true),
                    Hizmet2 = table.Column<string>(nullable: true),
                    Hizmet3 = table.Column<string>(nullable: true),
                    Hizmet4 = table.Column<string>(nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Fiyat1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Fiyat2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Fiyat3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Fiyat4 = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hizmetlers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomePages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoYazısı = table.Column<string>(nullable: true),
                    Baslik = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    ResimYolu = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ResimYolu1 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Baslik1 = table.Column<string>(nullable: true),
                    Aciklama1 = table.Column<string>(nullable: true),
                    BaslikServisler = table.Column<string>(nullable: true),
                    BaslikAciklama = table.Column<string>(nullable: true),
                    ResimYolu2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ServislerBasli = table.Column<string>(nullable: true),
                    SrvislerAciklama = table.Column<string>(nullable: true),
                    BaslikDigerSacStilleri = table.Column<string>(nullable: true),
                    AciklamaDigerSacStilleri = table.Column<string>(nullable: true),
                    ResimYolu3 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    BaslikKaliteliSacKesimi = table.Column<string>(nullable: true),
                    AciklamaKaliteliSacKesimi = table.Column<string>(nullable: true),
                    ResimYolu4 = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "İletisims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoYazısı = table.Column<string>(nullable: true),
                    Baslik = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    Baslik1 = table.Column<string>(nullable: true),
                    Aciklama1 = table.Column<string>(nullable: true),
                    Adres = table.Column<string>(nullable: true),
                    TelNo = table.Column<string>(nullable: true),
                    EPosta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_İletisims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Randevus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    Telno = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servislers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoYazısı = table.Column<string>(nullable: true),
                    Baslik = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    Baslik1 = table.Column<string>(nullable: true),
                    Aciklama1 = table.Column<string>(nullable: true),
                    Baslik2 = table.Column<string>(nullable: true),
                    Aciklama2 = table.Column<string>(nullable: true),
                    Baslik3 = table.Column<string>(nullable: true),
                    Aciklama3 = table.Column<string>(nullable: true),
                    Baslik4 = table.Column<string>(nullable: true),
                    Aciklama4 = table.Column<string>(nullable: true),
                    Baslik5 = table.Column<string>(nullable: true),
                    Aciklama5 = table.Column<string>(nullable: true),
                    Baslik6 = table.Column<string>(nullable: true),
                    Aciklama6 = table.Column<string>(nullable: true),
                    ClientSaysbaslik = table.Column<string>(nullable: true),
                    ClientSaysAciklama = table.Column<string>(nullable: true),
                    ResimYolu = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Müsteriisim = table.Column<string>(nullable: true),
                    MüsteriAciklama = table.Column<string>(nullable: true),
                    ResimYolu2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Müsteriisim2 = table.Column<string>(nullable: true),
                    MüsteriAciklama2 = table.Column<string>(nullable: true),
                    ResimYolu3 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Müsteriisim3 = table.Column<string>(nullable: true),
                    MüsteriAciklama3 = table.Column<string>(nullable: true),
                    KalitelisacBaslik = table.Column<string>(nullable: true),
                    KalitelisacAciklama = table.Column<string>(nullable: true),
                    ResimYolu1 = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servislers", x => x.Id);
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
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
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
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
                name: "Hizmetlers");

            migrationBuilder.DropTable(
                name: "HomePages");

            migrationBuilder.DropTable(
                name: "İletisims");

            migrationBuilder.DropTable(
                name: "Randevus");

            migrationBuilder.DropTable(
                name: "Servislers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
