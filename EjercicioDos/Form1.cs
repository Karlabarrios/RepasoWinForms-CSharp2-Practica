using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDos
{
    public partial class frmUno : Form
    {
        public frmUno()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtBxApellido.Text == "")
                txtBxApellido.BackColor = Color.Red;
            else
                txtBxApellido.BackColor = Color.DarkKhaki;
            
            if (txtBoxName.Text == "")
                txtBoxName.BackColor = Color.Red;
            else
                txtBoxName.BackColor = Color.DarkKhaki;

            if (txtBoxHome.Text == "")
                txtBoxHome.BackColor = Color.Red;
            else
                txtBoxHome.BackColor = Color.DarkKhaki;

            if (txtBoxAge.Text == "")
                txtBoxAge.BackColor = Color.Red;
            else
                txtBoxAge.BackColor = Color.DarkKhaki;

            string Apellido;
            string Nombre;
            string Edad;
            string Direccion;

            Apellido = txtBxApellido.Text;
            Nombre = txtBoxName.Text;
            Edad = txtBoxAge.Text;
            Direccion = txtBoxHome.Text;

            txtBoxResultrados.Text = "Apellido y nombre: " + Apellido + " " + Nombre + Environment.NewLine + "Edad: " + Edad + Environment.NewLine + "Dirección: " + Direccion;
        }

        private void txtBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCnacel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblDescripcion_MouseMove(object sender, MouseEventArgs e)
        {
            LblDescripcion.BackColor = Color.Olive;
        }

        private void LblDescripcion_MouseLeave(object sender, EventArgs e)
        {
            LblDescripcion.BackColor = Color.Beige;
        }

        private void lblApellido_MouseMove(object sender, MouseEventArgs e)
        {
            lblApellido.BackColor = Color.Olive;
        }

        private void lblApellido_MouseLeave(object sender, EventArgs e)
        {
            lblApellido.BackColor = Color.Beige;
        }

        private void lblNombre_MouseMove(object sender, MouseEventArgs e)
        {
            lblNombre.BackColor = Color.Olive;
        }

        private void lblNombre_MouseLeave(object sender, EventArgs e)
        {
            lblNombre.BackColor = Color.Beige;
        }

        private void lblEdad_MouseMove(object sender, MouseEventArgs e)
        {
            lblEdad.BackColor = Color.Olive;
        }

        private void lblEdad_MouseLeave(object sender, EventArgs e)
        {
            lblEdad.BackColor = Color.Beige;
        }

        private void lblDirecciion_MouseMove(object sender, MouseEventArgs e)
        {
            lblDirecciion.BackColor = Color.Olive;
        }

        private void lblDirecciion_MouseLeave(object sender, EventArgs e)
        {
            lblDirecciion.BackColor = Color.Beige;
        }

        private void txtBxApellido_MouseMove(object sender, MouseEventArgs e)
        {
            txtBxApellido.Cursor = Cursors.Hand;
        }

        private void txtBxApellido_MouseLeave(object sender, EventArgs e)
        {
            txtBxApellido.Cursor = Cursors.Arrow;
        }

        private void txtBoxName_MouseMove(object sender, MouseEventArgs e)
        {
            txtBoxName.Cursor = Cursors.Hand;
        }

        private void txtBoxName_MouseLeave(object sender, EventArgs e)
        {
            txtBoxName.Cursor = Cursors.Arrow;
        }

        private void txtBoxAge_MouseMove(object sender, MouseEventArgs e)
        {
            txtBoxAge.Cursor = Cursors.Hand;
        }

        private void txtBoxAge_MouseLeave(object sender, EventArgs e)
        {
            txtBoxAge.Cursor = Cursors.Arrow;
        }

        private void txtBoxHome_MouseMove(object sender, MouseEventArgs e)
        {
            txtBoxHome.Cursor = Cursors.Hand;
        }

        private void txtBoxHome_MouseLeave(object sender, EventArgs e)
        {
            txtBoxHome.Cursor = Cursors.Arrow;
        }
    }
}