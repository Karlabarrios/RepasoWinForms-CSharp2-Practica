using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioUno
{
    public partial class frmUno : Form
    {
        public frmUno()
        {
            InitializeComponent();
        }

        private void frmUno_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void frmUno_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau... Chau...");
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            MessageBox.Show("Se disparo el evento click", "Atención");
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón izquierdo, comunista!!!");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el botón derecho, fascista!!!");
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón de en medio wtf");
            this.BackColor = Color.RosyBrown;
            if (txtBox.Text == "")
                txtBox.BackColor = Color.Red;
            else
                txtBox.BackColor = Color.White;
        }

        private void lblUno_MouseMove(object sender, MouseEventArgs e)
        {
            lblUno.BackColor = Color.Cyan;
            lblUno.Cursor = Cursors.Hand;
        }

        private void lblUno_MouseLeave(object sender, EventArgs e)
        {
            lblUno.BackColor = Color.RosyBrown;
            lblUno.Cursor = Cursors.Arrow;
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtBoxDos_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("La caja de texto tiene " + txtBoxDos.Text.Length + " caractéres. " , "Aviso");
        }
    }
}
