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
    public partial class frmTurno : Form
    {

        //Ultimo valore selezionato
        public int lastEat;

        //Giocatore attivo
        public int giocatore;
        
        //Nome giocatore attivo
        public string nomeGiocatore;

        //Valore pizze rimanenti
        public int nrPizze;

        //Stringa di messaggio, scelta non valida
        private string mex = "Scelta non valida!";

        public frmTurno()
        {
            InitializeComponent();
        }

        private void frmTurno_Load(object sender, EventArgs e)
        {
            txtInfo.Text = @"E' il tuo turno " + nomeGiocatore + "! \n" +
                           "Seleziona quante pizze vuoi mangiare. \n" +
                           "Ricorda che sono ancora disponibili " + nrPizze + " pizze!";

            if (lastEat == 1 & nrPizze == 1)
            {
                cmdMangia.Enabled = false;
                cmdSaltaTurno.Enabled = true;
            }
        }

        private void cmdMangia_Click(object sender, EventArgs e)
        {

            //Controllo la selezione effettuata dall'utente.
            //Se la scelta è uguale all'ultimo valore selezionato non permetto di completare e dò avviso.
            if (radio1pizza.Checked == true)
            {
                if (lastEat == 1)
                {
                    MessageBox.Show(mex, "Avviso");
                    return;
                }

                this.lastEat = 1;
                this.Close();

            }
            if (radio2pizze.Checked == true)
            {
                if (lastEat == 2 | nrPizze < 2)
                {
                    MessageBox.Show(mex, "Avviso");
                    return;
                }

                this.lastEat = 2;
                this.Close();

            }
            if (radio3pizze.Checked == true)
            {
                if (lastEat == 3 | nrPizze < 3)
                {
                    MessageBox.Show(mex, "Avviso");
                    return;
                }

                this.lastEat = 3;
                this.Close();

            }
        }

        private void cmdSaltaTurno_Click(object sender, EventArgs e)
        {

            this.lastEat = 0;
            this.Close();

        }
    }
}
