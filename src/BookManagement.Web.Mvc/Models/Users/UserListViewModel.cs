using System.Collections.Generic;
using BookManagement.Roles.Dto;
using BookManagement.Users.Dto;

namespace BookManagement.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
