using System;
using System.Web;
using System.Web.UI;
using Globals.classes;
using Logic;

namespace Gui
{

    public partial class updateGame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                Game g = (Game)System.Web.HttpContext.Current.Application["currGame"];
                thuis.Text = g.home.ToString();
                uit.Text = g.away.ToString();

            }
        }
        public void scores(Object o, EventArgs e)
        {
            Game g = (Game)System.Web.HttpContext.Current.Application["currGame"];
            LogicLayer logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];

            try
            {
                int a = int.Parse(scoreThuis.Text);
                int b = int.Parse(scoreUit.Text);
                g.home.score = a;
                g.away.score = b;

            } catch (Exception ex)
            {

            }
        }
    }
}
