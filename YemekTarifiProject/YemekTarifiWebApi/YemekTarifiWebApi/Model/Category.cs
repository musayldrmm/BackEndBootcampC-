using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekTarifiWebApi.Model
{
    public class Category:BaseEntity
    {
        public int Id { get; set; }

        public string? CategoryName { get; set; }
        [JsonIgnore]
        public virtual List<Product>? Products { get; set; }
    }
}
