using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Model
{
    public interface IRepository
    {
        #region Role
        IQueryable<Role> Roles { get; }

        bool CreateRole(Role instance);

        bool UpdateRole(Role instance);

        bool RemoveRole(int idRole);

        #endregion


        #region User

        IQueryable<User> Users { get; }

        bool CreateUser(User instance);

        bool UpdateUser(User instance);

        bool RemoveUser(int idUser);

        User GetUser(string email);

        User Login(string email, string password);

        #endregion

        #region Orders

        IQueryable<Orders> AllOrders { get; }

        bool CreateOrder(Orders instance);

        bool UpdateOrder(Orders instance);

        bool RemoveOrder(int idOrder);

        #endregion

        #region News

        IQueryable<News> AllNews { get; }

        bool CreateNews(News instance);

        bool UpdateNews(News instance);

        bool RemoveNews(int idOrder);

        #endregion

        #region TypeServices

        IQueryable<TypeServices> Services { get; }

        bool CreateService(TypeServices instance);

        bool UpdateService(TypeServices instance);

        bool RemoveService(int idService);

        #endregion

        #region ShippingDetails

        IQueryable<ShippingDetails> AllDetails { get; }

        bool CreateDetails(ShippingDetails instance);

        bool UpdateDetails(ShippingDetails instance);

        bool RemoveDetails(int idDetails);

        #endregion

        #region UserRole

        IQueryable<UserRole> UserRoles { get; }

        bool CreateUserRole(UserRole instance);

        bool UpdateUserRole(UserRole instance);

        bool RemoveUserRole(int idUserRole);

        #endregion 
    }
}
