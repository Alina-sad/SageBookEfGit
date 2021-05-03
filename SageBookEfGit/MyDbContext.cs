using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageBookEfGit
{
    public class MyDbContext : DbContext
    {
        static MyDbContext()
        {
            Database.SetInitializer<MyDbContext>(new MyContextInitializer());
        }
        public MyDbContext() : base("conStr") { }

        public virtual DbSet<Sages> Sage { get; set; }
        public virtual DbSet<Books> Book { get; set; }


    }
}
