using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace desafioBluetooth.Migrations
{
    /// <inheritdoc />
    public partial class CriarBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BluetoothDeviceMobile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Periodo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MAC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MACScan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MACPaired = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataHoraEvento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlagProcess = table.Column<bool>(type: "bit", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BluetoothDeviceMobile", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BluetoothDeviceMobile");
        }
    }
}
