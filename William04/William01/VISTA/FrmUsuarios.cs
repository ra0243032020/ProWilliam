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
            Carga();
            clear();


        }
        void clear() {

            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtPass.Clear();
        
        }
        
        void Carga(){
            clear();
            dtgListaUsuarios.Rows.Clear();
            using (programacionEntities db = new programacionEntities())
            {
                var Lista = db.Userlist.ToList();

                foreach (var iteracion in Lista)
                {
                     dtgListaUsuarios.Rows.Add(iteracion.Id,iteracion.NombreUsuario,iteracion.Apellido,iteracion.Edad,iteracion.Pass);
                }

            }
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
            Carga();
            clear();




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
                    int Eliminar = Convert.ToInt32(txtId.Text);
                    Userlist userlistdddd = db.Userlist.Where(x => x.Id == Eliminar).Select(x => x).FirstOrDefault();                    
                   
                    //userlist = db.Userlist.Find(Eliminar);
                    db.Userlist.Remove(userlistdddd);
                    db.SaveChanges();

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());


            }
            Carga();
            clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                using (programacionEntities db = new programacionEntities())
                {

                    int Update = Convert.ToInt32(txtId.Text);
                    Userlist user = db.Userlist.Where(x => x.Id == 3).Select(x => x).FirstOrDefault();
                    //Userlist userlistdddd = new Userlist();
                    //userlistdddd = db.Userlist.Find(7);
                    string text = txtNombre.Text;
                    user.NombreUsuario = text;
                    user.Apellido = txtApellido.Text;
                    user.Edad = Convert.ToInt32(txtEdad.Text);
                    user.Pass = txtPass.Text;
                    db.SaveChanges();
                }
            } catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
            Carga();
            clear();

        }

        private void dtgListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Apellido = dtgListaUsuarios.CurrentRow.Cells[3].Value.ToString();
            String Edad = dtgListaUsuarios.CurrentRow.Cells[3].Value.ToString();
            String Pass = dtgListaUsuarios.CurrentRow.Cells[4].Value.ToString();



            txtId.Text = Id;
            txtNombre.Text = Nombre;
            txtApellido.Text = Apellido;
            txtEdad.Text = Edad;
            txtPass.Text = Pass;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clear();
        }
    }
}
