using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class TermConfiguration : BaseConfiguration<Term>
    {
        public TermConfiguration()
        {
            ToTable("Kavramlar");

            Property(x => x.Name).HasColumnName("Kavram Adi");
            Property(x => x.Description).HasColumnName("Kavram Aciklamasi");
        }
    }
}
