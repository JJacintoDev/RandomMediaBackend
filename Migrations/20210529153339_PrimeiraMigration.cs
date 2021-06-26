using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RandomMediaBackend.Migrations
{
    public partial class PrimeiraMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    ProfileImg = table.Column<string>(nullable: false),
                    BannerImg = table.Column<string>(nullable: false),
                    Bio = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostCategory = table.Column<string>(nullable: false),
                    PostTitle = table.Column<string>(nullable: false),
                    PostContent = table.Column<string>(nullable: true),
                    PostImage = table.Column<string>(nullable: true),
                    PostLikeness = table.Column<string>(nullable: false),
                    PostType = table.Column<int>(nullable: false),
                    PostViews = table.Column<int>(nullable: false),
                    PinnedPost = table.Column<bool>(nullable: false),
                    PostDate = table.Column<DateTime>(nullable: false),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostID);
                    table.ForeignKey(
                        name: "FK_Posts_Users_Username",
                        column: x => x.Username,
                        principalTable: "Users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentsText = table.Column<string>(nullable: false),
                    CommentDate = table.Column<DateTime>(nullable: false),
                    CommentLikeness = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    PostFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentsID);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostFK",
                        column: x => x.PostFK,
                        principalTable: "Posts",
                        principalColumn: "PostID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_Username",
                        column: x => x.Username,
                        principalTable: "Users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostFK",
                table: "Comments",
                column: "PostFK");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Username",
                table: "Comments",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Username",
                table: "Posts",
                column: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
