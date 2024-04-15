using System;
using System.Data.Entity;
using Zefirka.Domain;

namespace ZefirkaBuisnessLogic.Interfaces
{
    public class UserContext : DbContext
    {
        public UserContext() :
             base("name=Zefirka.Web")
        {
        }

        public virtual DbSet<UDBTable> Users { get; set; }
    }
}