using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetByForms.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Forms", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "FormInputs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InputType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_FormInputs", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_FormInputs_Forms_FormId",
                        column: x => x.FormId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateTable(
                name: "FormInputOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormInputId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OptionValue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DisplayText = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_FormInputOptions", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_FormInputOptions_FormInputs_FormInputId",
                        column: x => x.FormInputId,
                        principalTable: "FormInputs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateIndex(
                name: "IX_FormInputOptions_FormInputId",
                table: "FormInputOptions",
                column: "FormInputId");

            _ = migrationBuilder.CreateIndex(
                name: "IX_FormInputs_FormId",
                table: "FormInputs",
                column: "FormId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DropTable(
                name: "FormInputOptions");

            _ = migrationBuilder.DropTable(
                name: "FormInputs");

            _ = migrationBuilder.DropTable(
                name: "Forms");
        }
    }
}