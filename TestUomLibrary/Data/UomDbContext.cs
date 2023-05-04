using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UomLibrary.Data;
using UomLibrary.Models;

namespace TestUomLibrary.Data
{
    internal class UomDbContext : UomLibrary.Data.Uom2023Context
    {
        public UomDbContext() { }
        public DbSet<UnitsOfMeasure> Units { get; set; }
    }
}
