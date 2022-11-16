
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YemekTarifiWebApi.Model
{
    public class Comment :BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public string CommentLine { get; set; }

        public DateTime CreationDate { get; set; }
        
        public DateTime LastModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User? User { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product? Product { get; set; }
    }
}
