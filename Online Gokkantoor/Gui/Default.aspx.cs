using System;
using System.Web;
using System.Web.UI;

namespace Gui
{

    public partial class Default : System.Web.UI.Page
    {
        public void button1Clicked(object sender, EventArgs args)
        {
            Server.Transfer("Login.aspx");
        }
        public void buttonAdminClicked(object sender, EventArgs args)
        {
            Server.Transfer("Admin.aspx");
        }
    }
}
