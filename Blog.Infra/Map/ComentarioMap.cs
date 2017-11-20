using Blog.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infra.Map
{
    class ComentarioMap: EntityTypeConfiguration<Comentario>
    {
        public ComentarioMap()
        {
            ToTable("comentarios");
            HasKey(x => x.ComentarioID);
            Property(x => x.Texto).HasMaxLength(500).IsRequired();

        }
    }
}
