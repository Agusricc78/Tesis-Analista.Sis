namespace ProductosOSC
{
    partial class GestionPerfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboxUsuario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblbuscaruser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboxPerfiles = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblperfiles = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAsignarPerfil = new Guna.UI2.WinForms.Guna2Button();
            this.btnmenu = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // cboxUsuario
            // 
            this.cboxUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cboxUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUsuario.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboxUsuario.ItemHeight = 30;
            this.cboxUsuario.Location = new System.Drawing.Point(21, 64);
            this.cboxUsuario.Name = "cboxUsuario";
            this.cboxUsuario.Size = new System.Drawing.Size(185, 36);
            this.cboxUsuario.TabIndex = 0;
            this.cboxUsuario.SelectedIndexChanged += new System.EventHandler(this.cboxUsuario_SelectedIndexChanged);
            // 
            // lblbuscaruser
            // 
            this.lblbuscaruser.BackColor = System.Drawing.Color.Transparent;
            this.lblbuscaruser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscaruser.Location = new System.Drawing.Point(21, 31);
            this.lblbuscaruser.Name = "lblbuscaruser";
            this.lblbuscaruser.Size = new System.Drawing.Size(150, 27);
            this.lblbuscaruser.TabIndex = 1;
            this.lblbuscaruser.Text = "Buscar Usuario";
            // 
            // cboxPerfiles
            // 
            this.cboxPerfiles.BackColor = System.Drawing.Color.Transparent;
            this.cboxPerfiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPerfiles.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxPerfiles.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxPerfiles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxPerfiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboxPerfiles.ItemHeight = 30;
            this.cboxPerfiles.Location = new System.Drawing.Point(276, 64);
            this.cboxPerfiles.Name = "cboxPerfiles";
            this.cboxPerfiles.Size = new System.Drawing.Size(233, 36);
            this.cboxPerfiles.TabIndex = 2;
            // 
            // lblperfiles
            // 
            this.lblperfiles.BackColor = System.Drawing.Color.Transparent;
            this.lblperfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperfiles.Location = new System.Drawing.Point(276, 31);
            this.lblperfiles.Name = "lblperfiles";
            this.lblperfiles.Size = new System.Drawing.Size(75, 27);
            this.lblperfiles.TabIndex = 3;
            this.lblperfiles.Text = "Perfiles";
            // 
            // btnAsignarPerfil
            // 
            this.btnAsignarPerfil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAsignarPerfil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAsignarPerfil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAsignarPerfil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAsignarPerfil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAsignarPerfil.ForeColor = System.Drawing.Color.White;
            this.btnAsignarPerfil.Location = new System.Drawing.Point(21, 179);
            this.btnAsignarPerfil.Name = "btnAsignarPerfil";
            this.btnAsignarPerfil.Size = new System.Drawing.Size(204, 47);
            this.btnAsignarPerfil.TabIndex = 5;
            this.btnAsignarPerfil.Text = "Asignar Perfil";
            this.btnAsignarPerfil.Click += new System.EventHandler(this.btnAsignarPerfil_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnmenu.ForeColor = System.Drawing.Color.White;
            this.btnmenu.Location = new System.Drawing.Point(276, 179);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(204, 47);
            this.btnmenu.TabIndex = 6;
            this.btnmenu.Text = "Menu Principal";
            this.btnmenu.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // GestionPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 521);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btnAsignarPerfil);
            this.Controls.Add(this.lblperfiles);
            this.Controls.Add(this.cboxPerfiles);
            this.Controls.Add(this.lblbuscaruser);
            this.Controls.Add(this.cboxUsuario);
            this.Name = "GestionPerfil";
            this.Text = "GestionPerfil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionPerfil_FormClosed);
            this.Load += new System.EventHandler(this.GestionPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cboxUsuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblbuscaruser;
        private Guna.UI2.WinForms.Guna2ComboBox cboxPerfiles;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblperfiles;
        private Guna.UI2.WinForms.Guna2Button btnAsignarPerfil;
        private Guna.UI2.WinForms.Guna2Button btnmenu;
    }
}