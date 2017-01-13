using UserStore.DAL.Identity;
using System;
using System.Threading.Tasks;
using UserStore.DAL.Entities;
using UserStore.DAL.Repositories;

namespace UserStore.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        #region Identiy
        ApplicationUserManager UserManager { get; }
        IClientManager ClientManager { get; }
        ApplicationRoleManager RoleManager { get; }

        Task SaveAsync();
        #endregion

        #region Data
        IRepository<Article> ArticleRepository { get; }

        void Save();
        #endregion

    }
}
