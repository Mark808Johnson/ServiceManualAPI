using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EtteplanMORE.ServiceManual.Infrastructure.Migrations
{
    public partial class CreatedServiceManualDbAndTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FactoryDevices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactoryDevices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maintenance Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeRegistered = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeverityLevel = table.Column<int>(type: "int", nullable: false),
                    CurrentStatus = table.Column<int>(type: "int", nullable: false),
                    TargetDeviceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintenance Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maintenance Tasks_FactoryDevices_TargetDeviceId",
                        column: x => x.TargetDeviceId,
                        principalTable: "FactoryDevices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance Tasks_TargetDeviceId",
                table: "Maintenance Tasks",
                column: "TargetDeviceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maintenance Tasks");

            migrationBuilder.DropTable(
                name: "FactoryDevices");
        }
    }
}
