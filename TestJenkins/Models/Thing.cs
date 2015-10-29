using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestJenkins.Models
{
    public class Thing
    {
        public long ThingId { get; set; }
        public string Name { get; set; }
    }

    
public class MyAppContext : DbContext
{
    public DbSet<Thing> Things { get; set; }
    public MyAppContext() : base("MyAppContext") { }

}
}