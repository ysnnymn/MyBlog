using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.EntityLayer.Concrete;
using System;
using System.Threading.Tasks;

namespace MyBlogPresentationLayer.Helpers
{
    public static class AdminSeeder
    {
        public static async Task SeedAsync(IServiceProvider serviceProvider)
        {
            // RoleManager ve UserManager servislerini al
            var roleManager = serviceProvider.GetRequiredService<RoleManager<AppRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();

            // 1️⃣ Admin rolünü oluştur
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                var adminRole = new AppRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                };
                await roleManager.CreateAsync(adminRole);
            }

            // 2️⃣ Admin kullanıcıyı oluştur
            string adminEmail = "admin@site.com";   // değiştirilebilir
            string adminPassword = "Admin123!";     // güçlü bir şifre kullan

            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                adminUser = new AppUser
                {
                    UserName = "admin",
                    Email = adminEmail,
                    Name = "Admin",
                    Surname = "User",
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(adminUser, adminPassword);
            }

            // 3️⃣ Kullanıcıya Admin rolünü ata
            if (!await userManager.IsInRoleAsync(adminUser, "Admin"))
            {
                await userManager.AddToRoleAsync(adminUser, "Admin");
            }
        }
    }
}