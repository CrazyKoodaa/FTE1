using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gondel
{
    public partial class Gondelzähler : Form
    {
        int gaesteZaehler = 0;
        public Gondelzähler()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hinzuzaehlen(object sender, EventArgs e)
        {
            if (gaesteZaehler >= 10)
            {
                DialogResult resVoll;
                if (gaesteZaehler >= 12)
                {       
                    resVoll = System.Windows.Forms.MessageBox.Show($"Es war zu voll", "ABSTURZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    zaehler.Text = "Bye Bye";
                    dazu.Visible = false;
                    weg.Visible = false;
                    exit.Visible = true;

                }
            else
            {
                resVoll = System.Windows.Forms.MessageBox.Show($"Es ist zu voll", "Neeee", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
                if (resVoll == DialogResult.No)
                {
                    gaesteZaehler++;
                    updateTextbox();
                }
            } 
            
            else
            {
                gaesteZaehler++;
                updateTextbox();
            }
        }

        private void wegnehmen(object sender, EventArgs e)
        {
            if (gaesteZaehler > 0) { gaesteZaehler--; }
            else { gaesteZaehler = 0; System.Windows.Forms.MessageBox.Show($"Da laufen echt mehr Gäste raus als Gäste drin sind?\nOder war da jemand schwanger?", "Ääähhhhmmm", MessageBoxButtons.YesNo, MessageBoxIcon.Question); }
            updateTextbox();
        }

        private void updateTextbox()
        {
            zaehler.Text = gaesteZaehler.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
