using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class Posts
    {
        [Key]
        public int Id { get; set; }

        public double Likes { get; set; }

        public string Comment { get; set; }



    }
}
