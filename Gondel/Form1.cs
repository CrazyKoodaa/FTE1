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
            gaesteZaehler++;
            updateTextbox();
        }

        private void wegnehmen(object sender, EventArgs e)
        {
            if (gaesteZaehler > 0) { gaesteZaehler--; }
            else { gaesteZaehler = 0; System.Windows.Forms.MessageBox.Show($"Da laufen echt mehr Gäste raus als Gäste drin sind?\nOder war da jemand schwanger?", "Ääähhhhmmm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); }
            updateTextbox();
        }

        private void updateTextbox()
        {
            zaehler.Text = gaesteZaehler.ToString();
        }
    }
}
