using Blog.Dominio.Model;
using Blog.Infra;
using Blog.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Web
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var contexto = new MeuContexto())
            {
                Post post = new Post();
                Usuario user = new Usuario();
                Comentario c = new Comentario();
                Area a = new Area();

                user.Nome = "AutorNome";

                a.Nome = "SI";

                c.Texto = "TextoComentario";

                post.Autor = user;
                post.Titulo = "Titulo Teste";
                post.Texto = "Texto do Post";
               // post.Comentarios.Add(c);
                post.Area = a;

                
                contexto.Posts.Add(post);
                contexto.SaveChanges();
                

                Response.Redirect("Posts.aspx");
            }
        }
    }
}