using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WardrobeT.Data.Migrations
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
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
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
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypesOfCloath",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Official = table.Column<bool>(nullable: false),
                    CanBeUsedAlone = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfCloath", x => x.Id);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FriendRequesterId = table.Column<string>(nullable: true),
                    RequstedPersonId = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Friends_IdentityUser_FriendRequesterId",
                        column: x => x.FriendRequesterId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Friends_IdentityUser_RequstedPersonId",
                        column: x => x.RequstedPersonId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cloaths",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    TypeId = table.Column<string>(nullable: false),
                    Season = table.Column<int>(nullable: false),
                    Style = table.Column<int>(nullable: false),
                    OwnerId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cloaths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cloaths_IdentityUser_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cloaths_TypesOfCloath_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TypesOfCloath",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "TypesOfCloath",
                columns: new[] { "Id", "CanBeUsedAlone", "Official", "Type" },
                values: new object[,]
                {
                    { "3a8866fb-997e-4c77-87d9-d0eca73363f1", true, true, "Dress" },
                    { "ffdba6a7-9d85-447e-9fa9-54d1766fed08", false, false, "Tie" },
                    { "90c1b1b6-b21c-4c8d-9460-d619b69653d8", false, true, "Tunic" },
                    { "d52ad638-13f1-43db-aff2-347b6247d24e", false, false, "Tunic" },
                    { "da3aca41-0b56-491b-8078-224fadb6ee9d", false, true, "Vest" },
                    { "f529c4a7-dc16-498f-932a-558a178aab35", false, false, "Vest" },
                    { "304679d5-50c6-46c5-94c5-7fb8e10d35d3", false, true, "Short" },
                    { "53cf539b-ead7-411a-861d-3916f14e0890", false, false, "Short" },
                    { "daf451c2-cb72-4b46-b9f5-9419d117629d", false, true, "Bowtie" },
                    { "3f2acfdb-c28f-4def-a150-024f3ae0a22b", false, false, "Bowtie" },
                    { "070ed7f5-5694-4e54-9a36-1484c585cd94", false, true, "Coat" },
                    { "1625daaf-214e-4bb3-a66a-1cc65642c111", false, true, "Slacks" },
                    { "6941ed15-f999-4c33-9314-58f730bff19c", false, false, "Slacks" },
                    { "25be51ef-1c32-482d-90b5-a9de9d708cc2", false, false, "Leggins" },
                    { "a4817149-2dde-410c-88cf-de0c1dabe979", false, true, "Turtle Neck" },
                    { "007a0b56-000e-4068-91d5-5e9fe6554f0b", false, false, "Turtle Neck" },
                    { "1a53e608-7244-4e0d-a543-c7c01a34dbb1", false, true, "Tie" },
                    { "7d278af6-288f-4fbd-ac30-16b6582a6821", false, true, "T-Shirt" },
                    { "61e1646c-8738-4ff3-91eb-08b68f220e1b", false, false, "Jeans" },
                    { "faac4b40-c810-47f4-8832-353271532fd2", false, false, "Blazer" },
                    { "f53cdb69-a190-4993-b157-3a494e2cbcfd", true, false, "Dress" },
                    { "7449b4b0-1e41-48ce-b43d-49697ea07938", false, true, "Jacket" },
                    { "f9fc1f5d-5153-4f70-aa1f-59953163f14d", false, false, "Jacket" },
                    { "c21308ae-f04c-47b4-b8b1-67681961cd4a", false, true, "Knit Shirt" },
                    { "d20f815e-8dc1-4dfe-980e-a9930bbebfc6", false, false, "Knit Shirt" },
                    { "2c1710a0-7428-41d6-9cd4-dd1ef4cc7399", false, true, "Shirt" },
                    { "4d673eb0-efe5-4c69-b601-527421e3859a", false, false, "Shirt" },
                    { "f360d7cc-21a5-4010-87ce-3c2ba2cdbe96", true, true, "Suit" },
                    { "e2dc29ee-79ce-4848-af08-f75f0b2eff5b", false, true, "Blouse" },
                    { "3ada8a34-3183-4644-830e-ba90904c1805", false, false, "Blouse" },
                    { "88c9fba5-2f9a-43dc-b9c5-8258d287b89e", false, true, "Sport Shirt" },
                    { "ea8e7ef2-4d0d-422e-a3bb-84361b13680e", false, false, "Sport Shirt" },
                    { "bf1aaa36-41ba-452e-8ed3-b5f88ef4d0ce", false, true, "Skirt" },
                    { "2d7cf21f-d3ae-4b9d-b35b-bc3298484648", false, false, "Skirt" },
                    { "007b8a16-372f-45ca-a82f-7605d339c0a3", false, true, "Blazer" },
                    { "3b5419f4-7a3d-42e7-8e35-010812c1ffec", false, true, "Jeans" },
                    { "e14812e3-c94f-4c93-82be-865baffcf42f", false, false, "T-Shirt" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_IsDeleted",
                table: "AspNetRoles",
                column: "IsDeleted");

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
                name: "IX_AspNetUsers_IsDeleted",
                table: "AspNetUsers",
                column: "IsDeleted");

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
                name: "IX_Cloaths_OwnerId",
                table: "Cloaths",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cloaths_TypeId",
                table: "Cloaths",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_FriendRequesterId",
                table: "Friends",
                column: "FriendRequesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_RequstedPersonId",
                table: "Friends",
                column: "RequstedPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_IsDeleted",
                table: "Settings",
                column: "IsDeleted");
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
                name: "Cloaths");

            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TypesOfCloath");

            migrationBuilder.DropTable(
                name: "IdentityUser");
        }
    }
}
