using Blog.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infra.Map
{
    class AreaMap: EntityTypeConfiguration<Area>
    {
        public AreaMap()
        {
            ToTable("areas");
            HasKey(x => x.AreaID);
            Property(x => x.Nome).HasMaxLength(150).IsRequired();
            

        }
    }
}
