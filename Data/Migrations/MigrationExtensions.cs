using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Data.SqlClient;

namespace EmployeesManagement.Data.Migrations
{
    public static class MigrationExtensions
    {
        public static bool TableExists(this MigrationBuilder migrationBuilder, string tableName)
        {
            var sql = $"SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'";
            using (var connection = new SqlConnection(migrationBuilder.ActiveProvider))
            {
                using (var command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    return command.ExecuteScalar() != null;
                }
            }
        }
    }
}
