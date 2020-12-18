using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class PersonalInformation
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime Birthday { get; set; }

        public bool RelationshipStatus { get; set; }



    }
}
