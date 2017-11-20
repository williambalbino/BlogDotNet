using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Dominio.Model
{
    public class Post
    {
        public int PostID { get; set; }
        public string DataCadastro { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public Usuario Autor { get; set; }
        public Area Area { get; set; }
        public int AutorID { get; set; }
        public int AreaID { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }

        public Post()
        {
            Comentarios = new List<Comentario>();
        }
    }
}
