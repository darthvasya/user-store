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
    class ArticleManager : IArticleManager
    {
        public ApplicationContext _context { get; set; }
        public ArticleManager(ApplicationContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Add(Article item)
        {
            _context.Articles.Add(item);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Article item)
        {
            _context.Articles.Remove(item);
        }

        public IEnumerable<Article> GetAll()
        {
            return _context.Articles;
        }

        public Article GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Article GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Article item)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }
    }
}
