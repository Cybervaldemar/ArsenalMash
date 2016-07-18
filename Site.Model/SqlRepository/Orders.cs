using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Model
{
    public partial class SqlRepository
    {
        public IQueryable<Orders> AllOrders
        {
            get
            {
                return Db.Orders;
            }
        }

        public bool CreateOrder(Orders instance)
        {
            if (instance.ID == 0)
            {
                Db.Orders.InsertOnSubmit(instance);
                Db.Orders.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveOrder(int idOrder)
        {
            Orders instance = Db.Orders.FirstOrDefault(p => p.ID == idOrder);
            if (instance != null)
            {
                Db.Orders.DeleteOnSubmit(instance);
                Db.Orders.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool UpdateOrder(Orders instance)
        {
            Orders cache = Db.Orders.FirstOrDefault(p => p.ID == instance.ID);
            if (instance.ID == 0)
            {
                cache.TypeOrderID = instance.TypeOrderID;
                cache.State = cache.State;
                cache.Comment = instance.Comment;
                Db.Role.Context.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
