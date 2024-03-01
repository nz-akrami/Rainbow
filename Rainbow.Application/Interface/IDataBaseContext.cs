using Microsoft.EntityFrameworkCore;
using Rainbow.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Application.Interface
{
    public interface IDataBaseContext
    {
       DbSet<Car>cars { get; }
    }
}
