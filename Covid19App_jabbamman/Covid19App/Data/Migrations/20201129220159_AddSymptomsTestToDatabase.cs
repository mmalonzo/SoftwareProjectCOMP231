using Microsoft.EntityFrameworkCore.Migrations;

namespace Covid19App.Data.Migrations
{
    public partial class AddSymptomsTestToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SymptomsTest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    DOB = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Feverorchills = table.Column<bool>(nullable: false),
                    Difficultybreathings = table.Column<bool>(nullable: false),
                    Cough = table.Column<bool>(nullable: false),
                    Sorethroat = table.Column<bool>(nullable: false),
                    Runnynose = table.Column<bool>(nullable: false),
                    Lossofsmell = table.Column<bool>(nullable: false),
                    Nausea = table.Column<bool>(nullable: false),
                    Tiredness = table.Column<bool>(nullable: false),
                    Travelled = table.Column<bool>(nullable: false),
                    ContactCovidCases = table.Column<bool>(nullable: false),
                    TestDate = table.Column<string>(nullable: true),
                    Result = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SymptomsTest", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SymptomsTest");
        }
    }
}
