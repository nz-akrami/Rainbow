using Microsoft.EntityFrameworkCore;
using Rainbow.Application.Interface;
using Rainbow.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Presistence.context
{
    public class DataBaseContext:DbContext,IDataBaseContext
    {
        public DbSet<Car> cars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("");
        }
    }
}
