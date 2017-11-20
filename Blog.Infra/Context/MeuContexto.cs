namespace Blog.Infra.Context
{
    using Dominio.Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MeuContexto : DbContext
    {
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Comentario> Comentarios { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public MeuContexto()
            : base("MeuContexto")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}