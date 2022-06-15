
namespace Vista
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgLibreria = new System.Windows.Forms.DataGridView();
            this.cboOrdenar = new System.Windows.Forms.ComboBox();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.btnListadoPedido = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.mnuArchivos = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemGuardar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgLibreria)).BeginInit();
            this.mnuArchivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgLibreria
            // 
            this.dgLibreria.AllowUserToAddRows = false;
            this.dgLibreria.AllowUserToDeleteRows = false;
            this.dgLibreria.AllowUserToResizeColumns = false;
            this.dgLibreria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLibreria.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgLibreria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgLibreria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLibreria.Location = new System.Drawing.Point(12, 44);
            this.dgLibreria.Name = "dgLibreria";
            this.dgLibreria.ReadOnly = true;
            this.dgLibreria.RowHeadersVisible = false;
            this.dgLibreria.RowTemplate.Height = 25;
            this.dgLibreria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLibreria.ShowCellToolTips = false;
            this.dgLibreria.Size = new System.Drawing.Size(777, 488);
            this.dgLibreria.TabIndex = 0;
            this.dgLibreria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLibreria_CellDoubleClick);
            // 
            // cboOrdenar
            // 
            this.cboOrdenar.BackColor = System.Drawing.Color.GhostWhite;
            this.cboOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboOrdenar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboOrdenar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboOrdenar.FormattingEnabled = true;
            this.cboOrdenar.Location = new System.Drawing.Point(814, 64);
            this.cboOrdenar.Name = "cboOrdenar";
            this.cboOrdenar.Size = new System.Drawing.Size(121, 23);
            this.cboOrdenar.TabIndex = 1;
            this.cboOrdenar.SelectedValueChanged += new System.EventHandler(this.cboOrdenar_SelectedValueChanged);
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrdenar.Location = new System.Drawing.Point(815, 44);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(75, 15);
            this.lblOrdenar.TabIndex = 6;
            this.lblOrdenar.Text = "Ordenar por";
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAgregarLibro.CausesValidation = false;
            this.btnAgregarLibro.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAgregarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarLibro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarLibro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarLibro.Location = new System.Drawing.Point(575, 549);
            this.btnAgregarLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(214, 41);
            this.btnAgregarLibro.TabIndex = 6;
            this.btnAgregarLibro.Text = "AGREGAR LIBRO";
            this.btnAgregarLibro.UseVisualStyleBackColor = false;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAgregarPedido.CausesValidation = false;
            this.btnAgregarPedido.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAgregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarPedido.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarPedido.Location = new System.Drawing.Point(814, 273);
            this.btnAgregarPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(194, 115);
            this.btnAgregarPedido.TabIndex = 2;
            this.btnAgregarPedido.Text = "AGREGAR PEDIDO";
            this.btnAgregarPedido.UseVisualStyleBackColor = false;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // btnListadoPedido
            // 
            this.btnListadoPedido.BackColor = System.Drawing.Color.GhostWhite;
            this.btnListadoPedido.CausesValidation = false;
            this.btnListadoPedido.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnListadoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListadoPedido.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListadoPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnListadoPedido.Location = new System.Drawing.Point(814, 418);
            this.btnListadoPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListadoPedido.Name = "btnListadoPedido";
            this.btnListadoPedido.Size = new System.Drawing.Size(194, 114);
            this.btnListadoPedido.TabIndex = 3;
            this.btnListadoPedido.Text = "LISTADO PEDIDOS";
            this.btnListadoPedido.UseVisualStyleBackColor = false;
            this.btnListadoPedido.Click += new System.EventHandler(this.btnListadoPedido_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSalir.CausesValidation = false;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(12, 549);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(208, 41);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBorrar.CausesValidation = false;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBorrar.Location = new System.Drawing.Point(289, 549);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(216, 41);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "BORRAR LIBRO";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // mnuArchivos
            // 
            this.mnuArchivos.BackColor = System.Drawing.Color.GhostWhite;
            this.mnuArchivos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuArchivos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.mnuArchivos.Location = new System.Drawing.Point(0, 0);
            this.mnuArchivos.Name = "mnuArchivos";
            this.mnuArchivos.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuArchivos.Size = new System.Drawing.Size(1020, 24);
            this.mnuArchivos.TabIndex = 9;
            this.mnuArchivos.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAbrir,
            this.mnuItemGuardar});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mnuItemAbrir
            // 
            this.mnuItemAbrir.Name = "mnuItemAbrir";
            this.mnuItemAbrir.Size = new System.Drawing.Size(119, 22);
            this.mnuItemAbrir.Text = "Abrir";
            this.mnuItemAbrir.Click += new System.EventHandler(this.mnuItemAbrir_Click);
            // 
            // mnuItemGuardar
            // 
            this.mnuItemGuardar.Name = "mnuItemGuardar";
            this.mnuItemGuardar.Size = new System.Drawing.Size(119, 22);
            this.mnuItemGuardar.Text = "Guardar";
            this.mnuItemGuardar.Click += new System.EventHandler(this.mnuItemGuardar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1020, 601);
            this.Controls.Add(this.mnuArchivos);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListadoPedido);
            this.Controls.Add(this.btnAgregarPedido);
            this.Controls.Add(this.btnAgregarLibro);
            this.Controls.Add(this.cboOrdenar);
            this.Controls.Add(this.lblOrdenar);
            this.Controls.Add(this.dgLibreria);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libreria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgLibreria)).EndInit();
            this.mnuArchivos.ResumeLayout(false);
            this.mnuArchivos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLibreria;
        private System.Windows.Forms.ComboBox cboOrdenar;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.Button btnListadoPedido;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.MenuStrip mnuArchivos;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAbrir;
        private System.Windows.Forms.ToolStripMenuItem mnuItemGuardar;
    }
}

