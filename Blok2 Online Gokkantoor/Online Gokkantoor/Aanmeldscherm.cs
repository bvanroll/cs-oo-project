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
        private int[] persoonID;
        private int[] wedstrijdID;
        private General g;
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

            }
            catch (System.NullReferenceException probleem)
            {
                Debug.WriteLine(probleem);
            }
            catch (Exception e )
            {
                System.Windows.Forms.MessageBox.Show(e + "");
            }
        }

        private void UpdateUI()
        {
            gebruikersBox.DataSource = g.GetGebruikers();
            matchbox.DataSource = g.GetWedstrijden();
            persoonID = g.GetPersoonID();
            wedstrijdID = g.GetWedstrijdID();
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
                int gebruikerID = persoonID[gebruikersBox.SelectedIndex];
                int matchID = wedstrijdID[matchbox.SelectedIndex];
                g.PlaatsGok(matchID, gebruikerID, Double.Parse(textInzet.Text), comboKeuze.Items[comboKeuze.SelectedIndex].ToString());
            }
            catch (System.NullReferenceException probleem)
            {
                Debug.WriteLine(probleem);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                System.Windows.Forms.MessageBox.Show("Zorg ervoor dat een geldige gebruiker, match en uitkomst geselecteerd zijn.");
            }
            catch (System.FormatException error)
            {
                System.Windows.Forms.MessageBox.Show($"Kan {textInzet.Text} niet omzetten naar double");
            }
            catch (Exception e2)
            {
                System.Windows.Forms.MessageBox.Show(e2 + "");
            }
        }

        private void matchbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                labelMatch.Text = (string)this.matchbox.SelectedItem;
                List<string> geld = g.GetGeldVerdubbeling(wedstrijdID[matchbox.SelectedIndex]);
                labelThuisploeg.Text = "Thuisploeg:" + geld[0];
                labelGelijk.Text = "Gelijk:" + geld[1];
                labelUitploeg.Text = "Uitploeg:" + geld[2];

            }
            catch (System.NullReferenceException probleem)
            {
                Debug.WriteLine(probleem);
            }
            catch (Exception exceptie)
            {
                System.Windows.Forms.MessageBox.Show(exceptie + "");
            }
            //UpdateUI();
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
                int ID = persoonID[gebruikersBox.SelectedIndex];

                labelWinst.Text = g.GetWinst(ID) + "€";

            }
            catch (System.NullReferenceException probleem)
            {
                Debug.WriteLine(probleem);
            }
            catch (Exception e1)
            {
                System.Windows.Forms.MessageBox.Show(e1 + "");
            }
        }

        private void knopGebruikerToevoegen(object sender, EventArgs e)
        {
            string tmp = "";
            if (textVoornaam.Text.Length == 0) tmp+= "\n een voornaam";
            if (textNaam.Text.Length == 0) tmp += "\n een naam";
            if (textAdres.Text.Length == 0) tmp += "\n een adres";
            if (textGsm.Text.Length == 0) tmp += "\n een gsm nummer";
            if (tmp.Length > 0)
            {
                System.Windows.Forms.MessageBox.Show($"Please geef volgende argumenten: {tmp}");
                return;
            }
            try
            {
                g.GebruikerToevoegen(textVoornaam.Text, textNaam.Text, textAdres.Text, textGsm.Text);
                UpdateUI();
            }
            catch (System.NullReferenceException probleem)
            {
                Debug.WriteLine(probleem);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex + "");
            }
        }

        private void knopExit(object sender, EventArgs e)
        {
            UpdateUI();
            g.Serialize();
            this.Close();
        }

        private void buttonCloneGebruiker_Click(object sender, EventArgs e)
        {
            try
            {
                g.ClonePersoon(persoonID[gebruikersBox.SelectedIndex]);
                UpdateUI();
            }
            catch(Exception except)
            {
                System.Windows.Forms.MessageBox.Show(except + "");
                UpdateUI(); //fix de ui omdat de lijst van indexen gebroken is.
            }
        }
    }
}
