
using Npgsql;

namespace document.Models;

public class DocumentDbOptions
{
    public static string DocumentDbSection = "DocumentDb";

    public string UserName { get; set; }
    public string Password { get; set; }
    public string Host { get; set; }

    public string ConnectionString
    {
        get
        {
            var npgsqlConnectionStringBuilder = new NpgsqlConnectionStringBuilder
            {
                Host = Host,
                Port = 5432,
                Database = "documentDb",
                Username = UserName,
                Password = Password
            };

            return npgsqlConnectionStringBuilder.ConnectionString;
        }
    }

}