using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Entity
{
    public class Users : EntityBase
    {
        public string nvcUsername { get; set; }
        public string nvcPassword { get; set; }
        public string nvcEmail { get; set; }
        public string nvcFName { get; set; }
        public string nvcLName { get; set; }
        public string nvcRegDate { get; set; }
        public byte tiIsActive { get; set; }
    }
}
