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
    public partial class Admin : Form
    {
        public LogicLayer l;
        public Admin(LogicLayer l)
        {
            this.l = l;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User a = new User(l);
            this.Hide();
            a.FormClosed += adminClosed;
            a.Show();
        }
        private void adminClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Match a = new Match(l);
            this.Hide();
            a.FormClosed += adminClosed;
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Team a = new Team(l);
            this.Hide();
            a.FormClosed += adminClosed;
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateMatch a = new UpdateMatch(l);
            this.Hide();
            a.FormClosed += adminClosed;
            a.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = l.GetGames();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
