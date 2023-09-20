
namespace EjercicioDos
{
    partial class frmUno
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDirecciion = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxHome = new System.Windows.Forms.TextBox();
            this.txtBoxResultrados = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCnacel = new System.Windows.Forms.Button();
            this.txtBxApellido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(32, 81);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(55, 19);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.MouseLeave += new System.EventHandler(this.lblApellido_MouseLeave);
            this.lblApellido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblApellido_MouseMove);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(32, 123);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 19);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.MouseLeave += new System.EventHandler(this.lblNombre_MouseLeave);
            this.lblNombre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblNombre_MouseMove);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(32, 167);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 19);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad:";
            this.lblEdad.MouseLeave += new System.EventHandler(this.lblEdad_MouseLeave);
            this.lblEdad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblEdad_MouseMove);
            // 
            // lblDirecciion
            // 
            this.lblDirecciion.AutoSize = true;
            this.lblDirecciion.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirecciion.Location = new System.Drawing.Point(32, 209);
            this.lblDirecciion.Name = "lblDirecciion";
            this.lblDirecciion.Size = new System.Drawing.Size(64, 19);
            this.lblDirecciion.TabIndex = 3;
            this.lblDirecciion.Text = "Dirección:";
            this.lblDirecciion.MouseLeave += new System.EventHandler(this.lblDirecciion_MouseLeave);
            this.lblDirecciion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblDirecciion_MouseMove);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(32, 250);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(77, 19);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxName.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxName.Location = new System.Drawing.Point(100, 120);
            this.txtBoxName.MaxLength = 20;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(312, 20);
            this.txtBoxName.TabIndex = 6;
            this.txtBoxName.MouseLeave += new System.EventHandler(this.txtBoxName_MouseLeave);
            this.txtBoxName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtBoxName_MouseMove);
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAge.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtBoxAge.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxAge.Location = new System.Drawing.Point(100, 164);
            this.txtBoxAge.MaxLength = 3;
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(33, 20);
            this.txtBoxAge.TabIndex = 7;
            this.txtBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAge_KeyPress);
            this.txtBoxAge.MouseLeave += new System.EventHandler(this.txtBoxAge_MouseLeave);
            this.txtBoxAge.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtBoxAge_MouseMove);
            // 
            // txtBoxHome
            // 
            this.txtBoxHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxHome.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtBoxHome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxHome.Location = new System.Drawing.Point(100, 209);
            this.txtBoxHome.MaxLength = 100;
            this.txtBoxHome.Name = "txtBoxHome";
            this.txtBoxHome.Size = new System.Drawing.Size(312, 20);
            this.txtBoxHome.TabIndex = 8;
            this.txtBoxHome.MouseLeave += new System.EventHandler(this.txtBoxHome_MouseLeave);
            this.txtBoxHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtBoxHome_MouseMove);
            // 
            // txtBoxResultrados
            // 
            this.txtBoxResultrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxResultrados.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtBoxResultrados.Enabled = false;
            this.txtBoxResultrados.Location = new System.Drawing.Point(35, 283);
            this.txtBoxResultrados.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxResultrados.Multiline = true;
            this.txtBoxResultrados.Name = "txtBoxResultrados";
            this.txtBoxResultrados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxResultrados.Size = new System.Drawing.Size(377, 107);
            this.txtBoxResultrados.TabIndex = 9;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Poppins Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(31, 35);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(223, 26);
            this.LblDescripcion.TabIndex = 10;
            this.LblDescripcion.Text = "Ingrese aquí lo que se le pide";
            this.LblDescripcion.MouseLeave += new System.EventHandler(this.LblDescripcion_MouseLeave);
            this.LblDescripcion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblDescripcion_MouseMove);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAccept.BackColor = System.Drawing.Color.OldLace;
            this.btnAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Location = new System.Drawing.Point(112, 415);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCnacel
            // 
            this.btnCnacel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCnacel.BackColor = System.Drawing.Color.OldLace;
            this.btnCnacel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btnCnacel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCnacel.Location = new System.Drawing.Point(259, 415);
            this.btnCnacel.Name = "btnCnacel";
            this.btnCnacel.Size = new System.Drawing.Size(75, 23);
            this.btnCnacel.TabIndex = 12;
            this.btnCnacel.Text = "Cancelar";
            this.btnCnacel.UseVisualStyleBackColor = false;
            this.btnCnacel.Click += new System.EventHandler(this.btnCnacel_Click);
            // 
            // txtBxApellido
            // 
            this.txtBxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxApellido.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtBxApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBxApellido.Location = new System.Drawing.Point(100, 79);
            this.txtBxApellido.MaxLength = 20;
            this.txtBxApellido.Name = "txtBxApellido";
            this.txtBxApellido.Size = new System.Drawing.Size(312, 20);
            this.txtBxApellido.TabIndex = 13;
            this.txtBxApellido.MouseLeave += new System.EventHandler(this.txtBxApellido_MouseLeave);
            this.txtBxApellido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtBxApellido_MouseMove);
            // 
            // frmUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(455, 468);
            this.Controls.Add(this.txtBxApellido);
            this.Controls.Add(this.btnCnacel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.txtBoxResultrados);
            this.Controls.Add(this.txtBoxHome);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDirecciion);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(730, 594);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(471, 479);
            this.Name = "frmUno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDirecciion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TextBox txtBoxHome;
        private System.Windows.Forms.TextBox txtBoxResultrados;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCnacel;
        private System.Windows.Forms.TextBox txtBxApellido;
    }
}

