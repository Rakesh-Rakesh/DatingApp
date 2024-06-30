using API.Entities;

namespace API;

public interface IUserRepository
{
    void Update(AppUser user);

    Task<bool> SaveAsync();

    Task<IEnumerable<AppUser>> GetUsersAsync();

    Task<AppUser> GetUserByIdAsync(int id);

    Task<AppUser> GetUserByUsernameAsync(string userName);

    Task<MemberDto> GetMemberAsync(string username);
    Task<IEnumerable<MemberDto>> GetMembersAsync();


}
