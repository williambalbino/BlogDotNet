using Blog.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infra.Map
{
    class UsuarioMap: EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("usuarios");
            HasKey(x => x.UsuarioID);
            Property(x => x.Nome).HasMaxLength(150).IsRequired();
            HasMany(x => x.Comentarios);
            HasMany(x => x.Posts);

        }
     }
}
