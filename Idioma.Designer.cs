namespace ProductosOSC
{
    partial class Idioma
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
            this.lblIdioma = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnaplicar = new Guna.UI2.WinForms.Guna2Button();
            this.btnmenu = new Guna.UI2.WinForms.Guna2Button();
            this.cboxIdioma = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // lblIdioma
            // 
            this.lblIdioma.BackColor = System.Drawing.Color.Transparent;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(50, 51);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(67, 27);
            this.lblIdioma.TabIndex = 0;
            this.lblIdioma.Text = "Idioma";
            // 
            // btnaplicar
            // 
            this.btnaplicar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaplicar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaplicar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaplicar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaplicar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnaplicar.ForeColor = System.Drawing.Color.White;
            this.btnaplicar.Location = new System.Drawing.Point(50, 154);
            this.btnaplicar.Name = "btnaplicar";
            this.btnaplicar.Size = new System.Drawing.Size(180, 45);
            this.btnaplicar.TabIndex = 1;
            this.btnaplicar.Text = "Aplicar";
            this.btnaplicar.Click += new System.EventHandler(this.materialbutton1_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnmenu.ForeColor = System.Drawing.Color.White;
            this.btnmenu.Location = new System.Drawing.Point(280, 154);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(181, 45);
            this.btnmenu.TabIndex = 2;
            this.btnmenu.Text = "Ir al menu principal";
            this.btnmenu.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // cboxIdioma
            // 
            this.cboxIdioma.BackColor = System.Drawing.Color.Transparent;
            this.cboxIdioma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxIdioma.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxIdioma.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxIdioma.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboxIdioma.ItemHeight = 30;
            this.cboxIdioma.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.cboxIdioma.Location = new System.Drawing.Point(50, 84);
            this.cboxIdioma.Name = "cboxIdioma";
            this.cboxIdioma.Size = new System.Drawing.Size(251, 36);
            this.cboxIdioma.TabIndex = 3;
            this.cboxIdioma.SelectedIndexChanged += new System.EventHandler(this.cboxIdioma_SelectedIndexChanged);
            this.cboxIdioma.SelectedValueChanged += new System.EventHandler(this.cboxIdioma_SelectedValueChanged);
            // 
            // Idioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 393);
            this.Controls.Add(this.cboxIdioma);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btnaplicar);
            this.Controls.Add(this.lblIdioma);
            this.Name = "Idioma";
            this.Text = "Idioma";
            this.Load += new System.EventHandler(this.Idioma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblIdioma;
        private Guna.UI2.WinForms.Guna2Button btnaplicar;
        private Guna.UI2.WinForms.Guna2Button btnmenu;
        private Guna.UI2.WinForms.Guna2ComboBox cboxIdioma;
    }
}