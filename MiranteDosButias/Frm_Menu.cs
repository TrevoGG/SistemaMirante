using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiranteDosButias
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void caféToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cafe frm_Cafe = new Frm_Cafe();
            frm_Cafe.ShowDialog();
        }

        private void portariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Portaria frm_Portaria = new Frm_Portaria();
            frm_Portaria.ShowDialog();
        }

        private void caixaMiranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Caixa frm_Caixa = new Frm_Caixa();
            frm_Caixa.ShowDialog();
        }
    }
}
