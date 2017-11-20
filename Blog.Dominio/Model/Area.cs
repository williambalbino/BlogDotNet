using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Dominio.Model
{
    public class Area
    {
        public int AreaID { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Post> Posts { get; set; }

        public Area()
        {
            Posts = new List<Post>();
        }
    }
}
