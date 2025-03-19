namespace ProductosOSC
{
    partial class Productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.lblproductos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnmenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnagregarproducto = new Guna.UI2.WinForms.Guna2Button();
            this.txtmarca = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMarca = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblagregar = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblmodelo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtmodelo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbltamaño = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txttamanio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbltipo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvpro = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbllistadeproductos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblprecio = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtprecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnactualizarlista = new Guna.UI2.WinForms.Guna2Button();
            this.cbxtipo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbleliminarproducto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbxEliminarPro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblstock = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtstock = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblproductos
            // 
            this.lblproductos.BackColor = System.Drawing.Color.Transparent;
            this.lblproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblproductos.Location = new System.Drawing.Point(12, 12);
            this.lblproductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblproductos.Name = "lblproductos";
            this.lblproductos.Size = new System.Drawing.Size(245, 40);
            this.lblproductos.TabIndex = 0;
            this.lblproductos.Text = "Productos OSC";
            // 
            // btnmenu
            // 
            this.btnmenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmenu.FillColor = System.Drawing.Color.White;
            this.btnmenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnmenu.ForeColor = System.Drawing.Color.Black;
            this.btnmenu.Location = new System.Drawing.Point(397, 765);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(155, 60);
            this.btnmenu.TabIndex = 11;
            this.btnmenu.Text = "Voler al menu principal";
            this.btnmenu.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnagregarproducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnagregarproducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnagregarproducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnagregarproducto.FillColor = System.Drawing.Color.White;
            this.btnagregarproducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnagregarproducto.ForeColor = System.Drawing.Color.Black;
            this.btnagregarproducto.Location = new System.Drawing.Point(3, 765);
            this.btnagregarproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(169, 60);
            this.btnagregarproducto.TabIndex = 12;
            this.btnagregarproducto.Text = "Agregar Producto";
            this.btnagregarproducto.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // txtmarca
            // 
            this.txtmarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmarca.DefaultText = "";
            this.txtmarca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmarca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmarca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmarca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmarca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmarca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmarca.Location = new System.Drawing.Point(12, 218);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.PasswordChar = '\0';
            this.txtmarca.PlaceholderText = "";
            this.txtmarca.SelectedText = "";
            this.txtmarca.Size = new System.Drawing.Size(181, 42);
            this.txtmarca.TabIndex = 13;
            // 
            // lblMarca
            // 
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMarca.Location = new System.Drawing.Point(12, 185);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(63, 27);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Marca";
            // 
            // lblagregar
            // 
            this.lblagregar.BackColor = System.Drawing.Color.Transparent;
            this.lblagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblagregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblagregar.Location = new System.Drawing.Point(3, 122);
            this.lblagregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblagregar.Name = "lblagregar";
            this.lblagregar.Size = new System.Drawing.Size(275, 40);
            this.lblagregar.TabIndex = 15;
            this.lblagregar.Text = "Agregar Producto";
            // 
            // lblmodelo
            // 
            this.lblmodelo.BackColor = System.Drawing.Color.Transparent;
            this.lblmodelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodelo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblmodelo.Location = new System.Drawing.Point(12, 286);
            this.lblmodelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(74, 27);
            this.lblmodelo.TabIndex = 17;
            this.lblmodelo.Text = "Modelo";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmodelo.DefaultText = "";
            this.txtmodelo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmodelo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmodelo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmodelo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmodelo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmodelo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmodelo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmodelo.Location = new System.Drawing.Point(12, 319);
            this.txtmodelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.PasswordChar = '\0';
            this.txtmodelo.PlaceholderText = "";
            this.txtmodelo.SelectedText = "";
            this.txtmodelo.Size = new System.Drawing.Size(181, 42);
            this.txtmodelo.TabIndex = 16;
            // 
            // lbltamaño
            // 
            this.lbltamaño.BackColor = System.Drawing.Color.Transparent;
            this.lbltamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltamaño.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltamaño.Location = new System.Drawing.Point(12, 386);
            this.lbltamaño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbltamaño.Name = "lbltamaño";
            this.lbltamaño.Size = new System.Drawing.Size(82, 27);
            this.lbltamaño.TabIndex = 19;
            this.lbltamaño.Text = "Tamaño";
            // 
            // txttamanio
            // 
            this.txttamanio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttamanio.DefaultText = "";
            this.txttamanio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttamanio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttamanio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttamanio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttamanio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttamanio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttamanio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttamanio.Location = new System.Drawing.Point(12, 420);
            this.txttamanio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttamanio.Name = "txttamanio";
            this.txttamanio.PasswordChar = '\0';
            this.txttamanio.PlaceholderText = "";
            this.txttamanio.SelectedText = "";
            this.txttamanio.Size = new System.Drawing.Size(181, 42);
            this.txttamanio.TabIndex = 18;
            // 
            // lbltipo
            // 
            this.lbltipo.BackColor = System.Drawing.Color.Transparent;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltipo.Location = new System.Drawing.Point(12, 481);
            this.lbltipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(46, 27);
            this.lbltipo.TabIndex = 21;
            this.lbltipo.Text = "Tipo";
            // 
            // dgvpro
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvpro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvpro.ColumnHeadersHeight = 4;
            this.dgvpro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpro.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvpro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvpro.Location = new System.Drawing.Point(571, 217);
            this.dgvpro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvpro.Name = "dgvpro";
            this.dgvpro.RowHeadersVisible = false;
            this.dgvpro.RowHeadersWidth = 51;
            this.dgvpro.RowTemplate.Height = 24;
            this.dgvpro.Size = new System.Drawing.Size(689, 343);
            this.dgvpro.TabIndex = 22;
            this.dgvpro.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvpro.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvpro.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvpro.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvpro.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvpro.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvpro.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvpro.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvpro.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvpro.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvpro.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvpro.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvpro.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvpro.ThemeStyle.ReadOnly = false;
            this.dgvpro.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvpro.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvpro.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvpro.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvpro.ThemeStyle.RowsStyle.Height = 24;
            this.dgvpro.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvpro.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvpro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpro_CellContentClick);
            // 
            // lbllistadeproductos
            // 
            this.lbllistadeproductos.BackColor = System.Drawing.Color.Transparent;
            this.lbllistadeproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllistadeproductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbllistadeproductos.Location = new System.Drawing.Point(571, 158);
            this.lbllistadeproductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbllistadeproductos.Name = "lbllistadeproductos";
            this.lbllistadeproductos.Size = new System.Drawing.Size(436, 40);
            this.lbllistadeproductos.TabIndex = 23;
            this.lbllistadeproductos.Text = "Lista de Productos Actuales";
            // 
            // lblprecio
            // 
            this.lblprecio.BackColor = System.Drawing.Color.Transparent;
            this.lblprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblprecio.Location = new System.Drawing.Point(12, 582);
            this.lblprecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(64, 27);
            this.lblprecio.TabIndex = 25;
            this.lblprecio.Text = "Precio";
            // 
            // txtprecio
            // 
            this.txtprecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprecio.DefaultText = "";
            this.txtprecio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprecio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprecio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprecio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtprecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprecio.Location = new System.Drawing.Point(12, 617);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.PasswordChar = '\0';
            this.txtprecio.PlaceholderText = "";
            this.txtprecio.SelectedText = "";
            this.txtprecio.Size = new System.Drawing.Size(181, 42);
            this.txtprecio.TabIndex = 24;
            // 
            // btnactualizarlista
            // 
            this.btnactualizarlista.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnactualizarlista.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnactualizarlista.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnactualizarlista.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnactualizarlista.FillColor = System.Drawing.Color.White;
            this.btnactualizarlista.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnactualizarlista.ForeColor = System.Drawing.Color.Black;
            this.btnactualizarlista.Location = new System.Drawing.Point(202, 736);
            this.btnactualizarlista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnactualizarlista.Name = "btnactualizarlista";
            this.btnactualizarlista.Size = new System.Drawing.Size(169, 89);
            this.btnactualizarlista.TabIndex = 26;
            this.btnactualizarlista.Text = "Actualizar Lista de Productos";
            this.btnactualizarlista.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // cbxtipo
            // 
            this.cbxtipo.BackColor = System.Drawing.Color.Transparent;
            this.cbxtipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtipo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxtipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxtipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxtipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxtipo.ItemHeight = 30;
            this.cbxtipo.Items.AddRange(new object[] {
            "Nano Ceramicos",
            "Limpiadores y Desengrasantes",
            "Pulimentos",
            "Fragancias",
            "Lavado"});
            this.cbxtipo.Location = new System.Drawing.Point(12, 524);
            this.cbxtipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxtipo.Name = "cbxtipo";
            this.cbxtipo.Size = new System.Drawing.Size(359, 36);
            this.cbxtipo.TabIndex = 27;
            // 
            // lbleliminarproducto
            // 
            this.lbleliminarproducto.BackColor = System.Drawing.Color.Transparent;
            this.lbleliminarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleliminarproducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbleliminarproducto.Location = new System.Drawing.Point(307, 185);
            this.lbleliminarproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbleliminarproducto.Name = "lbleliminarproducto";
            this.lbleliminarproducto.Size = new System.Drawing.Size(172, 27);
            this.lbleliminarproducto.TabIndex = 29;
            this.lbleliminarproducto.Text = "Eliminar Producto ";
            // 
            // cbxEliminarPro
            // 
            this.cbxEliminarPro.BackColor = System.Drawing.Color.Transparent;
            this.cbxEliminarPro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxEliminarPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEliminarPro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxEliminarPro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxEliminarPro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxEliminarPro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxEliminarPro.ItemHeight = 30;
            this.cbxEliminarPro.Items.AddRange(new object[] {
            "Nano Ceramicos",
            "Limpiadores y Desengrasantes",
            "Pulimentos",
            "Fragancias",
            "Lavado"});
            this.cbxEliminarPro.Location = new System.Drawing.Point(268, 217);
            this.cbxEliminarPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEliminarPro.Name = "cbxEliminarPro";
            this.cbxEliminarPro.Size = new System.Drawing.Size(284, 36);
            this.cbxEliminarPro.TabIndex = 30;
            this.cbxEliminarPro.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // lblstock
            // 
            this.lblstock.BackColor = System.Drawing.Color.Transparent;
            this.lblstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblstock.Location = new System.Drawing.Point(12, 669);
            this.lblstock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(58, 27);
            this.lblstock.TabIndex = 32;
            this.lblstock.Text = "Stock";
            // 
            // txtstock
            // 
            this.txtstock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstock.DefaultText = "";
            this.txtstock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtstock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstock.Location = new System.Drawing.Point(12, 702);
            this.txtstock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtstock.Name = "txtstock";
            this.txtstock.PasswordChar = '\0';
            this.txtstock.PlaceholderText = "";
            this.txtstock.SelectedText = "";
            this.txtstock.Size = new System.Drawing.Size(181, 42);
            this.txtstock.TabIndex = 31;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 850);
            this.Controls.Add(this.lblstock);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.cbxEliminarPro);
            this.Controls.Add(this.lbleliminarproducto);
            this.Controls.Add(this.cbxtipo);
            this.Controls.Add(this.btnactualizarlista);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.lbllistadeproductos);
            this.Controls.Add(this.dgvpro);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lbltamaño);
            this.Controls.Add(this.txttamanio);
            this.Controls.Add(this.lblmodelo);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.lblagregar);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.btnagregarproducto);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.lblproductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Productos";
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Productos_FormClosed);
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblproductos;
        private Guna.UI2.WinForms.Guna2Button btnmenu;
        private Guna.UI2.WinForms.Guna2Button btnagregarproducto;
        private Guna.UI2.WinForms.Guna2TextBox txtmarca;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMarca;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblagregar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblmodelo;
        private Guna.UI2.WinForms.Guna2TextBox txtmodelo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbltamaño;
        private Guna.UI2.WinForms.Guna2TextBox txttamanio;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbltipo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvpro;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbllistadeproductos;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblprecio;
        private Guna.UI2.WinForms.Guna2TextBox txtprecio;
        private Guna.UI2.WinForms.Guna2Button btnactualizarlista;
        private Guna.UI2.WinForms.Guna2ComboBox cbxtipo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbleliminarproducto;
        private Guna.UI2.WinForms.Guna2ComboBox cbxEliminarPro;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblstock;
        private Guna.UI2.WinForms.Guna2TextBox txtstock;
    }
}