using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Dominio.Model
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string DataCadastro { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }


        public Usuario()
        {
            Posts = new List<Post>();
            Comentarios = new List<Comentario>();
        }
    }
}
