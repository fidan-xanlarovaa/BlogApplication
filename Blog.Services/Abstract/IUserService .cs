using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Entities.Dtos.User;
using Blog.Shared.Utilities.Results.Abstract;

namespace Blog.Services.Abstract
{/// <summary>
/// Biz birdefe ICategoryService yaratmisiq deye ona baxib, uyqunlasdirib yaziriq.
/// </summary>
    public interface IUserService
    {
        Task<IResult<IList<UserDto>>> GetAllAsync();
        Task<IResult<UserUpdateDto>> GetUpdateDtoAsync(int id);
        Task<IResult<UserDto>> AddAsync(UserAddDto dto, string createdByName);
        Task<IResult<UserDto>> UpdateAsync(UserUpdateDto dto, string modifiedByName);
        Task<IResult<UserDto>> DeleteAsync(int id, string modifiedByName);
    }
}