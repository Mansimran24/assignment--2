using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodDelivery.foodie;

    public class fooddeliveryfoodContext : DbContext
    {
        public fooddeliveryfoodContext (DbContextOptions<fooddeliveryfoodContext> options)
            : base(options)
        {
        }

        public DbSet<FoodDelivery.foodie.foodie> foodie { get; set; }
    }
