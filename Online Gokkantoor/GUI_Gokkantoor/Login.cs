using Globals.classes;
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
    public partial class Login : Form
    {
        public LogicLayer l;
        public Login(LogicLayer l)
        {
            l = new LogicLayer();
            InitializeComponent();
            listBox1.DataSource = l.persons;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = (Person)listBox1.SelectedItem;




            Gokspel a = new Gokspel(l,p);
            this.Hide();
            a.FormClosed += adminClosed;
            a.Show();
        }
        private void adminClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
