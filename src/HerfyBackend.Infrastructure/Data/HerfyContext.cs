/*
 * Copyright (c) 2025 AOLabs
 * This file is part of the AOLabs Herfy project.
 *
 * Licensed under the MIT License.
 * You may obtain a copy of the License at:
 * https://opensource.org/licenses/MIT
 *
 * You are free to use, modify, and distribute this file
 * under the terms of the license.
 */
 
using Microsoft.EntityFrameworkCore;

namespace HerfyBackend.Infrastructure.Data;

public class HerfyContext : DbContext
{
    public HerfyContext(DbContextOptions<HerfyContext> options)
        : base(options)
    {
    }

    // Define DbSets for your entities here
    // public DbSet<YourEntity> YourEntities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Configure your entity mappings here
        // modelBuilder.Entity<YourEntity>().ToTable("YourTableName");
    }
}

