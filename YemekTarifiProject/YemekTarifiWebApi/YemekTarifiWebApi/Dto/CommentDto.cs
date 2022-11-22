using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using YemekTarifiWebApi.Model;

namespace YemekTarifiWebApi.Dto
{
    public class CommentDto
    {
        public string CommentLine { get; set; }

        public int UserId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        [DefaultValue(false)]

        public bool IsDeleted { get; set; }

        public int ProductId { get; set; }
        
    }
}
