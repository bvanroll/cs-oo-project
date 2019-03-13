using DataLaag;
using LogicLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Online_Gokkantoor
{
    public partial class Aanmeldscherm : Form
    {
        public int[] p_ID;
        public int[] w_ID;
        public General g;
        private List<Persoon> personen = new List<Persoon>();
        private string[] uitkomsten = { "Uitploeg", "Gelijk", "Thuisploeg" };
        public Aanmeldscherm()
        {
            InitializeComponent();
            try
            {
                g = new General();
                g.Deserialize();
                UpdateUI();

            } catch (Exception e )
            {
                labelError.Text = "error throw: " + e;
            }
        }

        private void UpdateUI()
        {
            GebruikersBox.DataSource = g.GetGebruikers();
            matchbox.DataSource = g.GetWedstrijden();
            p_ID = g.GetP_ID();
            w_ID = g.GetW_ID();
            labelError.Text = "";
        }
        private void Save()
        {
            string nieuw = JsonConvert.SerializeObject(personen);
            Debug.WriteLine(nieuw);
        }

        private string RandomGok()
        {
            Random randm = new Random();
            int willekeurigeGok = randm.Next(0, 2);
            return uitkomsten[willekeurigeGok];
        }

        private void knopGokken(object sender, EventArgs e)
        {
            try
            {
                int per_ID = p_ID[GebruikersBox.SelectedIndex];
                int wed_ID = w_ID[matchbox.SelectedIndex];
                g.PlaatsGok(wed_ID, per_ID, Double.Parse(textInzet.Text), comboKeuze.Items[comboKeuze.SelectedIndex].ToString());
            }catch(Exception e2)
            {
                labelError.Text = e2 + "";
            }
            UpdateUI();
        }

        private void matchbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                labelMatch.Text = (string)this.matchbox.SelectedItem;
                List<string> geld = g.GetGeldVerdubbeling(w_ID[matchbox.SelectedIndex]);
                labelThuisploeg.Text = "Thuisploeg:" + geld[0];
                labelGelijk.Text = "Gelijk:" + geld[1];
                labelUitploeg.Text = "Uitploeg:" + geld[2];
            }catch (Exception exceptie)
            {
                labelError.Text = exceptie + "";
            }
        }

        private void Aanmeldscherm_Load(object sender, EventArgs e)
        {    
            labelThuisploeg.Text = "Thuisploeg:";
            labelGelijk.Text = "Gelijk:";
            labelUitploeg.Text = "Uitploeg:";
            
            foreach(string s in uitkomsten)
            {
                comboKeuze.Items.Add(s);
            }
        }

        private void GebruikersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ID = p_ID[GebruikersBox.SelectedIndex];

                labelWinst.Text = g.GetWinst(ID) + "€";
            }catch(Exception e1)
            {
                labelError.Text = e1 + "";
            }
        }

        private void buttonGebruikerToevoegen(object sender, EventArgs e)
        {
            try
            {
                g.MaakVoorbeelden();
                UpdateUI();
            }
            catch (Exception ex)
            {
                labelError.Text = ex + "";
            }
        }

        private void buttonExit(object sender, EventArgs e)
        {
            UpdateUI();
            g.Serialize();
            this.Close();
        }
    }
}
