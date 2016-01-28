namespace SummitCommunity
{
    using System;
    using System.Web;
    using System.Web.Optimization;
    using System.Web.Routing;

    using SummitCommunity.Helpers;

    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Create the custom role and user.
            var roleActions = new RoleActions();
            roleActions.AddUserAndRole();
        }
    }
}