using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using WebApplication1.Models;

[assembly: OwinStartupAttribute(typeof(WebApplication1.Startup))]
namespace WebApplication1
{
    public partial class Startup
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateDefaultRolesAndUser();
        }
        public void CreateDefaultRolesAndUser()
        {
            var roleMager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var UserManger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            IdentityRole role = new IdentityRole();
            if (!roleMager.RoleExists("Admin"))
            {
                role.Name = "Admin";
                roleMager.Create(role);
                ApplicationUser user = new ApplicationUser();
                user.UserName = "Khalid";
                user.Email = "aljokar014@gmail.com";
                var check = UserManger.Create(user, "JR@13@jr");
                if (check.Succeeded)
                {
                    UserManger.AddToRole(user.Id, "Admin");
                }
            }
        }
    }
}
