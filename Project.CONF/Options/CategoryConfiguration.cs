using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class CategoryConfiguration : BaseConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("Ders Kategorileri");

            Property(x=>x.Name).HasColumnName("Kategori Ismi");

        }
    }
}
