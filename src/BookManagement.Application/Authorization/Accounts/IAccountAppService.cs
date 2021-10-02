using System.Threading.Tasks;
using Abp.Application.Services;
using BookManagement.Authorization.Accounts.Dto;

namespace BookManagement.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
