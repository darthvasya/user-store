using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStore.DAL.Entities;

namespace UserStore.DAL.Interfaces
{
    public interface IArticleManager : IDisposable
    {
        void Add(Article item);
        void Update(Article item);
        void Delete(Article item);
        void Delete(int id);
        IEnumerable<Article> GetAll();
        Article GetById(string id);
        Article GetById(int id);
        void Commit();
    }
}
