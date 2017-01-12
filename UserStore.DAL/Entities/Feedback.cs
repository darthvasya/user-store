using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UserStore.DAL.Entities
{

    public class Feedback
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public string Telephone { get; set; }

        [Required]
        public string Body { get; set; }

        [DefaultValue(false)]
        public bool Viewed { get; set; }
    }
}
