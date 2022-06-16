using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Entity
{
    public class EntityBase
    {
        [Key]
        public int ID { get; set; }
    }
}
