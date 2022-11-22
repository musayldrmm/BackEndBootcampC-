using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using YemekTarifiWebApi.Model;

namespace YemekTarifiWebApi.Dto
{
    public class ProductDto
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        [DefaultValue(false)]

        public bool IsDeleted { get; set; }

        public int UserId { get; set; }

        public int CategoryId { get; set; }
        

    }
}
