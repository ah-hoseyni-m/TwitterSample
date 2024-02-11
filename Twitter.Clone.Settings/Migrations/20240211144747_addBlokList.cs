using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Twitter.Clone.Settings.Migrations
{
    /// <inheritdoc />
    public partial class addBlokList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlockedPages",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockedPageId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockedPages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BlockedUsers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockedUserId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockedUsers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EmailNotificationSetting",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Mention = table.Column<bool>(type: "bit", nullable: false),
                    DirectMessage = table.Column<bool>(type: "bit", nullable: false),
                    Following = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailNotificationSetting", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "PushNotificationSetting",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Mention = table.Column<bool>(type: "bit", nullable: false),
                    DirectMessage = table.Column<bool>(type: "bit", nullable: false),
                    Following = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PushNotificationSetting", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "SmsNotificationSetting",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PasswordChange = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsNotificationSetting", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlockedPages_UserId",
                table: "BlockedPages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BlockedUsers_UserId",
                table: "BlockedUsers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlockedPages");

            migrationBuilder.DropTable(
                name: "BlockedUsers");

            migrationBuilder.DropTable(
                name: "EmailNotificationSetting");

            migrationBuilder.DropTable(
                name: "PushNotificationSetting");

            migrationBuilder.DropTable(
                name: "SmsNotificationSetting");
        }
    }
}
