using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BookManagement.Authorization.Roles;
using BookManagement.Authorization.Users;
using BookManagement.MultiTenancy;

namespace BookManagement.EntityFrameworkCore
{
    public class BookManagementDbContext : AbpZeroDbContext<Tenant, Role, User, BookManagementDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BookManagementDbContext(DbContextOptions<BookManagementDbContext> options)
            : base(options)
        {
        }
    }
}
