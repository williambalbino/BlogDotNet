using Blog.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infra.Map
{
    class PostMap: EntityTypeConfiguration<Post>
    {
        public PostMap()
        {
            ToTable("posts");

            HasKey(x => x.PostID);
            HasRequired(x => x.Area);
            HasRequired(x => x.Autor);
            HasMany(x => x.Comentarios);

        }
    }
}
