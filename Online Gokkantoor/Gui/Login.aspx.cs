using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using Logic;

namespace Gui
{

    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                LogicLayer logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];
                lstUsers.DataSource = logic.persons;
                lstUsers.DataBind();
            }
        }
        protected override void OnInitComplete(EventArgs e)
        {
            base.OnInitComplete(e);
        }
        protected override void OnPreLoad(EventArgs e)
        {
            base.OnPreLoad(e);
        }
        public void Login_Click(object o, EventArgs e)
        {
            HttpContext.Current.Application["user"] = lstUsers.SelectedItem;
            Server.Transfer("mainForm.aspx");

        }
    }
}
