namespace GUI_Gokkantoor
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.naam = new System.Windows.Forms.TextBox();
            this.achternaam = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.gsm = new System.Windows.Forms.TextBox();
            this.balans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // naam
            // 
            this.naam.Location = new System.Drawing.Point(281, 92);
            this.naam.Name = "naam";
            this.naam.Size = new System.Drawing.Size(100, 20);
            this.naam.TabIndex = 0;
            // 
            // achternaam
            // 
            this.achternaam.Location = new System.Drawing.Point(281, 118);
            this.achternaam.Name = "achternaam";
            this.achternaam.Size = new System.Drawing.Size(100, 20);
            this.achternaam.TabIndex = 1;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(281, 145);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(100, 20);
            this.adres.TabIndex = 2;
            // 
            // gsm
            // 
            this.gsm.Location = new System.Drawing.Point(281, 170);
            this.gsm.Name = "gsm";
            this.gsm.Size = new System.Drawing.Size(100, 20);
            this.gsm.TabIndex = 3;
            // 
            // balans
            // 
            this.balans.Location = new System.Drawing.Point(281, 196);
            this.balans.Name = "balans";
            this.balans.Size = new System.Drawing.Size(100, 20);
            this.balans.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Achternaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "GSM";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Balans";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.balans);
            this.Controls.Add(this.gsm);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.achternaam);
            this.Controls.Add(this.naam);
            this.Name = "User";
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox naam;
        private System.Windows.Forms.TextBox achternaam;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox gsm;
        private System.Windows.Forms.TextBox balans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}