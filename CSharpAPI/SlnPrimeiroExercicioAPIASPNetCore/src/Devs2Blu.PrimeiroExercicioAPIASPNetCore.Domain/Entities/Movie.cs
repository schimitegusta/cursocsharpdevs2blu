using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.PrimeiroExercicioAPIASPNetCore.Domain.Entities
{
    public class Movie
    {
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }

        public Movie(int id, string title, string description, string rating)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Rating = rating;
        }
    }
}
