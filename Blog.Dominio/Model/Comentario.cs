using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Dominio.Model
{
    public class Comentario
    {
        public int ComentarioID { get; set; }
        public string Texto { get; set; }
        public DateTime DataCadastro { get; set; }
        public Usuario Autor { get; set; }
        public Post Post { get; set; }
        public int PostID { get; set; }
        public int AutorID { get; set; }


        public Comentario()
        {
            
        }
    }
}
