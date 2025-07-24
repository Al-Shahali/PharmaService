using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaDataBase.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DrugResponses",
                table: "DrugResponses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DrugResponses",
                table: "DrugResponses",
                column: "CurrentPage");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DrugResponses",
                table: "DrugResponses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DrugResponses",
                table: "DrugResponses",
                column: "PageCount");
        }
    }
}
