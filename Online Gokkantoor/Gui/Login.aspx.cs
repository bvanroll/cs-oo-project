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
                
            }
        }
        
        protected override void OnInitComplete(EventArgs e)
        {
            base.OnInitComplete(e);
            LogicLayer logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];
            lstUsers.DataSource = logic.persons;
            lstUsers.DataBind();
        }
        protected override void OnPreLoad(EventArgs e)
        {
            base.OnPreLoad(e);
            LogicLayer logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];
            lstUsers.DataSource = logic.persons;
            lstUsers.DataBind();
        }
        protected override void OnLoadComplete(EventArgs e)
        {
            base.OnLoadComplete(e);
            LogicLayer logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];
            lstUsers.DataSource = logic.persons;
            lstUsers.DataBind();
        }
        public void Login_Click(object o, EventArgs e)
        {
            LogicLayer logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];
            HttpContext.Current.Application["user"] = logic.getPersonByString(lstUsers.SelectedValue);
            Server.Transfer("mainForm.aspx");

        }
    }
}
