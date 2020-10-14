using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Parts16.Dtos;
using Parts16.IBll;
using Parts16.IDal;
using Parts16.Models.Entities;

namespace Parts16.Bll
{
    public class RoleBll : IRoleBll
    {
        private readonly IRoleDal _dal;

        public RoleBll(IRoleDal dal)
        {
            _dal = dal;
        }

        public async Task<int> AddRoleAsync(string title)
        {
            if (!string.IsNullOrWhiteSpace(title) && !await _dal.IsExistsAsync(r => r.Title == title))
                return await _dal.AddAsync(new Role {Id = Guid.NewGuid(), Title = title});

            return -3;
        }

        public async Task<int> EditRoleAsync(Guid id, string title)
        {
            var role = await _dal.QueryAsync(id);
            if (role == null) return -2;

            role.Title = title;
            role.UpdateTime = DateTime.Now;
            return await _dal.EditAsync(role);
        }

        public async Task<int> DeleteRoleAsync(Guid id)
        {
            var role = await _dal.QueryAsync(id);
            if (role == null) return -2;

            return await _dal.DeleteAsync(role);
        }

        public async Task<int> GetRolesCountAsync(string title)
        {
            return await _dal.GetCountAsync(r => r.Title.Contains(title));
        }

        public async Task<bool> IsExistsAsync(string title)
        {
            return await _dal.IsExistsAsync(r => r.Title.Equals(title));
        }

        public async Task<List<RoleDto>> GetRoleListByPage(int pageSize, int pageIndex, string title, bool isAsc)
        {
            return await _dal.QueryByPage(pageSize, pageIndex, r => r.Title.Contains(title), isAsc)
                .Select(n => new RoleDto
                    {
                        Id = n.Id,
                        Title = n.Title,
                        UpdateTime = n.UpdateTime
                    }).ToListAsync();
        }

        public async Task<RoleDto> GetRoles(Guid id)
        {
            var role = await _dal.QueryAsync(id);
            if(role == null) return new RoleDto();
            return new RoleDto
            {
                Title = role.Title,
                UpdateTime = role.UpdateTime,
                Id = role.Id
            };
        }
    }
}