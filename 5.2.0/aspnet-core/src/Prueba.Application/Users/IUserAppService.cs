using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Prueba.Roles.Dto;
using Prueba.Users.Dto;

namespace Prueba.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
