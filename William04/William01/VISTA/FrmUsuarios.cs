using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using William01.MODEL;

namespace William01.VISTA
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try { 


            using (programacionEntities db = new programacionEntities()) {

                Userlist userlist = new Userlist();

                userlist.NombreUsuario = txtNombre.Text;
                userlist.Apellido = txtApellido.Text;
                userlist.Edad = Convert.ToInt32(txtEdad.Text);
                userlist.Pass = txtPass.Text;
                db.Userlist.Add(userlist);
                db.SaveChanges();

                    MessageBox.Show("save");


            }
        } catch (Exception EX) {
                MessageBox.Show(EX.ToString());

        
        }





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                using (programacionEntities db = new programacionEntities())
                {
                    
                    Userlist userlist = new Userlist();
                    int Eliminar = Convert.ToInt32(txtSin.Text);
                    userlist = db.Userlist.Find(Eliminar);
                    db.Userlist.Remove(userlist);
                    db.SaveChanges();

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());


            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
