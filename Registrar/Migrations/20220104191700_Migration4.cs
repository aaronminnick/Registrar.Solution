using Microsoft.EntityFrameworkCore.Migrations;

namespace Registrar.Migrations
{
    public partial class Migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentCourse_Courses_CourseId",
                table: "DepartmentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentCourse_Department_DepartmentId",
                table: "DepartmentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentStudent_Department_DepartmentId",
                table: "DepartmentStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentStudent_Students_StudentId",
                table: "DepartmentStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentStudent",
                table: "DepartmentStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentCourse",
                table: "DepartmentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.RenameTable(
                name: "DepartmentStudent",
                newName: "DepartmentStudents");

            migrationBuilder.RenameTable(
                name: "DepartmentCourse",
                newName: "DepartmentCourses");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentStudent_StudentId",
                table: "DepartmentStudents",
                newName: "IX_DepartmentStudents_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentStudent_DepartmentId",
                table: "DepartmentStudents",
                newName: "IX_DepartmentStudents_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentCourse_DepartmentId",
                table: "DepartmentCourses",
                newName: "IX_DepartmentCourses_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentCourse_CourseId",
                table: "DepartmentCourses",
                newName: "IX_DepartmentCourses_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentStudents",
                table: "DepartmentStudents",
                column: "DepartmentStudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentCourses",
                table: "DepartmentCourses",
                column: "DepartmentCourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentCourses_Courses_CourseId",
                table: "DepartmentCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentCourses_Departments_DepartmentId",
                table: "DepartmentCourses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentStudents_Departments_DepartmentId",
                table: "DepartmentStudents",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentStudents_Students_StudentId",
                table: "DepartmentStudents",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentCourses_Courses_CourseId",
                table: "DepartmentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentCourses_Departments_DepartmentId",
                table: "DepartmentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentStudents_Departments_DepartmentId",
                table: "DepartmentStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentStudents_Students_StudentId",
                table: "DepartmentStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentStudents",
                table: "DepartmentStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentCourses",
                table: "DepartmentCourses");

            migrationBuilder.RenameTable(
                name: "DepartmentStudents",
                newName: "DepartmentStudent");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "DepartmentCourses",
                newName: "DepartmentCourse");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentStudents_StudentId",
                table: "DepartmentStudent",
                newName: "IX_DepartmentStudent_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentStudents_DepartmentId",
                table: "DepartmentStudent",
                newName: "IX_DepartmentStudent_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentCourses_DepartmentId",
                table: "DepartmentCourse",
                newName: "IX_DepartmentCourse_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentCourses_CourseId",
                table: "DepartmentCourse",
                newName: "IX_DepartmentCourse_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentStudent",
                table: "DepartmentStudent",
                column: "DepartmentStudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentCourse",
                table: "DepartmentCourse",
                column: "DepartmentCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentCourse_Courses_CourseId",
                table: "DepartmentCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentCourse_Department_DepartmentId",
                table: "DepartmentCourse",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentStudent_Department_DepartmentId",
                table: "DepartmentStudent",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentStudent_Students_StudentId",
                table: "DepartmentStudent",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
