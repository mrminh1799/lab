using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataBaseAndCreateThreadMemberTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Threads",
                table: "Threads");

            migrationBuilder.RenameTable(
                name: "Threads",
                newName: "threads");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "threads",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "threads",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ThreadType",
                table: "threads",
                newName: "thread_type");

            migrationBuilder.RenameColumn(
                name: "LastMessageAt",
                table: "threads",
                newName: "last_message_at");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "threads",
                newName: "image_url");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "threads",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "threads",
                newName: "created_at");

            migrationBuilder.AddPrimaryKey(
                name: "PK_threads",
                table: "threads",
                column: "id");

            migrationBuilder.CreateTable(
                name: "thread_members",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    thread_id = table.Column<long>(type: "bigint", nullable: false),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    nickname = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    muted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    notifications_enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    joined_at = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_thread_members", x => x.id);
                    table.ForeignKey(
                        name: "FK_thread_members_threads_thread_id",
                        column: x => x.thread_id,
                        principalTable: "threads",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_thread_members_thread_id",
                table: "thread_members",
                column: "thread_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "thread_members");

            migrationBuilder.DropPrimaryKey(
                name: "PK_threads",
                table: "threads");

            migrationBuilder.RenameTable(
                name: "threads",
                newName: "Threads");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Threads",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Threads",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "thread_type",
                table: "Threads",
                newName: "ThreadType");

            migrationBuilder.RenameColumn(
                name: "last_message_at",
                table: "Threads",
                newName: "LastMessageAt");

            migrationBuilder.RenameColumn(
                name: "image_url",
                table: "Threads",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "Threads",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Threads",
                newName: "CreatedAt");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Threads",
                table: "Threads",
                column: "Id");
        }
    }
}
