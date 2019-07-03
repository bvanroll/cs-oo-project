using System.Web;
using Logic;

namespace Gui
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            System.Web.HttpContext.Current.Application["logic"] = new LogicLayer();
            System.Web.HttpContext.Current.Application["debug"] = false;
        }

        
    }
}
