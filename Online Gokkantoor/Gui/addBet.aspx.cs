using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using Globals.classes;
using Logic;
using static Globals.main;

namespace Gui
{

    public partial class addBet : System.Web.UI.Page
    {
        LogicLayer logic;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];
                Game currGame = (Game)HttpContext.Current.Application["currGame"];
                teams.DataSource = new List<state> { state.home, state.away, state.draw };
                gameinfo.Text = currGame.ToString();
            }
        }


        public void placeBet(object sender, EventArgs e)
        {
            logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];
            try
            {

                Game currGame = (Game)HttpContext.Current.Application["currGame"];

                IList<state> boundList2 = (IList<state>)teams.DataSource;
                state currPloeg = boundList2[teams.SelectedIndex];

                double cash = double.Parse(amount.Text);
                Person currPers = (Person)HttpContext.Current.Application["user"];
                if (cash > currPers.balance)
                {
                    lblStatus.Text = "You dont have enough cash my guy.";
                }else
                {
                    currPers.balance -= cash;
                    logic.updatePerson(currPers);

                }
                Bet b = new Bet(currGame, currPers, cash, currPloeg);
                logic.addBet(b);
                lblStatus.Text = "Bet placed";
                HttpContext.Current.Application["user"] = currPers;
                return;
            } catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                return;
            }
        }


        public void ret(object sender, EventArgs e)
        {
            Response.Redirect("mainForm.aspx");
        }
    }

    
}
