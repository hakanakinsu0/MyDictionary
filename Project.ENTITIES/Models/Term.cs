using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Term : BaseEntity
    {
        public string Name { get; set; }  //Kavram adı (örneğin, "Inheritance")
        public string Description { get; set; } //Kavram aciklamasi

        public int CategoryId { get; set; }

        //Relational Properties

        //1 kavram 1 kategoride ve 1 kategoride birden fazla kavram olabilir.
        public virtual Category Category { get; set; }
    }
}
