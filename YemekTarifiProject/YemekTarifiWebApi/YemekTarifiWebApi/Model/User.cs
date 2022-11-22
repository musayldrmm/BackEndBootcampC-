using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekTarifiWebApi.Model
{
    [Index(nameof(User.Email), IsUnique = true)]
    public class User :BaseEntity
    {


        public string Name { get; set; }

        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public string Password { get; set; }

        public string Gender { get; set; }


        [JsonIgnore]
        public virtual ICollection<Product>? Products { get; set; }
        [JsonIgnore]
        public virtual ICollection<Comment>? Comments { get; set; } 
    }
}
