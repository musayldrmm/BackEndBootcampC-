using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekTarifiWebApi.Interface
{
    internal interface IEntity
    {
         int Id { get; set; }
         DateTime CreationDate { get; set; }

         DateTime LastModifiedDate { get; set; }

         bool IsDeleted { get; set; }
    }
}
