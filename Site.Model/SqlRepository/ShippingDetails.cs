using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Model
{
    public partial class SqlRepository
    {
        public IQueryable<ShippingDetails> AllDetails
        {
            get
            {
                return Db.ShippingDetails;
            }
        }

        public bool CreateDetails(ShippingDetails instance)
        {
            if (instance.ID == 0)
            {
                Db.ShippingDetails.InsertOnSubmit(instance);
                Db.ShippingDetails.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveDetails(int idDetails)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDetails(ShippingDetails instance)
        {
            throw new NotImplementedException();
        }
    }
}
