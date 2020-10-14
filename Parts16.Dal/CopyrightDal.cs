using Parts16.Dal.Common;
using Parts16.IDal;
using Parts16.Models;
using Parts16.Models.Entities;

namespace Parts16.Dal
{
    public class CopyrightDal: BaseDal<Copyright>, ICopyrightDal
    {
        public CopyrightDal(Parts16Context db) : base(db)
        {
        }
    }
}