using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Repository.Core
{
    public class MVC_DbContext:DbContext
    {
        public MVC_DbContext(DbContextOptions options ) : base(options)
        {
        } 
        public  DbSet<Shop> Shop { get; set; }      
    }
}
