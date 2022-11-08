using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifiApp.Interface;

namespace YemekTarifiApp.Model
{
    internal class BaseEntity : IEntity
    {
        public int Id { get; set ; }
        public DateTime CreationDate { get; set ; }
        public DateTime LastModifiedDate { get ; set ; }
        public bool IsDeleted { get; set ; }
    }
}
