using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace document.Migrations
{
    public partial class Initial_Data_WithJsonB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var jsobB = " {\"score\" : 100," +
                                "\"person\": {" +
                                                "\"first_name\":\"Tom\"," +
                                                "\"last_name\":\"Cruz\"" +
                                              "}"  +
                             "}";


                        migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "Name", "Created" ,"DataJsonb"},
                values: new object[] { Guid.NewGuid(), "Jsonb File", DateTime.UtcNow, jsobB });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM public.Documents");
        }
    }
}
