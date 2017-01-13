using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStore.BLL.DTO;
using UserStore.BLL.Interfaces;
using UserStore.DAL.Entities;
using UserStore.DAL.Interfaces;

namespace UserStore.BLL.Services
{
    public class ArticleService : IArticleService
    {
        IUnitOfWork _context { get; set; }
        public ArticleService(IUnitOfWork context)
        {
            this._context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public ArticleDTO GetArticle(int id)
        {
            var article = _context.ArticleRepository.Get(id); ;
            Mapper.Initialize(cfg => cfg.CreateMap<Article, ArticleDTO>());
            return Mapper.Map<Article, ArticleDTO>(article);
        }

        public IEnumerable<ArticleDTO> GetArticles()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            Mapper.Initialize(cfg => cfg.CreateMap<Article, ArticleDTO>());
            return Mapper.Map<IEnumerable<Article>, List<ArticleDTO>>(_context.ArticleRepository.GetAll());
        }
    }
}
