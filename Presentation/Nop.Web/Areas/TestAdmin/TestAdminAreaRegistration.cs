using System.Web.Mvc;

namespace Nop.Web.Areas.TestAdmin
{
    public class TestAdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TestAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "TestAdmin_default",
                "TestAdmin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}