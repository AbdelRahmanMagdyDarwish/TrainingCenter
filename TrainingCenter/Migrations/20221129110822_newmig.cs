using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenter.Migrations
{
    public partial class newmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Departments_DepartmentId1",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_DepartmentId1",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentId1",
                table: "Departments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId1",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DepartmentId1",
                table: "Departments",
                column: "DepartmentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Departments_DepartmentId1",
                table: "Departments",
                column: "DepartmentId1",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
