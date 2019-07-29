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
    public partial class Form1 : Form
    {
        public LogicLayer l;
        public Form1()
        {
            l = new LogicLayer();
            InitializeComponent();
        }

        //herhalende code
        private void button2_Click(object sender, EventArgs e)
        {
            Admin a = new Admin(l);
            this.Hide();
            a.FormClosed += adminClosed;
            a.Show();
        }
        private void adminClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login a = new Login(l);
            this.Hide();
            a.FormClosed += adminClosed;
            a.Show();
        }
    }
}
