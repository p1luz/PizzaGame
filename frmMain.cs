using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaGame
{
    public partial class frmMain : Form
    {
        private int nrPizze;
        private int lastPlayer;
        private int lastEat;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {


        }

        private void cmdEsci_Click(object sender, EventArgs e)
        {

            //Richiesta di uscita
            DialogResult dr = MessageBox.Show("Vuoi uscire dall'applicazione?", "Uscire?", MessageBoxButtons.YesNo);

            if (dr.Equals(DialogResult.Yes))
            {
                this.Close();
                this.Dispose();
            }

        }

        private void cmdPulisciLOG_Click(object sender, EventArgs e)
        {
            lstLOG.Items.Clear();
        }

        private void cmdInizio_Click(object sender, EventArgs e)
        {

            if (txtGiocatore1.Equals(""))
            {
                MessageBox.Show("Inserire il nome del Giocatore 1.", "Avviso", MessageBoxButtons.YesNo);
                txtGiocatore1.Focus();
                return;
            }

            if (txtGiocatore2.Equals(""))
            {
                MessageBox.Show("Inserire il nome del Giocatore 2.", "Avviso", MessageBoxButtons.YesNo);
                txtGiocatore2.Focus();
                return;
            }

            lastPlayer = 2;
            lastEat = 0;

            Random rd = new Random();
            nrPizze = rd.Next(10, 30);

            lstLOG.Items.Add("----------------------------------------");
            lstLOG.Items.Add("Partita Iniziata con " + nrPizze + " pizze!");

            while (nrPizze > 0)
            {

                if (lastPlayer == 2)
                {
                    lastEat = partita(nrPizze, 1, txtGiocatore1.Text);
                    nrPizze -= lastEat;
                    lastPlayer = 1;
                }
                else
                {
                    lastEat = partita(nrPizze, 2, txtGiocatore2.Text);
                    nrPizze -= lastEat;
                    lastPlayer = 2;
                }

            }

            if (lastPlayer == 2)
            {
                lstLOG.Items.Add(txtGiocatore2.Text + " ha mangiato la pizza avvelenata! " + txtGiocatore1.Text + " vince la partita!");
            }
            else
            {
                lstLOG.Items.Add(txtGiocatore1.Text + " ha mangiato la pizza avvelenata! " + txtGiocatore2.Text + " vince la partita!");
            }

        }

        private int partita(int pizze, int giocatore, string nomeGiocatore)
        {

            lstLOG.Items.Add("Turno del giocatore " + giocatore + ": " + nomeGiocatore + ", pizze rimanenti: " + nrPizze);

            frmTurno myf = new frmTurno();

            myf.lastEat = this.lastEat;
            myf.giocatore = giocatore;
            myf.nomeGiocatore = nomeGiocatore;
            myf.nrPizze = this.nrPizze;

            myf.ShowDialog();

            this.lastEat = myf.lastEat;

            myf.Dispose();

            lstLOG.Items.Add(nomeGiocatore + " ha mangiato: " + lastEat + " pizze.");

            return myf.lastEat;

        }
    }
}
