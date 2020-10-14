using Parts16.Dal.Common;
using Parts16.IDal;
using Parts16.Models;
using Parts16.Models.Entities;

namespace Parts16.Dal
{
    public class AdminPermissionDal : BaseDal<AdminPermission>, IAdminPermissionDal
    {
        public AdminPermissionDal(Parts16Context db) : base(db)
        {
        }
    }
}