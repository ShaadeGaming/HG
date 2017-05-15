using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HungerGames.Migrations
{
    public partial class newmiggggggg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Evaluation",
                table: "Evaluation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Day",
                table: "Day");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Evaluations",
                table: "Evaluation",
                column: "EvaluationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Days",
                table: "Day",
                column: "DayID");

            migrationBuilder.RenameTable(
                name: "Evaluation",
                newName: "Evaluations");

            migrationBuilder.RenameTable(
                name: "Day",
                newName: "Days");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Evaluations",
                table: "Evaluations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Days",
                table: "Days");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Evaluation",
                table: "Evaluations",
                column: "EvaluationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Day",
                table: "Days",
                column: "DayID");

            migrationBuilder.RenameTable(
                name: "Evaluations",
                newName: "Evaluation");

            migrationBuilder.RenameTable(
                name: "Days",
                newName: "Day");
        }
    }
}
