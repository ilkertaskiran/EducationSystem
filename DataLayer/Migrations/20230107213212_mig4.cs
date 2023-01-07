using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubEducations_Educations_EducationId",
                table: "SubEducations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubEducations",
                table: "SubEducations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Educations",
                table: "Educations");

            migrationBuilder.RenameTable(
                name: "SubEducations",
                newName: "SubEducation");

            migrationBuilder.RenameTable(
                name: "Educations",
                newName: "Education");

            migrationBuilder.RenameIndex(
                name: "IX_SubEducations_EducationId",
                table: "SubEducation",
                newName: "IX_SubEducation_EducationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubEducation",
                table: "SubEducation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Education",
                table: "Education",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubEducation_Education_EducationId",
                table: "SubEducation",
                column: "EducationId",
                principalTable: "Education",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubEducation_Education_EducationId",
                table: "SubEducation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubEducation",
                table: "SubEducation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Education",
                table: "Education");

            migrationBuilder.RenameTable(
                name: "SubEducation",
                newName: "SubEducations");

            migrationBuilder.RenameTable(
                name: "Education",
                newName: "Educations");

            migrationBuilder.RenameIndex(
                name: "IX_SubEducation_EducationId",
                table: "SubEducations",
                newName: "IX_SubEducations_EducationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubEducations",
                table: "SubEducations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Educations",
                table: "Educations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubEducations_Educations_EducationId",
                table: "SubEducations",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
