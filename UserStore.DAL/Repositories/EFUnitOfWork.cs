using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStore.DAL.EF;

namespace UserStore.DAL.Repositories
{
    public class EFUnitOfWork : IDisposable
    {
        private ApplicationContext context;
        private ArticleRepository articleRepository;

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
