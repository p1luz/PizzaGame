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
        //Quantità di pizze iniziali/rimaste
        private int nrPizze;

        //Ultimo giocatore attivo
        private int lastPlayer;
        
        //Ultima scelta effettuata (1, 2, o 3)
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
            //Svuoto il LOG applicativo
            lstLOG.Items.Clear();
        }

        private void cmdInizio_Click(object sender, EventArgs e)
        {

            //controllo l'inserimento dei nomi dei Giocatori
            if (txtGiocatore1.Text.Equals(""))
            {
                MessageBox.Show("Inserire il nome del Giocatore 1.", "Avviso");
                txtGiocatore1.Focus();
                return;
            }

            if (txtGiocatore2.Text.Equals(""))
            {
                MessageBox.Show("Inserire il nome del Giocatore 2.", "Avviso");
                txtGiocatore2.Focus();
                return;
            }

            //Inizializzo le variabili di gioco
            lastPlayer = 2;
            lastEat = 0;

            Random rd = new Random();
            nrPizze = rd.Next(10, 30);

            lstLOG.Items.Add("----------------------------------------");
            lstLOG.Items.Add("Partita Iniziata con " + nrPizze + " pizze!");

            //Rimango nel ciclo, quindi in gioco, finchè ho almeno una pizza
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

            //Una volta terminate le pizze controllo chi era il giocatore attivo per decretare il vincitore
            if (lastPlayer == 2)
            {
                MessageBox.Show(txtGiocatore2.Text + " ha mangiato la pizza avvelenata! " + txtGiocatore1.Text + " vince la partita!", "Fine!");
                lstLOG.Items.Add(txtGiocatore2.Text + " ha mangiato la pizza avvelenata! " + txtGiocatore1.Text + " vince la partita!");
            }
            else
            {
                MessageBox.Show(txtGiocatore1.Text + " ha mangiato la pizza avvelenata! " + txtGiocatore2.Text + " vince la partita!", "Fine!");
                lstLOG.Items.Add(txtGiocatore1.Text + " ha mangiato la pizza avvelenata! " + txtGiocatore2.Text + " vince la partita!");
            }

        }

        /// <summary>
        /// Funzione principale dell'applicativo, permette al giocatore attivo di effettuare la propria scelta,
        /// tramite la creazione a runtime di una nuova form.
        /// </summary>
        /// <param name="pizze"> Pizze rimanenti </param>
        /// <param name="giocatore"> Giocatore attivo (1 o 2) </param>
        /// <param name="nomeGiocatore"> Nome giocatore attivo </param>
        /// <returns></returns>
        private int partita(int pizze, int giocatore, string nomeGiocatore)
        {

            lstLOG.Items.Add("Turno del giocatore " + giocatore + ": " + nomeGiocatore + ", pizze rimanenti: " + nrPizze);

            //Dichiaro la form di gioco e inizializzo le variabili
            frmTurno myf = new frmTurno();

            myf.lastEat = this.lastEat;
            myf.giocatore = giocatore;
            myf.nomeGiocatore = nomeGiocatore;
            myf.nrPizze = this.nrPizze;

            myf.ShowDialog();

            //La form di gioco ritorna il valore di pizze selezionato
            this.lastEat = myf.lastEat;

            myf.Dispose();

            lstLOG.Items.Add(nomeGiocatore + " ha mangiato: " + lastEat + " pizze.");

            return myf.lastEat;

        }
    }
}
