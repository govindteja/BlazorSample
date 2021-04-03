using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSample.Data.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
    }
}
