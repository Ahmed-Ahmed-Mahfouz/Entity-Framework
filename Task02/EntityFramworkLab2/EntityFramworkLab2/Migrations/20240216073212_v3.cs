﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramworkLab2.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Authors_Email",
                table: "Authors",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Authors_Email",
                table: "Authors");
        }
    }
}
