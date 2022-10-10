using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HData.Model
{
    public class DataModel : DbContext
    {
        public DataModel(DbContextOptions<DataModel> options) : base(options)
        {
        }


        //Tables in the DB
        public virtual DbSet<CBSteering> CBSteering { get; set; }
        


        //SP in the DB

        //public virtual DbSet<> XXXX { get; set; }
        //public virtual DbSet<> XXXX { get; set; }
    }
}
