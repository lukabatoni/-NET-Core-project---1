using Forum.Domain.topic;
using Forum.Domain.user;
using Forum.Persistence.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Forum.Persistence.Seed
{
    public class ForumManagementSeed
    {
        public static async Task SeedUsersAndRolesAsync(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ForumManagementIdentityContext>()!;

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<int>>>();

                

                if (!await roleManager.RoleExistsAsync("Administrator"))
                {
                    var AdminRole = new IdentityRole<int>("Administrator");
                    AdminRole.NormalizedName = "ADMINISTRATOR";
                    await roleManager.CreateAsync(AdminRole);
                }

                if (!await roleManager.RoleExistsAsync("User"))
                {
                    var UserRole = new IdentityRole<int>("User");
                    UserRole.NormalizedName = "USER";
                    await roleManager.CreateAsync(UserRole);
                }

                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<User>>();
                string adminUserEmail = "teddysmithdeveloper@gmail.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new User()
                    {
                        UserName = "teddysmithdev",
                        NormalizedUserName = "TEDDYSMITHDEV",
                        Email = adminUserEmail,
                        NormalizedEmail = adminUserEmail.ToUpper(),
                        CreatedAt = DateTime.Now,
                        ModifiedAt = DateTime.Now
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, "Administrator");
                    await userManager.AddToRoleAsync(newAdminUser, "User");

                    var newUser1 = new User()
                    {
                        UserName = "gio",
                        NormalizedUserName = "GIO",
                        Email = "gio@gmail.com",
                        NormalizedEmail = "GIO@GMAIL.COM",
                        CreatedAt = DateTime.Now,
                        ModifiedAt = DateTime.Now
                    };
                    await userManager.CreateAsync(newUser1, "Coding@1234?");
                    await userManager.AddToRoleAsync(newUser1, "User");


                    var newUser2 = new User()
                    {
                        UserName = "LUKA",
                        NormalizedUserName = "LUKA",
                        Email = "LUKA@gmail.com",
                        NormalizedEmail = "LUKA@GMAIL.COM",
                        CreatedAt = DateTime.Now,
                        ModifiedAt = DateTime.Now
                    };
                    await userManager.CreateAsync(newUser2, "Coding@1234?");
                    await userManager.AddToRoleAsync(newUser2, "User");


                    var topic = new Topic
                    {
                        AuthorId = newAdminUser.Id,
                        Title = "Title1",
                        Content = "Content here",
                        CreatedAt = DateTime.Now,
                        ModifiedAt = DateTime.Now

                    };

                    var topic2 = new Topic
                    {
                        AuthorId = newAdminUser.Id,
                        Title = "Title2",
                        Content = "Content here2",
                        CreatedAt = DateTime.Now,
                        ModifiedAt = DateTime.Now

                    };

                    await context.Topic.AddAsync(topic);
                    await context.Topic.AddAsync(topic2);
                }

                await context.SaveChangesAsync();


            }
        }
    }
}
