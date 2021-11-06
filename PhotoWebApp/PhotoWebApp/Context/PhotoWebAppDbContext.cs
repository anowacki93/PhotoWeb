
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoWebApp.Context
{
    public class PhotoWebAppDbContext :DbContext
    {
        public PhotoWebAppDbContext(DbContextOptions<PhotoWebAppDbContext> options) : base(options)
        {

        }
    }
}
