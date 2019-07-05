using System;
using System.Diagnostics;
using System.Web;
using System.Web.UI;
using Globals.classes;
using Logic;

namespace Gui
{

    public partial class mainForm : System.Web.UI.Page
    {
        LogicLayer logic;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];
                listGames.DataSource = logic.games;
                listGames.DataBind();
                Person test = (Globals.classes.Person)HttpContext.Current.Application["user"];
                Debug.Print(test.ToString());
            }
        }

        public void btnAddBalance_Click(object o, EventArgs e)
        {

        }

        public void placeBet_Click(object o, EventArgs e)
        {

        }
    }
}
