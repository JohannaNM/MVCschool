using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCschool.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TFirstName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    TLastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SFirstName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    SLastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    EnrollmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.EnrollmentId);
                    table.ForeignKey(
                        name: "FK_Enrollments_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "ClassName" },
                values: new object[,]
                {
                    { 1, "1A" },
                    { 2, "2B" },
                    { 3, "3C" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "TFirstName", "TLastName" },
                values: new object[,]
                {
                    { 1, "Find", "Waldo" },
                    { 2, "David", "Toll" },
                    { 3, "Anders", "Ullström" },
                    { 4, "Léon", "Nahum" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseID", "TeacherId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Programing 1" },
                    { 2, 2, "Math 1" },
                    { 3, 3, "English" },
                    { 4, 4, "Music" },
                    { 5, 1, "programing 2" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "ClassId", "SFirstName", "SLastName" },
                values: new object[,]
                {
                    { 1, 1, "Alexander", "Carson" },
                    { 2, 1, "Meredith", "Alonso" },
                    { 3, 1, "Arturo", "Anand" },
                    { 4, 1, "Gytis", "Barzdukas" },
                    { 5, 1, "Laura", "Norman" },
                    { 6, 1, "Irving", "Hills" },
                    { 7, 2, "Yan", "Li" },
                    { 8, 2, "Peggy", "Justice" },
                    { 9, 2, "Nino", "Olivetto" },
                    { 10, 2, "Adam", "Adams" },
                    { 11, 2, "Lilith", "Baker" },
                    { 12, 2, "Frank", "Evans" },
                    { 13, 3, "Lee", "Xiang" },
                    { 14, 3, "Mannie", "Quinn" },
                    { 15, 3, "Andrea", "Lopez" },
                    { 16, 3, "Alexander", "Smith" },
                    { 17, 3, "Walter", "White" },
                    { 18, 3, "Jacob", "Yakub" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentId", "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 7, 2, 7 },
                    { 8, 2, 8 },
                    { 9, 2, 9 },
                    { 10, 2, 10 },
                    { 11, 2, 11 },
                    { 12, 2, 12 },
                    { 13, 3, 13 },
                    { 14, 3, 14 },
                    { 15, 3, 15 },
                    { 16, 3, 16 },
                    { 17, 3, 17 },
                    { 18, 3, 18 },
                    { 19, 4, 1 },
                    { 20, 4, 2 },
                    { 21, 4, 3 },
                    { 22, 4, 4 },
                    { 23, 4, 5 },
                    { 24, 4, 6 },
                    { 25, 5, 7 },
                    { 26, 5, 8 },
                    { 27, 5, 9 },
                    { 28, 5, 10 },
                    { 29, 5, 11 },
                    { 30, 5, 12 },
                    { 31, 2, 13 },
                    { 32, 2, 14 },
                    { 33, 2, 15 },
                    { 34, 2, 16 },
                    { 35, 2, 17 },
                    { 36, 2, 18 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseId",
                table: "Enrollments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentId",
                table: "Enrollments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
