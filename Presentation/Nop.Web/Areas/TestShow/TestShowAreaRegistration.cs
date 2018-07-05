using System.Web.Mvc;

namespace Nop.Web.Areas.TestShow
{
    public class TestShowAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TestShow";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "TestShow_default",
                "TestShow/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}