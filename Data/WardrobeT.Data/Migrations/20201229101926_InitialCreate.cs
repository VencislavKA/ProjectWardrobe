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
                name: "TypesOfWears",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(nullable: false),
                    Cover = table.Column<int>(nullable: false),
                    Official = table.Column<bool>(nullable: false),
                    CanBeUsedAlone = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfWears", x => x.Id);
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
                });

            migrationBuilder.CreateTable(
                name: "Followers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<string>(nullable: false),
                    FollowedId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Followers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wears",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: false),
                    TypeId = table.Column<string>(nullable: false),
                    Season = table.Column<int>(nullable: false),
                    Color = table.Column<int>(nullable: false),
                    OwnerId = table.Column<string>(nullable: false),
                    IsPublic = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wears", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wears_TypesOfWears_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TypesOfWears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Outfits",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    TopId = table.Column<string>(nullable: false),
                    MiddleId = table.Column<string>(nullable: false),
                    BottomId = table.Column<string>(nullable: false),
                    IsPublic = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outfits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Outfits_Wears_BottomId",
                        column: x => x.BottomId,
                        principalTable: "Wears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Outfits_Wears_MiddleId",
                        column: x => x.MiddleId,
                        principalTable: "Wears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Outfits_Wears_TopId",
                        column: x => x.TopId,
                        principalTable: "Wears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WearPosts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    WearId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WearPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WearPosts_Wears_WearId",
                        column: x => x.WearId,
                        principalTable: "Wears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutfitPosts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    OutfitId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutfitPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutfitPosts_Outfits_OutfitId",
                        column: x => x.OutfitId,
                        principalTable: "Outfits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    ProfilePicture = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    OutfitPostId = table.Column<string>(nullable: true),
                    WearPostId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_OutfitPosts_OutfitPostId",
                        column: x => x.OutfitPostId,
                        principalTable: "OutfitPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_WearPosts_WearPostId",
                        column: x => x.WearPostId,
                        principalTable: "WearPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "TypesOfWears",
                columns: new[] { "Id", "CanBeUsedAlone", "Cover", "CreatedOn", "ModifiedOn", "Official", "Type" },
                values: new object[,]
                {
                    { "f3e07e83-05f0-4e82-815e-ff4e089876af", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Tracksuit top" },
                    { "a9c10c7c-3919-4846-b6f4-400b137061c9", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Turtleneck" },
                    { "ec42f491-c02b-49ce-8446-dcf985330ef9", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Official turtleneck" },
                    { "47b76a9d-5717-44ea-873d-f977fc774b53", false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Leggins" },
                    { "35f46c2b-ab61-45b4-8733-9003c7b325c6", false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Slacks" },
                    { "e5abd65b-9757-47c6-8b72-0de2c0fbf5b2", false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Official slacks" },
                    { "0c2ee185-49bc-46c8-8fea-72700af38540", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Coat" },
                    { "6de38920-4f49-4adc-83eb-5d2960bc46cb", false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Short" },
                    { "b9ac62a4-5eb4-4d49-8c52-4a4083aefd23", false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Official short" },
                    { "5030226a-0016-4502-975c-3133767759d6", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Vest" },
                    { "95383162-3330-4e60-b5c2-0a7eb89c0acb", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Official vest" },
                    { "bb10bfdf-fd7a-4353-8f13-6673839d8a93", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Tunic" },
                    { "c48143e3-3336-435b-a11a-18c81d21d0d6", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Official tunic" },
                    { "3b954f2f-aed3-4991-b4e9-6d492761efde", false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Jeans" },
                    { "a2c56d19-15c7-4644-ae6d-764e48cae93f", false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Official jeans" },
                    { "8a33c2d8-1ed2-4bba-a697-038fadd92353", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Blazer" },
                    { "3a70aa5e-cd67-4b79-a72e-1121af44077b", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Official blazer" },
                    { "f2270e20-a475-4065-aa9a-e7fd574e1fac", false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Skirt" },
                    { "6c83bb34-8b6a-46ef-8d5a-0a8e298af0d8", false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Tracksuit bottoms" },
                    { "4e079513-1324-4bec-86da-617c779ae48e", true, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Official dress" },
                    { "37fd5adf-fc9b-44f4-9d96-44385280ea42", true, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Dress" },
                    { "05bd0646-2bb2-4d66-8544-acb2cff9bef0", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Official jacket" },
                    { "9b8dfa4c-c25a-493d-89dc-ee51f0a68c71", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Jacket" },
                    { "cd8d18b4-2c27-4a79-9b49-d38f337103a8", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Official knit Shirt" },
                    { "9cb8c33f-d192-40e4-930d-2337a091a9cd", false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Official T-Shirt" },
                    { "7ab7832a-664a-41c6-8706-51dd79709a34", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Knit Shirt" },
                    { "9fd34e85-775d-4232-8042-2a083936a2ea", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Shirt" },
                    { "ae6936da-e121-45f5-acda-c6eef4e8288f", true, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Suit" },
                    { "92087926-037f-4811-8bd9-8ccd19afd6d3", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Official blouse" },
                    { "6af0b806-a365-4326-b9ea-85905de5747a", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Blouse" },
                    { "979bc152-0d03-4322-bab6-885bc5dffe48", false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Sport Shirt" },
                    { "07190b8f-8654-4272-8cf8-950c89094d07", false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Official skirt" },
                    { "21eba6fa-5d82-4175-9fb7-b284323660f2", false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Official sirt" },
                    { "98a66a2b-9c2c-4f2d-a577-5401ffd97da5", false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "T-Shirt" }
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
                name: "IX_AspNetUsers_OutfitPostId",
                table: "AspNetUsers",
                column: "OutfitPostId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_WearPostId",
                table: "AspNetUsers",
                column: "WearPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Followers_FollowedId",
                table: "Followers",
                column: "FollowedId");

            migrationBuilder.CreateIndex(
                name: "IX_Followers_UserId",
                table: "Followers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OutfitPosts_OutfitId",
                table: "OutfitPosts",
                column: "OutfitId");

            migrationBuilder.CreateIndex(
                name: "IX_Outfits_BottomId",
                table: "Outfits",
                column: "BottomId");

            migrationBuilder.CreateIndex(
                name: "IX_Outfits_MiddleId",
                table: "Outfits",
                column: "MiddleId");

            migrationBuilder.CreateIndex(
                name: "IX_Outfits_TopId",
                table: "Outfits",
                column: "TopId");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_IsDeleted",
                table: "Settings",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_WearPosts_WearId",
                table: "WearPosts",
                column: "WearId");

            migrationBuilder.CreateIndex(
                name: "IX_Wears_OwnerId",
                table: "Wears",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Wears_TypeId",
                table: "Wears",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Followers_AspNetUsers_FollowedId",
                table: "Followers",
                column: "FollowedId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Followers_AspNetUsers_UserId",
                table: "Followers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wears_AspNetUsers_OwnerId",
                table: "Wears",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wears_AspNetUsers_OwnerId",
                table: "Wears");

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
                name: "Followers");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "OutfitPosts");

            migrationBuilder.DropTable(
                name: "WearPosts");

            migrationBuilder.DropTable(
                name: "Outfits");

            migrationBuilder.DropTable(
                name: "Wears");

            migrationBuilder.DropTable(
                name: "TypesOfWears");
        }
    }
}
