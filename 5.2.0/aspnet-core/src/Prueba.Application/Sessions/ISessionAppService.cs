using System.Threading.Tasks;
using Abp.Application.Services;
using Prueba.Sessions.Dto;

namespace Prueba.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
