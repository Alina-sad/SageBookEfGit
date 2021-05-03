using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageBookEfGit
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public virtual ICollection<Sages> Sage { get; set; }

        public Books()
        {
            Sage = new List<Sages>();
        }

    }
}
