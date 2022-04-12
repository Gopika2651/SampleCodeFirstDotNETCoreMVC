sing Microsoft.EntityFrameworkCore.Migrations;

namespace SampleCodeFirstDotNETcoreMVC.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsComplete",
                table: "TodoItem",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.InsertData(
                table: "TodoItem",
                columns: new[] { "Id", "Description", "IsComplete", "Name" },
                values: new object[] { 1L, "In meeting need to discuss some points.", true, "Meeting with management" });

            migrationBuilder.InsertData(
                table: "TodoItem",
                columns: new[] { "Id", "Description", "IsComplete", "Name" },
                values: new object[] { 2L, "List of this this item buy.", false, "Go for shopping" });

            migrationBuilder.InsertData(
                table: "TodoItem",
                columns: new[] { "Id", "Description", "IsComplete", "Name" },
                values: new object[] { 3L, "here is a task to do on a call", true, "Call for someone to do some task" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoItem",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TodoItem",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TodoItem",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.AlterColumn<long>(
                name: "IsComplete",
                table: "TodoItem",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
