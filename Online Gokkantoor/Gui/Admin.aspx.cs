using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using Globals.classes;
using Logic;

namespace Gui
{

    public partial class Admin : System.Web.UI.Page
    {
        LogicLayer logic;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];
                listGames.DataSource = logic.games;
                listGames.DataBind();
               
            }
        }

        public void addUser_Click(object sender, EventArgs args)
        {
            Server.Transfer("addUser.aspx");

        }
        public void addBet_Click(object sender, EventArgs args)
        {
            Server.Transfer("addBet.aspx");

        }
        public void addMatch_Click(object sender, EventArgs args)
        {
            Server.Transfer("addMatch.aspx");

        }
        public void addPloeg_Click(object sender, EventArgs args)
        {
            Server.Transfer("addPloeg.aspx");

        }

        public void updateGame_Click(object sender, EventArgs args)
        {
            logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];

            HttpContext.Current.Application["currGame"] = logic.getGameByString(listGames.SelectedValue);
            Server.Transfer("updateGame.aspx");
        }


    }
}
