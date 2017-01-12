using System.ComponentModel.DataAnnotations;

namespace UserStore.DAL.Entities
{
    public class ProjectType
    {
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
