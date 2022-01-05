using System;
using document.DataContext;
using document.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Options;

#nullable disable

namespace document.Migrations
{
    public partial class Initial_Data : Migration
    {
        
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            
            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "Name", "Created" },
                values: new object[] { Guid.NewGuid(), "MSDN Magazine", DateTime.UtcNow });
            
                // migrationBuilder.Sql(@"
                // INSERT INTO public."Documents"(
                // "Id", "Name", "Created", "DataJsonb")
                // VALUES ('c2d29867-3d0b-d497-9191-18a9d8ee7832', 'FileName15', current_timestamp,
                //     '{
                //         "person":
                //         {
                //             "first_name": "Steve",
                //             "last_name": "Pousty"
                //         },
                //         "score" : 100,
                //         "status" : "Awesome",
                //         "best_feature" : "humbleness"
                //      }'
                // )");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM public.Documents");
        }
    }
}
