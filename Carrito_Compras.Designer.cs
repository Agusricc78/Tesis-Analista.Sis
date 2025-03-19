namespace ProductosOSC
{
    partial class Carrito_Compras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvcarrito = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblmostrarcarrito = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblpro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbxClientesNom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblcliente = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblllenarcarito = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvProductos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnfinalizarcarrito = new Guna.UI2.WinForms.Guna2Button();
            this.cbxcategorias = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnagregarproducto = new Guna.UI2.WinForms.Guna2Button();
            this.btnmenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnregistrarcliente = new Guna.UI2.WinForms.Guna2Button();
            this.lblestado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtfecha = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblfecha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btncrearcarrito = new Guna.UI2.WinForms.Guna2Button();
            this.cbxEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblcrearcarrito = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblcantidad = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCarritoId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NumCantidad = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblidcarrito = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbxcarrito = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblmostrarcarritoporid = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnmostrarcarrito = new Guna.UI2.WinForms.Guna2Button();
            this.lbltotcarrito = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalCarrito = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcarrito
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvcarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcarrito.ColumnHeadersHeight = 4;
            this.dgvcarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcarrito.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcarrito.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvcarrito.Location = new System.Drawing.Point(1015, 177);
            this.dgvcarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvcarrito.Name = "dgvcarrito";
            this.dgvcarrito.RowHeadersVisible = false;
            this.dgvcarrito.RowHeadersWidth = 51;
            this.dgvcarrito.RowTemplate.Height = 24;
            this.dgvcarrito.Size = new System.Drawing.Size(572, 315);
            this.dgvcarrito.TabIndex = 1;
            this.dgvcarrito.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvcarrito.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvcarrito.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvcarrito.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvcarrito.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvcarrito.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvcarrito.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvcarrito.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvcarrito.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvcarrito.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcarrito.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvcarrito.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvcarrito.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvcarrito.ThemeStyle.ReadOnly = false;
            this.dgvcarrito.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvcarrito.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvcarrito.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcarrito.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvcarrito.ThemeStyle.RowsStyle.Height = 24;
            this.dgvcarrito.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvcarrito.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvcarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // lblmostrarcarrito
            // 
            this.lblmostrarcarrito.BackColor = System.Drawing.Color.Transparent;
            this.lblmostrarcarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmostrarcarrito.Location = new System.Drawing.Point(1015, 39);
            this.lblmostrarcarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblmostrarcarrito.Name = "lblmostrarcarrito";
            this.lblmostrarcarrito.Size = new System.Drawing.Size(216, 38);
            this.lblmostrarcarrito.TabIndex = 2;
            this.lblmostrarcarrito.Text = "Mostrar Carrito";
            // 
            // lblpro
            // 
            this.lblpro.BackColor = System.Drawing.Color.Transparent;
            this.lblpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpro.Location = new System.Drawing.Point(465, 12);
            this.lblpro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblpro.Name = "lblpro";
            this.lblpro.Size = new System.Drawing.Size(100, 27);
            this.lblpro.TabIndex = 13;
            this.lblpro.Text = "Productos";
            // 
            // cbxClientesNom
            // 
            this.cbxClientesNom.BackColor = System.Drawing.Color.Transparent;
            this.cbxClientesNom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxClientesNom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClientesNom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxClientesNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxClientesNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxClientesNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxClientesNom.ItemHeight = 30;
            this.cbxClientesNom.Location = new System.Drawing.Point(15, 268);
            this.cbxClientesNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxClientesNom.Name = "cbxClientesNom";
            this.cbxClientesNom.Size = new System.Drawing.Size(207, 36);
            this.cbxClientesNom.TabIndex = 22;
            this.cbxClientesNom.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox6_SelectedIndexChanged);
            // 
            // lblcliente
            // 
            this.lblcliente.BackColor = System.Drawing.Color.Transparent;
            this.lblcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcliente.Location = new System.Drawing.Point(15, 235);
            this.lblcliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(189, 27);
            this.lblcliente.TabIndex = 21;
            this.lblcliente.Text = "Cliente por Nombre";
            // 
            // lblllenarcarito
            // 
            this.lblllenarcarito.BackColor = System.Drawing.Color.Transparent;
            this.lblllenarcarito.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblllenarcarito.Location = new System.Drawing.Point(3, 2);
            this.lblllenarcarito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblllenarcarito.Name = "lblllenarcarito";
            this.lblllenarcarito.Size = new System.Drawing.Size(197, 38);
            this.lblllenarcarito.TabIndex = 28;
            this.lblllenarcarito.Text = "Llenar Carrito";
            // 
            // dgvProductos
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductos.ColumnHeadersHeight = 4;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProductos.Location = new System.Drawing.Point(465, 39);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(501, 245);
            this.dgvProductos.TabIndex = 29;
            this.dgvProductos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProductos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProductos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProductos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProductos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProductos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProductos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProductos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProductos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProductos.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvProductos.ThemeStyle.ReadOnly = false;
            this.dgvProductos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProductos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProductos.ThemeStyle.RowsStyle.Height = 24;
            this.dgvProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProductos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnfinalizarcarrito
            // 
            this.btnfinalizarcarrito.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfinalizarcarrito.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfinalizarcarrito.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfinalizarcarrito.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfinalizarcarrito.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnfinalizarcarrito.ForeColor = System.Drawing.Color.White;
            this.btnfinalizarcarrito.Location = new System.Drawing.Point(943, 653);
            this.btnfinalizarcarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfinalizarcarrito.Name = "btnfinalizarcarrito";
            this.btnfinalizarcarrito.Size = new System.Drawing.Size(215, 71);
            this.btnfinalizarcarrito.TabIndex = 31;
            this.btnfinalizarcarrito.Text = "Finalizar Carrito";
            this.btnfinalizarcarrito.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // cbxcategorias
            // 
            this.cbxcategorias.BackColor = System.Drawing.Color.Transparent;
            this.cbxcategorias.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxcategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcategorias.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxcategorias.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxcategorias.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxcategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxcategorias.ItemHeight = 30;
            this.cbxcategorias.Location = new System.Drawing.Point(3, 43);
            this.cbxcategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxcategorias.Name = "cbxcategorias";
            this.cbxcategorias.Size = new System.Drawing.Size(207, 36);
            this.cbxcategorias.TabIndex = 32;
            this.cbxcategorias.SelectedIndexChanged += new System.EventHandler(this.cbxcategorias_SelectedIndexChanged);
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnagregarproducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnagregarproducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnagregarproducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnagregarproducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnagregarproducto.ForeColor = System.Drawing.Color.White;
            this.btnagregarproducto.Location = new System.Drawing.Point(3, 260);
            this.btnagregarproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(165, 43);
            this.btnagregarproducto.TabIndex = 33;
            this.btnagregarproducto.Text = "Agregar Producto";
            this.btnagregarproducto.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnmenu.ForeColor = System.Drawing.Color.White;
            this.btnmenu.Location = new System.Drawing.Point(1407, 653);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(180, 71);
            this.btnmenu.TabIndex = 34;
            this.btnmenu.Text = "Ir al menu principal";
            this.btnmenu.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btnregistrarcliente
            // 
            this.btnregistrarcliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnregistrarcliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnregistrarcliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnregistrarcliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnregistrarcliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnregistrarcliente.ForeColor = System.Drawing.Color.White;
            this.btnregistrarcliente.Location = new System.Drawing.Point(1196, 653);
            this.btnregistrarcliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnregistrarcliente.Name = "btnregistrarcliente";
            this.btnregistrarcliente.Size = new System.Drawing.Size(180, 71);
            this.btnregistrarcliente.TabIndex = 35;
            this.btnregistrarcliente.Text = "Registrar Cliente";
            this.btnregistrarcliente.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // lblestado
            // 
            this.lblestado.BackColor = System.Drawing.Color.Transparent;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(15, 57);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(70, 27);
            this.lblestado.TabIndex = 36;
            this.lblestado.Text = "Estado ";
            // 
            // txtfecha
            // 
            this.txtfecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfecha.DefaultText = "";
            this.txtfecha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfecha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfecha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtfecha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfecha.Location = new System.Drawing.Point(15, 174);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.PasswordChar = '\0';
            this.txtfecha.PlaceholderText = "";
            this.txtfecha.SelectedText = "";
            this.txtfecha.Size = new System.Drawing.Size(229, 42);
            this.txtfecha.TabIndex = 39;
            // 
            // lblfecha
            // 
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(15, 140);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(63, 27);
            this.lblfecha.TabIndex = 38;
            this.lblfecha.Text = "Fecha ";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.guna2Panel1.Controls.Add(this.btncrearcarrito);
            this.guna2Panel1.Controls.Add(this.cbxEstado);
            this.guna2Panel1.Controls.Add(this.lblcrearcarrito);
            this.guna2Panel1.Controls.Add(this.lblestado);
            this.guna2Panel1.Controls.Add(this.lblcliente);
            this.guna2Panel1.Controls.Add(this.cbxClientesNom);
            this.guna2Panel1.Controls.Add(this.txtfecha);
            this.guna2Panel1.Controls.Add(this.lblfecha);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(433, 402);
            this.guna2Panel1.TabIndex = 44;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btncrearcarrito
            // 
            this.btncrearcarrito.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncrearcarrito.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncrearcarrito.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncrearcarrito.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncrearcarrito.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncrearcarrito.ForeColor = System.Drawing.Color.White;
            this.btncrearcarrito.Location = new System.Drawing.Point(15, 332);
            this.btncrearcarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncrearcarrito.Name = "btncrearcarrito";
            this.btncrearcarrito.Size = new System.Drawing.Size(165, 43);
            this.btncrearcarrito.TabIndex = 45;
            this.btncrearcarrito.Text = "Crear Carrito";
            this.btncrearcarrito.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.BackColor = System.Drawing.Color.Transparent;
            this.cbxEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxEstado.ItemHeight = 30;
            this.cbxEstado.Items.AddRange(new object[] {
            "Abierto"});
            this.cbxEstado.Location = new System.Drawing.Point(8, 89);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(207, 36);
            this.cbxEstado.TabIndex = 45;
            // 
            // lblcrearcarrito
            // 
            this.lblcrearcarrito.BackColor = System.Drawing.Color.Transparent;
            this.lblcrearcarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrearcarrito.Location = new System.Drawing.Point(8, 9);
            this.lblcrearcarrito.Name = "lblcrearcarrito";
            this.lblcrearcarrito.Size = new System.Drawing.Size(128, 27);
            this.lblcrearcarrito.TabIndex = 44;
            this.lblcrearcarrito.Text = "Crear Carrito";
            // 
            // lblcantidad
            // 
            this.lblcantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(3, 86);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(90, 27);
            this.lblcantidad.TabIndex = 46;
            this.lblcantidad.Text = "Cantidad";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.guna2Panel2.Controls.Add(this.lblCarritoId);
            this.guna2Panel2.Controls.Add(this.NumCantidad);
            this.guna2Panel2.Controls.Add(this.lblidcarrito);
            this.guna2Panel2.Controls.Add(this.lblllenarcarito);
            this.guna2Panel2.Controls.Add(this.lblcantidad);
            this.guna2Panel2.Controls.Add(this.cbxcategorias);
            this.guna2Panel2.Controls.Add(this.btnagregarproducto);
            this.guna2Panel2.Location = new System.Drawing.Point(465, 301);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(347, 328);
            this.guna2Panel2.TabIndex = 48;
            // 
            // lblCarritoId
            // 
            this.lblCarritoId.BackColor = System.Drawing.Color.Transparent;
            this.lblCarritoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarritoId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCarritoId.Location = new System.Drawing.Point(6, 206);
            this.lblCarritoId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCarritoId.Name = "lblCarritoId";
            this.lblCarritoId.Size = new System.Drawing.Size(3, 2);
            this.lblCarritoId.TabIndex = 49;
            this.lblCarritoId.Text = null;
            // 
            // NumCantidad
            // 
            this.NumCantidad.BackColor = System.Drawing.Color.Transparent;
            this.NumCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumCantidad.Location = new System.Drawing.Point(3, 118);
            this.NumCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumCantidad.Name = "NumCantidad";
            this.NumCantidad.Size = new System.Drawing.Size(142, 48);
            this.NumCantidad.TabIndex = 48;
            // 
            // lblidcarrito
            // 
            this.lblidcarrito.BackColor = System.Drawing.Color.Transparent;
            this.lblidcarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidcarrito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblidcarrito.Location = new System.Drawing.Point(3, 173);
            this.lblidcarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblidcarrito.Name = "lblidcarrito";
            this.lblidcarrito.Size = new System.Drawing.Size(87, 27);
            this.lblidcarrito.TabIndex = 46;
            this.lblidcarrito.Text = "Id carrito";
            this.lblidcarrito.Click += new System.EventHandler(this.guna2HtmlLabel5_Click);
            // 
            // cbxcarrito
            // 
            this.cbxcarrito.BackColor = System.Drawing.Color.Transparent;
            this.cbxcarrito.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxcarrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcarrito.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxcarrito.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxcarrito.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxcarrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxcarrito.ItemHeight = 30;
            this.cbxcarrito.Location = new System.Drawing.Point(1015, 132);
            this.cbxcarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxcarrito.Name = "cbxcarrito";
            this.cbxcarrito.Size = new System.Drawing.Size(207, 36);
            this.cbxcarrito.TabIndex = 50;
            // 
            // lblmostrarcarritoporid
            // 
            this.lblmostrarcarritoporid.BackColor = System.Drawing.Color.Transparent;
            this.lblmostrarcarritoporid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmostrarcarritoporid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmostrarcarritoporid.Location = new System.Drawing.Point(1015, 101);
            this.lblmostrarcarritoporid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblmostrarcarritoporid.Name = "lblmostrarcarritoporid";
            this.lblmostrarcarritoporid.Size = new System.Drawing.Size(203, 27);
            this.lblmostrarcarritoporid.TabIndex = 49;
            this.lblmostrarcarritoporid.Text = "Mostrar carrito por Id";
            // 
            // btnmostrarcarrito
            // 
            this.btnmostrarcarrito.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmostrarcarrito.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmostrarcarrito.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmostrarcarrito.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmostrarcarrito.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnmostrarcarrito.ForeColor = System.Drawing.Color.White;
            this.btnmostrarcarrito.Location = new System.Drawing.Point(1253, 115);
            this.btnmostrarcarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmostrarcarrito.Name = "btnmostrarcarrito";
            this.btnmostrarcarrito.Size = new System.Drawing.Size(215, 53);
            this.btnmostrarcarrito.TabIndex = 51;
            this.btnmostrarcarrito.Text = "Mostrar Carrito";
            this.btnmostrarcarrito.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lbltotcarrito
            // 
            this.lbltotcarrito.BackColor = System.Drawing.Color.Transparent;
            this.lbltotcarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotcarrito.Location = new System.Drawing.Point(1016, 525);
            this.lbltotcarrito.Name = "lbltotcarrito";
            this.lbltotcarrito.Size = new System.Drawing.Size(123, 27);
            this.lbltotcarrito.TabIndex = 52;
            this.lbltotcarrito.Text = "Total Carrito ";
            // 
            // lblTotalCarrito
            // 
            this.lblTotalCarrito.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCarrito.Location = new System.Drawing.Point(1253, 525);
            this.lblTotalCarrito.Name = "lblTotalCarrito";
            this.lblTotalCarrito.Size = new System.Drawing.Size(3, 2);
            this.lblTotalCarrito.TabIndex = 53;
            this.lblTotalCarrito.Text = null;
            // 
            // Carrito_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1772, 880);
            this.Controls.Add(this.lblTotalCarrito);
            this.Controls.Add(this.lbltotcarrito);
            this.Controls.Add(this.btnmostrarcarrito);
            this.Controls.Add(this.cbxcarrito);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.lblmostrarcarritoporid);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnregistrarcliente);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btnfinalizarcarrito);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.lblpro);
            this.Controls.Add(this.lblmostrarcarrito);
            this.Controls.Add(this.dgvcarrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Carrito_Compras";
            this.Text = "Carrito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Carrito_Compras_FormClosed);
            this.Load += new System.EventHandler(this.Carrito_Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvcarrito;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblmostrarcarrito;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblpro;
        private Guna.UI2.WinForms.Guna2ComboBox cbxClientesNom;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblcliente;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblllenarcarito;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProductos;
        private Guna.UI2.WinForms.Guna2Button btnfinalizarcarrito;
        private Guna.UI2.WinForms.Guna2ComboBox cbxcategorias;
        private Guna.UI2.WinForms.Guna2Button btnagregarproducto;
        private Guna.UI2.WinForms.Guna2Button btnmenu;
        private Guna.UI2.WinForms.Guna2Button btnregistrarcliente;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblestado;
        private Guna.UI2.WinForms.Guna2TextBox txtfecha;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblfecha;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxEstado;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblcrearcarrito;
        private Guna.UI2.WinForms.Guna2Button btncrearcarrito;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblcantidad;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblidcarrito;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumCantidad;
        private Guna.UI2.WinForms.Guna2ComboBox cbxcarrito;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblmostrarcarritoporid;
        private Guna.UI2.WinForms.Guna2Button btnmostrarcarrito;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCarritoId;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbltotcarrito;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalCarrito;
    }
}