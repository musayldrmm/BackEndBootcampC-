
namespace YemekTarifiWebApi.Model
{
    public class Comment :BaseEntity
    {
        public int Id { get; set; }

        public string CommentLine { get; set; }

        public DateTime CreationDate { get; set; }
        
        public DateTime LastModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
