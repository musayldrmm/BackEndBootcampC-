using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifiWebApi.Interface;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace YemekTarifiWebApi.Model
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set ; }
        public DateTime CreationDate { get; set ; }
        public DateTime LastModifiedDate { get ; set ; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set ; }
    }
}
