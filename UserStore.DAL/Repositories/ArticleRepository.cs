using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStore.DAL.EF;
using UserStore.DAL.Entities;
using UserStore.DAL.Interfaces;

namespace UserStore.DAL.Repositories
{
    public class ArticleRepository : IRepository<Article>
    {
        private ApplicationContext context;

        public ArticleRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public void Create(Article item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> Find(Func<Article, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Article Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetAll()
        {
            return context.Articles;
        }

        public void Update(Article item)
        {
            throw new NotImplementedException();
        }
    }
}
