using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } // Kategori adı (örneğin, "SQL")

        //Relational Properties
        //1 kavram 1 kategoride ve 1 kategoride birden fazla kavram olabilir.

        public virtual List<Term> Terms { get; set; }
    }
}
