using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Sử dụng EntityFramework
using System.Data.Entity;

namespace EntityFrameworkDemo.Models
{
  class Context : DbContext
  {
    public DbSet<Student> students { get; set; }
    public DbSet<Group> groups { get; set; }
  }
}
