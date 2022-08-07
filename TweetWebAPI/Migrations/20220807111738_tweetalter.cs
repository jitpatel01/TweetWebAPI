using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TweetWebAPI.Migrations
{
    public partial class tweetalter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tweet_Tweet_TweetId",
                table: "Tweet");

            migrationBuilder.DropForeignKey(
                name: "FK_Tweet_Users_UserId",
                table: "Tweet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tweet",
                table: "Tweet");

            migrationBuilder.RenameTable(
                name: "Tweet",
                newName: "Tweets");

            migrationBuilder.RenameIndex(
                name: "IX_Tweet_UserId",
                table: "Tweets",
                newName: "IX_Tweets_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tweet_TweetId",
                table: "Tweets",
                newName: "IX_Tweets_TweetId");

            migrationBuilder.AlterColumn<string>(
                name: "Tag",
                table: "Tweets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Tweets",
                type: "nvarchar(144)",
                maxLength: 144,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tweets",
                table: "Tweets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tweets_Tweets_TweetId",
                table: "Tweets",
                column: "TweetId",
                principalTable: "Tweets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tweets_Users_UserId",
                table: "Tweets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tweets_Tweets_TweetId",
                table: "Tweets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tweets_Users_UserId",
                table: "Tweets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tweets",
                table: "Tweets");

            migrationBuilder.RenameTable(
                name: "Tweets",
                newName: "Tweet");

            migrationBuilder.RenameIndex(
                name: "IX_Tweets_UserId",
                table: "Tweet",
                newName: "IX_Tweet_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tweets_TweetId",
                table: "Tweet",
                newName: "IX_Tweet_TweetId");

            migrationBuilder.AlterColumn<string>(
                name: "Tag",
                table: "Tweet",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Tweet",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(144)",
                oldMaxLength: 144);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tweet",
                table: "Tweet",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tweet_Tweet_TweetId",
                table: "Tweet",
                column: "TweetId",
                principalTable: "Tweet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tweet_Users_UserId",
                table: "Tweet",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
