using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStore.BLL.DTO
{
    public class ArticleDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string PictureUrl { get; set; }
        public string Body { get; set; }
        public string AuthorId { get; set; }
        public int CountView { get; set; }
    }
}
