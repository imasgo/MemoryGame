using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMemory
{
    class Context:DbContext
    {
        public DbSet<LeaderboardClass> Leaders { get; set; }
        public Context():base("localsql")
        {
                
        }
    }
}
