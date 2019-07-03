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
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];
                dag.DataSource = Enumerable.Range(1, 31).ToArray<int>();
                dag.DataBind();
                maand.DataSource= Enumerable.Range(1, 12).ToArray<int>();
                maand.DataBind();
                jaar.DataSource = Enumerable.Range(2015, 10).ToArray<int>();
                jaar.DataBind();
                ploeg1.DataSource = logic.ploegen;
                ploeg1.DataBind();
                ploeg2.DataSource = logic.ploegen;
                ploeg2.DataBind();
            }
        }

        public void matchadd_Click(object sender, EventArgs e)
        {
            IList<Ploeg> p1l = (IList<Ploeg>)ploeg1.DataSource;
            IList<Ploeg> p2l = (IList<Ploeg>)ploeg2.DataSource;
            Ploeg home = p1l[ploeg1.SelectedIndex];
            Ploeg away = p2l[ploeg2.SelectedIndex];
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
