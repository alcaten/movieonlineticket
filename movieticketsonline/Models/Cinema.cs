using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace movieticketsonline.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string CinemaName { get; set; }
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
