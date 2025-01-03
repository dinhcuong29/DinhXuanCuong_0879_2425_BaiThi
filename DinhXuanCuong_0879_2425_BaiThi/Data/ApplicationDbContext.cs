using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DinhXuanCuong_0879_2425_BaiThi.Models;

namespace DinhXuanCuong_0879_2425_BaiThi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DinhXuanCuong_0879_2425_BaiThi.Models.Person> Person { get; set; } = default!;
        public DbSet<DinhXuanCuong_0879_2425_BaiThi.Models.Employee> Employee { get; set; } = default!;
    }
}
