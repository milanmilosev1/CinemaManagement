using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CinemaManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class halls_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Halls_Cinemas_CinemaId",
                table: "Halls");

            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Halls_HallId",
                table: "Screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Movies_MovieId",
                table: "Screenings");

            migrationBuilder.DropIndex(
                name: "IX_Screenings_HallId",
                table: "Screenings");

            migrationBuilder.DropColumn(
                name: "HallId",
                table: "Screenings");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Screenings",
                type: "integer",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Movies",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<Guid>(
                name: "HallId",
                table: "Movies",
                type: "uuid",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CinemaId",
                table: "Halls",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_HallId",
                table: "Movies",
                column: "HallId");

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_Cinemas_CinemaId",
                table: "Halls",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Halls_HallId",
                table: "Movies",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Movies_MovieId",
                table: "Screenings",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Halls_Cinemas_CinemaId",
                table: "Halls");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Halls_HallId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Movies_MovieId",
                table: "Screenings");

            migrationBuilder.DropIndex(
                name: "IX_Movies_HallId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "HallId",
                table: "Movies");

            migrationBuilder.AlterColumn<Guid>(
                name: "MovieId",
                table: "Screenings",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "HallId",
                table: "Screenings",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Movies",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<Guid>(
                name: "CinemaId",
                table: "Halls",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_HallId",
                table: "Screenings",
                column: "HallId");

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_Cinemas_CinemaId",
                table: "Halls",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Halls_HallId",
                table: "Screenings",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Movies_MovieId",
                table: "Screenings",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
