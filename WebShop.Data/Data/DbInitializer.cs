using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Model;

namespace WebShop.Data.Data
{
    public class DbInitializer
    {
        public static async Task Initialize(ApplicationDbContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.Roles.Any())
            {
                var memberRole =
                new IdentityRole { Name = "Member", NormalizedName = "MEMBER" };
                var sellerRole =
                new IdentityRole { Name = "Seller", NormalizedName = "SELLER" };
                var adminRole =
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" };



                await roleManager.CreateAsync(memberRole);
                await roleManager.CreateAsync(sellerRole);
                await roleManager.CreateAsync(adminRole);

            }
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "Member",
                    Email = "member@gmail.com",

                };

                var result2 =
                await userManager.CreateAsync(user, "aA@123456");
                if (result2.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Member");
                }

                var admin = new User
                {
                    UserName = "Nikola",
                    Email = "mmnpetric@gmail.com",

                };

                await userManager.CreateAsync(admin, "aA@123456");
                await userManager.AddToRolesAsync(admin, new[] { "Member", "Admin" });

                var seller = new User
                {
                    UserName = "Seller",
                    Email = "seller@gmail.com",
                };

                await userManager.CreateAsync(seller, "aA@123456");
                await userManager.AddToRolesAsync(seller, new[] { "Member", "Seller" });
            }
            context.SaveChanges();
        }
    }
}
