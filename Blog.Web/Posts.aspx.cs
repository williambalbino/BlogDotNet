using Blog.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Web
{
    public partial class Posts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using ( var contexto = new MeuContexto())
            {
                var posts = contexto.Posts.ToList();
                foreach (var post in posts)
                {
                    Response.Write(post.Titulo);
                    Response.Write(post.Texto);
                    Response.Write(post.Autor);
                    Response.Write(post.Area);
                    Response.Write(post.Comentarios);
                }
            }
        }
    }
}