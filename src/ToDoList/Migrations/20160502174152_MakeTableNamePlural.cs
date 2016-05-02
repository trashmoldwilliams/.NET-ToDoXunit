using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace ToDoList.Migrations
{
    public partial class MakeTableNamePlural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");
        }
    }
}
