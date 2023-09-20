
namespace EjercicioUno
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
            this.btnUno = new System.Windows.Forms.Button();
            this.lblUno = new System.Windows.Forms.Label();
            this.lbDos = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.lblTres = new System.Windows.Forms.Label();
            this.txtBoxDos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUno
            // 
            this.btnUno.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUno.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUno.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.ForeColor = System.Drawing.SystemColors.Info;
            this.btnUno.Location = new System.Drawing.Point(440, 315);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(204, 101);
            this.btnUno.TabIndex = 0;
            this.btnUno.Text = "Clickeame, hermano";
            this.btnUno.UseVisualStyleBackColor = false;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // lblUno
            // 
            this.lblUno.AutoSize = true;
            this.lblUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUno.Font = new System.Drawing.Font("Montserrat Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUno.ForeColor = System.Drawing.SystemColors.Info;
            this.lblUno.Location = new System.Drawing.Point(22, 33);
            this.lblUno.Name = "lblUno";
            this.lblUno.Size = new System.Drawing.Size(241, 30);
            this.lblUno.TabIndex = 1;
            this.lblUno.Text = "Programa nro.2847";
            this.lblUno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUno.MouseLeave += new System.EventHandler(this.lblUno_MouseLeave);
            this.lblUno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblUno_MouseMove);
            // 
            // lbDos
            // 
            this.lbDos.AutoSize = true;
            this.lbDos.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDos.ForeColor = System.Drawing.SystemColors.Info;
            this.lbDos.Location = new System.Drawing.Point(24, 82);
            this.lbDos.Name = "lbDos";
            this.lbDos.Size = new System.Drawing.Size(72, 20);
            this.lbDos.TabIndex = 2;
            this.lbDos.Text = "Apellido:";
            // 
            // txtBox
            // 
            this.txtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBox.Location = new System.Drawing.Point(100, 82);
            this.txtBox.MaxLength = 200;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(544, 20);
            this.txtBox.TabIndex = 3;
            this.txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblTres
            // 
            this.lblTres.AutoSize = true;
            this.lblTres.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTres.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTres.Location = new System.Drawing.Point(24, 121);
            this.lblTres.Name = "lblTres";
            this.lblTres.Size = new System.Drawing.Size(72, 20);
            this.lblTres.TabIndex = 4;
            this.lblTres.Text = "Nombre:";
            // 
            // txtBoxDos
            // 
            this.txtBoxDos.Location = new System.Drawing.Point(100, 121);
            this.txtBoxDos.Multiline = true;
            this.txtBoxDos.Name = "txtBoxDos";
            this.txtBoxDos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxDos.Size = new System.Drawing.Size(544, 70);
            this.txtBoxDos.TabIndex = 5;
            this.txtBoxDos.Leave += new System.EventHandler(this.txtBoxDos_Leave);
            // 
            // frmUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.txtBoxDos);
            this.Controls.Add(this.lblTres);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lbDos);
            this.Controls.Add(this.lblUno);
            this.Controls.Add(this.btnUno);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUno_FormClosed);
            this.Load += new System.EventHandler(this.frmUno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Label lblUno;
        private System.Windows.Forms.Label lbDos;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label lblTres;
        private System.Windows.Forms.TextBox txtBoxDos;
    }
}

