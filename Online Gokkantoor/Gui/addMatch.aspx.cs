using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Globals.classes;
using Logic;

namespace Gui
{

    public partial class addMatch : System.Web.UI.Page
    {
        LogicLayer logic;
        static List<Ploeg> p;
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];
                dag.DataSource = Enumerable.Range(1, 31).ToArray<int>();
                maand.DataSource= Enumerable.Range(1, 12).ToArray<int>();
                jaar.DataSource = Enumerable.Range(2015, 10).ToArray<int>();
                p = logic.ploegen;
                ploeg1.DataSource = p;
                ploeg2.DataSource = p;
                ploeg1.DataBind();
                ploeg2.DataBind();
                jaar.DataBind();
                maand.DataBind();
                dag.DataBind();
            }
        }

        public void matchadd_Click(object sender, EventArgs e)
        {
            
            logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];
            Ploeg home = logic.getPloegByString(ploeg1.SelectedValue);
            Ploeg away = logic.getPloegByString(ploeg2.SelectedValue);
            int d, m, y = 0;
            if (home == away)
            {
                statusLabel.Text = "selecteer nie dezelfde ploege pls";
                return;
            }
            

            try
            {
                if (score1.Text != "" || score2.Text != "")
                {
                    home.score = int.Parse(score1.Text);
                    away.score = int.Parse(score2.Text);
                }
                d = int.Parse(dag.Text);
                m = int.Parse(maand.Text);
                y = int.Parse(jaar.Text);

            }
            catch (Exception ex)
            {
                statusLabel.Text = "There was a problem parsing the data try again";
                return;
            }
            Game g = new Game(home, away, new DateTime(y, m, d));
            logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];
            logic.addGame(g);
            logic.save();
            System.Web.HttpContext.Current.Application["logic"] = this.logic;
        }

        public void ret(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }
    }
}
