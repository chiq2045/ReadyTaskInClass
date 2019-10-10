using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReadyTask.Models;

namespace ReadyTask.Data
{
    public class ApplicationDbContext : IdentityDbContext<ReadyTaskUser, ReadyTaskUserRole, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TaskItem> TaskItems { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var hasher = new PasswordHasher<ReadyTaskUser>();
            ReadyTaskUser seedUser = new ReadyTaskUser
            {
                Id = 100,
                UserName = "test@test.com",
                Email = "test@test.com",
                NormalizedEmail = "test@test.com".ToUpper(),
                NormalizedUserName = "test@test.com".ToUpper(),
                FirstName = "John",
                LastName = "Doe",
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "password"),
                SecurityStamp = string.Empty
            };
            builder.Entity<ReadyTaskUser>().HasData(seedUser);
            builder.Entity<TaskItem>().HasData(
                new TaskItem[]
                {
                    new TaskItem
                    {
                        Id = 101,
                        Title = "Test Task 1",
                        Description = "Task Description",
                        AssignedUserId = null
                    },
                    new TaskItem
                    {
                        Id = 102,
                        Title = "Test Task 2",
                        Description = "Task Description",
                        AssignedUserId = null
                    },
                    new TaskItem
                    {
                        Id = 103,
                        Title = "Test Task 3",
                        Description = "Task Description",
                        AssignedUserId = 100
                    }
                }

                );
        }
    }
}
