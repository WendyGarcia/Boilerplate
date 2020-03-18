using System.Threading.Tasks;
using Abp.Application.Services;
using Prueba.Authorization.Accounts.Dto;

namespace Prueba.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
