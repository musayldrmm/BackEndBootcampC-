using System.ComponentModel;

namespace YemekTarifiWebApi.Dto
{
    public class CategoryDto
    {
        public string CategoryName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
