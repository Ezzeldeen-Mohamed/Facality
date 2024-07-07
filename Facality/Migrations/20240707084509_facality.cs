using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Facality.Migrations
{
    /// <inheritdoc />
    public partial class facality : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Studentphone = table.Column<int>(type: "int", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "faccalities",
                columns: table => new
                {
                    FacalityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacalityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Facalityphone = table.Column<int>(type: "int", nullable: false),
                    Facalityaddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sudentid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faccalities", x => x.FacalityId);
                    table.ForeignKey(
                        name: "FK_faccalities_students_sudentid",
                        column: x => x.sudentid,
                        principalTable: "students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_faccalities_sudentid",
                table: "faccalities",
                column: "sudentid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "faccalities");

            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
