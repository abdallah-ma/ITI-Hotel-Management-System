using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RemoveReservationIdCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Guests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Guests",
                type: "int",
                nullable: true);
        }
    }
}
