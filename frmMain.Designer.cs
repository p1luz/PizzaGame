
namespace PizzaGame
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmdInizio = new System.Windows.Forms.Button();
            this.lblGiocatore1 = new System.Windows.Forms.Label();
            this.txtGiocatore1 = new System.Windows.Forms.TextBox();
            this.txtGiocatore2 = new System.Windows.Forms.TextBox();
            this.lblGiocatore2 = new System.Windows.Forms.Label();
            this.cmdPulisciLOG = new System.Windows.Forms.Button();
            this.cmdEsci = new System.Windows.Forms.Button();
            this.lstLOG = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdInizio
            // 
            this.cmdInizio.Location = new System.Drawing.Point(366, 48);
            this.cmdInizio.Name = "cmdInizio";
            this.cmdInizio.Size = new System.Drawing.Size(84, 70);
            this.cmdInizio.TabIndex = 2;
            this.cmdInizio.Text = "Inizia!";
            this.cmdInizio.UseVisualStyleBackColor = true;
            this.cmdInizio.Click += new System.EventHandler(this.cmdInizio_Click);
            // 
            // lblGiocatore1
            // 
            this.lblGiocatore1.AutoSize = true;
            this.lblGiocatore1.Location = new System.Drawing.Point(42, 51);
            this.lblGiocatore1.Name = "lblGiocatore1";
            this.lblGiocatore1.Size = new System.Drawing.Size(86, 17);
            this.lblGiocatore1.TabIndex = 1;
            this.lblGiocatore1.Text = "Giocatore 1:";
            // 
            // txtGiocatore1
            // 
            this.txtGiocatore1.Location = new System.Drawing.Point(154, 48);
            this.txtGiocatore1.Name = "txtGiocatore1";
            this.txtGiocatore1.Size = new System.Drawing.Size(184, 22);
            this.txtGiocatore1.TabIndex = 0;
            this.txtGiocatore1.Text = "Mario";
            // 
            // txtGiocatore2
            // 
            this.txtGiocatore2.Location = new System.Drawing.Point(154, 98);
            this.txtGiocatore2.Name = "txtGiocatore2";
            this.txtGiocatore2.Size = new System.Drawing.Size(184, 22);
            this.txtGiocatore2.TabIndex = 1;
            this.txtGiocatore2.Text = "Luigi";
            // 
            // lblGiocatore2
            // 
            this.lblGiocatore2.AutoSize = true;
            this.lblGiocatore2.Location = new System.Drawing.Point(42, 101);
            this.lblGiocatore2.Name = "lblGiocatore2";
            this.lblGiocatore2.Size = new System.Drawing.Size(86, 17);
            this.lblGiocatore2.TabIndex = 3;
            this.lblGiocatore2.Text = "Giocatore 2:";
            // 
            // cmdPulisciLOG
            // 
            this.cmdPulisciLOG.Location = new System.Drawing.Point(743, 143);
            this.cmdPulisciLOG.Name = "cmdPulisciLOG";
            this.cmdPulisciLOG.Size = new System.Drawing.Size(84, 70);
            this.cmdPulisciLOG.TabIndex = 3;
            this.cmdPulisciLOG.Text = "Pulisci";
            this.cmdPulisciLOG.UseVisualStyleBackColor = true;
            this.cmdPulisciLOG.Click += new System.EventHandler(this.cmdPulisciLOG_Click);
            // 
            // cmdEsci
            // 
            this.cmdEsci.Location = new System.Drawing.Point(743, 24);
            this.cmdEsci.Name = "cmdEsci";
            this.cmdEsci.Size = new System.Drawing.Size(84, 70);
            this.cmdEsci.TabIndex = 4;
            this.cmdEsci.Text = "Esci";
            this.cmdEsci.UseVisualStyleBackColor = true;
            this.cmdEsci.Click += new System.EventHandler(this.cmdEsci_Click);
            // 
            // lstLOG
            // 
            this.lstLOG.FormattingEnabled = true;
            this.lstLOG.ItemHeight = 16;
            this.lstLOG.Location = new System.Drawing.Point(21, 228);
            this.lstLOG.Name = "lstLOG";
            this.lstLOG.Size = new System.Drawing.Size(806, 244);
            this.lstLOG.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 484);
            this.Controls.Add(this.lstLOG);
            this.Controls.Add(this.cmdEsci);
            this.Controls.Add(this.cmdPulisciLOG);
            this.Controls.Add(this.txtGiocatore2);
            this.Controls.Add(this.lblGiocatore2);
            this.Controls.Add(this.txtGiocatore1);
            this.Controls.Add(this.lblGiocatore1);
            this.Controls.Add(this.cmdInizio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Game";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdInizio;
        private System.Windows.Forms.Label lblGiocatore1;
        private System.Windows.Forms.TextBox txtGiocatore1;
        private System.Windows.Forms.TextBox txtGiocatore2;
        private System.Windows.Forms.Label lblGiocatore2;
        private System.Windows.Forms.Button cmdPulisciLOG;
        private System.Windows.Forms.Button cmdEsci;
        private System.Windows.Forms.ListBox lstLOG;
    }
}

