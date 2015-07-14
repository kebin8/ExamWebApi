using System.Web.Http;

namespace ExamWebAPI
{
    public class WebAPIApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebAPIConfig.Register);
        }
    }
}
