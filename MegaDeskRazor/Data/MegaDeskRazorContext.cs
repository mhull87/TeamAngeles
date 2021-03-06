﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazor.Models;

namespace MegaDeskRazor.Data
{
    public class MegaDeskRazorContext : DbContext
    {
        public MegaDeskRazorContext (DbContextOptions<MegaDeskRazorContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDeskRazor.Models.QuoteForm> QuoteForm { get; set; }

        public DbSet<MegaDeskRazor.Models.SurfaceMaterial> SurfaceMaterial { get; set; }

        public DbSet<MegaDeskRazor.Models.RushTime> RushTime { get; set; }
    }
}
