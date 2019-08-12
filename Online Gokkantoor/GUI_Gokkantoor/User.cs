using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Gokkantoor
{
    public partial class User : Form
    {
        LogicLayer l;
        public User(Logic.LogicLayer l)
        {
            InitializeComponent();
            this.l = l;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                l.addPerson(new Globals.classes.Person(naam.Text, achternaam.Text, adres.Text, gsm.Text, double.Parse(balans.Text)));
                l.save();

            } catch (Exception ex)
            {
                // geen correcte double ingegeven wss. niet vergeten popup te schrijven.
            }
        }
    }
}
