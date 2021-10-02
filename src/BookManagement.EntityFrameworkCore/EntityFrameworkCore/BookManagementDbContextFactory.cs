using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using BookManagement.Configuration;
using BookManagement.Web;

namespace BookManagement.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BookManagementDbContextFactory : IDesignTimeDbContextFactory<BookManagementDbContext>
    {
        public BookManagementDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BookManagementDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BookManagementDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BookManagementConsts.ConnectionStringName));

            return new BookManagementDbContext(builder.Options);
        }
    }
}
