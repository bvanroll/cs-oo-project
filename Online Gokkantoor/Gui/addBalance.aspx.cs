using System;
using System.Web;
using System.Web.UI;
using Globals.classes;

namespace Gui
{

    public partial class addBalance : System.Web.UI.Page
    {
        public void add(Object o, EventArgs e)
        {
            try
            {
                double bal = double.Parse(balans.Text);
                ((Person)HttpContext.Current.Application["user"]).balance += bal;
                Response.Redirect("mainForm.aspx");

            }
            catch (Exception ex)
            {
                statusLabel.Text = "There was a problem parsing the balance, try again. (format 0.00)";
                return;
            }
        }
    }
}
