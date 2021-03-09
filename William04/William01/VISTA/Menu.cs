using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace William01.VISTA
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }
        public String usuarioEstado;
        private void Menu_Load(object sender, EventArgs e)
        {
            label1.Text = usuarioEstado;
        }

        private void clicParaMasInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frm = new FrmAcercaDe();
            frm.MdiParent = this;
            frm.Show();
          
        }

        private void clickParaMasInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaVisualDeUsuario frm = new FrmListaVisualDeUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sumasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmop = new FrmOperaciones();
            frmop.MdiParent = this;
            frmop.BtnResta.Enabled = false;


            frmop.Show();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmop = new FrmOperaciones();
            frmop.MdiParent = this;
            frmop.BtnSuma.Enabled = false;


            frmop.Show();
        }
    }
    }

