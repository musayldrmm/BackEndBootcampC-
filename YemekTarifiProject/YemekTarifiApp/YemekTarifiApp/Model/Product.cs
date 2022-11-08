using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekTarifiApp.Model
{
    internal class Product : BaseEntity
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public bool IsDeleted { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Category> Categories { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
