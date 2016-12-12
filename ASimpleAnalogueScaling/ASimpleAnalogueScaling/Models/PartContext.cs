using ScalingApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScalingApp.Models
{
    public class PartContext : DbContext
    {
        public DbSet<Part> Parts { get; set; }
        //public int EmpID { get; set; }
        //public string Name { get; set; }
        //public string City { get; set; }

    }
  
}