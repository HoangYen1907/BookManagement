using System.Collections.Generic;
using BookManagement.Roles.Dto;

namespace BookManagement.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}