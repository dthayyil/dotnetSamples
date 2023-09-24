using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSamples.Domain.Common
{
    public abstract class BaseEntity<T>
    {
         
        public required T Id { get; set; }

         
    }

}
