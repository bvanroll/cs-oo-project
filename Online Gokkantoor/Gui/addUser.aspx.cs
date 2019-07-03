using System;
using System.Diagnostics;
using System.Web;
using System.Web.UI;
using Globals.classes;
using Logic;

namespace Gui
{

    public partial class addUser : System.Web.UI.Page
    {
        private LogicLayer logic;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                this.logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];

            }
        }
        public void test(object sender, EventArgs e)
        {
            this.logic = (LogicLayer)System.Web.HttpContext.Current.Application["logic"];

            string name = txtName.Text;
            string lastname = txtLastName.Text;
            string adress = txtAddr.Text;
            string gsm = txtGsm.Text;
            double balance = 0;
            try
            {
                balance = double.Parse(txtBalance.Text);

            }
            catch (Exception ex)
            {
                if ((bool)System.Web.HttpContext.Current.Application["debug"])
                {
                    alertlabel.Text = ex.ToString();
                    return;
                }
                alertlabel.Text = "There was a problem parsing your balance. Try formatting the balance as {0.00}";
                return;
            }
            Person p = new Person(name, lastname, adress, gsm, balance);
            logic.addPerson(p);
            logic.save();
            System.Web.HttpContext.Current.Application["logic"] = logic;
        }
        public void ret(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }
    }
}
