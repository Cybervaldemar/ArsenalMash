using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Model
{
    public partial class SqlRepository
    {
        public IQueryable<TypeServices> Services
        {
            get
            {
                return Db.TypeServices;
            }
        }

        public bool CreateService(TypeServices instance)
        {
            throw new NotImplementedException();
        }

        public bool RemoveService(int idService)
        {
            throw new NotImplementedException();
        }

        public bool UpdateService(TypeServices instance)
        {
            throw new NotImplementedException();
        }
    }
}
