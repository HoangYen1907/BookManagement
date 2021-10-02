using System.Threading.Tasks;
using Abp.Application.Services;
using BookManagement.Sessions.Dto;

namespace BookManagement.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
