using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Parts16.Dtos;

namespace Parts16.IBll
{
    public interface IRoleBll
    {
        Task<int> AddRoleAsync(string title);

        Task<int> EditRoleAsync(Guid id, string title);

        Task<int> DeleteRoleAsync(Guid id);

        Task<int> GetRolesCountAsync(string title);

        Task<bool> IsExistsAsync(string title);

        Task<List<RoleDto>> GetRoleListByPage(int pageSize, int pageIndex, string title, bool isAsc);

        Task<RoleDto> GetRoles(Guid id);
    }
}
