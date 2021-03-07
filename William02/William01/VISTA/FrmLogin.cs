using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using William01.DOMINIO;
using William01.NEGOCIO;
using William01.VISTA;

namespace William01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            
            log.Usuario = txtUser.Text;
            log.Password = txtPass.Text;

            ClsLogin clsL = new ClsLogin();

            int variabledeevaluacion = clsL.acceso(log);

            if (variabledeevaluacion == 1) {

                MessageBox.Show("welcome");
                Frm1 frm = new Frm1();
                frm.Show();
                this.Hide();


            }
            else
                MessageBox.Show("False");
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCnacelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
