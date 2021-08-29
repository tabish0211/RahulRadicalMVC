using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ims.Models
{
    public class ImsCntxt :DbContext
    {
        public ImsCntxt():
            base("name=constr")
        {

        }

        public DbSet<Student> students { get; set; }

    }
}