
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YemekTarifiWebApi.Model
{
    public class Comment :BaseEntity
    {

        public string CommentLine { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]

        public virtual User? User { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        [JsonIgnore]
        public virtual Product? Product { get; set; }
    }
}
