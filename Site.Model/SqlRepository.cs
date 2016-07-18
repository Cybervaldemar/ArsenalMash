using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Model
{
    public partial class SqlRepository : IRepository
    {
            [Inject]
            public SiteDBDataContext Db { get; set; }

        
    }
}
