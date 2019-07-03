using System;
using System.Web;
using System.Web.UI;
using Globals.classes;
using Logic;

namespace Gui
{

    public partial class addPloeg : System.Web.UI.Page
    {
        LogicLayer logic;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];

            }
        }
        public void confirm_Click(object sender, EventArgs e)
        {
            Ploeg p = new Ploeg(naam.Text);
            logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];
            logic.addPloeg(p);
            logic.save();
            HttpContext.Current.Application["logic"] = logic;
        }
        public void ret_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }
    }
}
