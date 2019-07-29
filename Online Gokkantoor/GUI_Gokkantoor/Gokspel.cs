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
    public partial class Gokspel : Form
    {
        public LogicLayer l;
        public Gokspel(Logic.LogicLayer l)
        {
            l = new LogicLayer();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetGok a = new SetGok(l);
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
            AddBalance a = new AddBalance(l);
            this.Hide();
            a.FormClosed += adminClosed;
            a.Show();
        }
    }
}
