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

        public int lastEat;
        public int giocatore;
        public string nomeGiocatore;
        public int nrPizze;

        public frmTurno()
        {
            InitializeComponent();
        }

        private void frmTurno_Load(object sender, EventArgs e)
        {
            txtInfo.Text = @"E' il tuo turno " + nomeGiocatore + "! \n" +
                           "Seleziona quante pizze vuoi mangiare. \n" +
                           "Ricorda che sono ancora disponibili " + nrPizze + " pizze!";
        }

        private void cmdMangia_Click(object sender, EventArgs e)
        {

            if (radio1pizza.Checked == true)
            {
                if (lastEat == 1)
                {
                    MessageBox.Show("Scelta non valida!", "Avviso");
                    return;
                }

                this.lastEat = 1;
                this.Close();

            }
            if (radio2pizze.Checked == true)
            {
                if (lastEat == 2)
                {
                    MessageBox.Show("Scelta non valida!", "Avviso");
                    return;
                }

                this.lastEat = 2;
                this.Close();

            }
            if (radio3pizze.Checked == true)
            {
                if (lastEat == 3)
                {
                    MessageBox.Show("Scelta non valida!", "Avviso");
                    return;
                }

                this.lastEat = 3;
                this.Close();

            }
        }
    }
}
