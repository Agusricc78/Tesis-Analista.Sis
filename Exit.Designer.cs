namespace ProductosOSC
{
    partial class Exit
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
            this.btnsi = new Guna.UI2.WinForms.Guna2Button();
            this.btnno = new Guna.UI2.WinForms.Guna2Button();
            this.lbldesearsalir = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // btnsi
            // 
            this.btnsi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsi.ForeColor = System.Drawing.Color.White;
            this.btnsi.Location = new System.Drawing.Point(12, 166);
            this.btnsi.Name = "btnsi";
            this.btnsi.Size = new System.Drawing.Size(101, 45);
            this.btnsi.TabIndex = 0;
            this.btnsi.Text = "Si";
            this.btnsi.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnno
            // 
            this.btnno.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnno.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnno.ForeColor = System.Drawing.Color.White;
            this.btnno.Location = new System.Drawing.Point(178, 166);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(101, 45);
            this.btnno.TabIndex = 2;
            this.btnno.Text = "No";
            this.btnno.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // lbldesearsalir
            // 
            this.lbldesearsalir.BackColor = System.Drawing.Color.Transparent;
            this.lbldesearsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesearsalir.Location = new System.Drawing.Point(12, 76);
            this.lbldesearsalir.Name = "lbldesearsalir";
            this.lbldesearsalir.Size = new System.Drawing.Size(393, 33);
            this.lbldesearsalir.TabIndex = 3;
            this.lbldesearsalir.Text = "Desear Salir de la Aplicacion?";
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 318);
            this.Controls.Add(this.lbldesearsalir);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnsi);
            this.Name = "Exit";
            this.Text = "Exit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exit_FormClosed);
            this.Load += new System.EventHandler(this.Exit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnsi;
        private Guna.UI2.WinForms.Guna2Button btnno;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbldesearsalir;
    }
}