using System.Web.Mvc;

namespace WebApplication7.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "DoiBong", id = UrlParameter.Optional },
                new[] { "WebApplication7.Areas.Admin.Controllers"}
            );
        }
    }
}