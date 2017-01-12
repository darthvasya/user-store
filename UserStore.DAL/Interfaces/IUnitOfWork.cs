﻿using UserStore.DAL.Identity;
using System;
using System.Threading.Tasks;
using UserStore.DAL.Entities;

namespace UserStore.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationUserManager UserManager { get; }
        IClientManager ClientManager { get; }
        ApplicationRoleManager RoleManager { get; }

        Task SaveAsync();
    }
}
