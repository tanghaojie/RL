using Microsoft.EntityFrameworkCore.Migrations;

namespace RLCore.Migrations
{
    public partial class qqqq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rlen",
                schema: "rl",
                table: "Rivers",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "NoLeaderBool",
                schema: "rl",
                table: "Rivers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "Flow",
                schema: "rl",
                table: "Rivers",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "BranchLevel",
                schema: "rl",
                table: "Rivers",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "BoundaryRiverBool",
                schema: "rl",
                table: "Rivers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "Area",
                schema: "rl",
                table: "Rivers",
                nullable: true,
                oldClrType: typeof(double));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rlen",
                schema: "rl",
                table: "Rivers",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NoLeaderBool",
                schema: "rl",
                table: "Rivers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Flow",
                schema: "rl",
                table: "Rivers",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "BranchLevel",
                schema: "rl",
                table: "Rivers",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BoundaryRiverBool",
                schema: "rl",
                table: "Rivers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Area",
                schema: "rl",
                table: "Rivers",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);
        }
    }
}
