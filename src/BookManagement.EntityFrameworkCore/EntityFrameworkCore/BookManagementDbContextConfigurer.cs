using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.EntityFrameworkCore
{
    public static class BookManagementDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BookManagementDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BookManagementDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
