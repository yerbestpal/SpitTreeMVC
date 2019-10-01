using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SpitTree.Models
{
    public class SpitTreeDbContext : IdentityDbContext<User>
    {
        public SpitTreeDbContext()
            : base("SpitTreeConnection2", throwIfV1Schema: false) // superclass
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public static SpitTreeDbContext Create()
        {
            return new SpitTreeDbContext();
        }
    }
}