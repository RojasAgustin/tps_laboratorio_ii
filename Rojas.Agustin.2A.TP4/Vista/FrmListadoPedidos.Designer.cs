
namespace Vista
{
    partial class FrmListadoPedidos
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
            this.dgListado = new System.Windows.Forms.DataGridView();
            this.cboOrdenar = new System.Windows.Forms.ComboBox();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblGananciasTexto = new System.Windows.Forms.Label();
            this.lblGanancias = new System.Windows.Forms.Label();
            this.mnuToolStripArchivos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLeerDB = new System.Windows.Forms.Button();
            this.btnBorrarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.dbStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusDB = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbCodigoDescuento = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).BeginInit();
            this.dbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgListado
            // 
            this.dgListado.AllowUserToAddRows = false;
            this.dgListado.AllowUserToDeleteRows = false;
            this.dgListado.AllowUserToResizeColumns = false;
            this.dgListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListado.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListado.Location = new System.Drawing.Point(-2, 68);
            this.dgListado.MultiSelect = false;
            this.dgListado.Name = "dgListado";
            this.dgListado.ReadOnly = true;
            this.dgListado.RowHeadersVisible = false;
            this.dgListado.RowTemplate.Height = 25;
            this.dgListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListado.ShowCellToolTips = false;
            this.dgListado.Size = new System.Drawing.Size(973, 493);
            this.dgListado.TabIndex = 1;
            this.dgListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListado_CellDoubleClick);
            // 
            // cboOrdenar
            // 
            this.cboOrdenar.BackColor = System.Drawing.Color.GhostWhite;
            this.cboOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboOrdenar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboOrdenar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboOrdenar.FormattingEnabled = true;
            this.cboOrdenar.Location = new System.Drawing.Point(835, 28);
            this.cboOrdenar.Name = "cboOrdenar";
            this.cboOrdenar.Size = new System.Drawing.Size(121, 23);
            this.cboOrdenar.TabIndex = 4;
            this.cboOrdenar.SelectedValueChanged += new System.EventHandler(this.cboOrdenar_SelectedValueChanged);
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrdenar.Location = new System.Drawing.Point(754, 31);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(75, 15);
            this.lblOrdenar.TabIndex = 8;
            this.lblOrdenar.Text = "Ordenar por";
            // 
            // btnAtender
            // 
            this.btnAtender.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAtender.CausesValidation = false;
            this.btnAtender.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtender.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAtender.Location = new System.Drawing.Point(506, 573);
            this.btnAtender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(119, 38);
            this.btnAtender.TabIndex = 6;
            this.btnAtender.Text = "ATENDER";
            this.btnAtender.UseVisualStyleBackColor = false;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.GhostWhite;
            this.btnVolver.CausesValidation = false;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.Location = new System.Drawing.Point(2, 573);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(114, 38);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblGananciasTexto
            // 
            this.lblGananciasTexto.AutoSize = true;
            this.lblGananciasTexto.BackColor = System.Drawing.Color.GhostWhite;
            this.lblGananciasTexto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGananciasTexto.Location = new System.Drawing.Point(723, 581);
            this.lblGananciasTexto.Name = "lblGananciasTexto";
            this.lblGananciasTexto.Size = new System.Drawing.Size(128, 25);
            this.lblGananciasTexto.TabIndex = 4;
            this.lblGananciasTexto.Text = "Ganancias:  $";
            // 
            // lblGanancias
            // 
            this.lblGanancias.AutoSize = true;
            this.lblGanancias.BackColor = System.Drawing.Color.GhostWhite;
            this.lblGanancias.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGanancias.Location = new System.Drawing.Point(846, 581);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(0, 25);
            this.lblGanancias.TabIndex = 9;
            // 
            // mnuToolStripArchivos
            // 
            this.mnuToolStripArchivos.Name = "mnuToolStripArchivos";
            this.mnuToolStripArchivos.Size = new System.Drawing.Size(32, 19);
            // 
            // mnuItemAbrir
            // 
            this.mnuItemAbrir.Name = "mnuItemAbrir";
            this.mnuItemAbrir.Size = new System.Drawing.Size(32, 19);
            // 
            // mnuItemGuardar
            // 
            this.mnuItemGuardar.Name = "mnuItemGuardar";
            this.mnuItemGuardar.Size = new System.Drawing.Size(32, 19);
            // 
            // btnLeerDB
            // 
            this.btnLeerDB.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLeerDB.CausesValidation = false;
            this.btnLeerDB.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnLeerDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeerDB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLeerDB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLeerDB.Location = new System.Drawing.Point(2, 11);
            this.btnLeerDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeerDB.Name = "btnLeerDB";
            this.btnLeerDB.Size = new System.Drawing.Size(146, 52);
            this.btnLeerDB.TabIndex = 0;
            this.btnLeerDB.Text = "LEER DATABASE/\r\nACTUALIZAR LISTADO";
            this.btnLeerDB.UseVisualStyleBackColor = false;
            this.btnLeerDB.Visible = false;
            this.btnLeerDB.Click += new System.EventHandler(this.btnLeerDB_Click);
            // 
            // btnBorrarCliente
            // 
            this.btnBorrarCliente.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBorrarCliente.CausesValidation = false;
            this.btnBorrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBorrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrarCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrarCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBorrarCliente.Location = new System.Drawing.Point(181, 11);
            this.btnBorrarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrarCliente.Name = "btnBorrarCliente";
            this.btnBorrarCliente.Size = new System.Drawing.Size(156, 52);
            this.btnBorrarCliente.TabIndex = 2;
            this.btnBorrarCliente.Text = "BORRAR CLIENTE\r\n";
            this.btnBorrarCliente.UseVisualStyleBackColor = false;
            this.btnBorrarCliente.Visible = false;
            this.btnBorrarCliente.Click += new System.EventHandler(this.btnBorrarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.GhostWhite;
            this.btnModificarCliente.CausesValidation = false;
            this.btnModificarCliente.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificarCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificarCliente.Location = new System.Drawing.Point(380, 11);
            this.btnModificarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(156, 52);
            this.btnModificarCliente.TabIndex = 3;
            this.btnModificarCliente.Text = "MODIFICAR CLIENTE ";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Visible = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // dbStatus
            // 
            this.dbStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusDB});
            this.dbStatus.Location = new System.Drawing.Point(0, 614);
            this.dbStatus.Name = "dbStatus";
            this.dbStatus.Size = new System.Drawing.Size(972, 22);
            this.dbStatus.TabIndex = 10;
            this.dbStatus.Visible = false;
            // 
            // toolStripStatusDB
            // 
            this.toolStripStatusDB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripStatusDB.Name = "toolStripStatusDB";
            this.toolStripStatusDB.Size = new System.Drawing.Size(0, 17);
            // 
            // cbCodigoDescuento
            // 
            this.cbCodigoDescuento.AutoSize = true;
            this.cbCodigoDescuento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbCodigoDescuento.Location = new System.Drawing.Point(181, 577);
            this.cbCodigoDescuento.Name = "cbCodigoDescuento";
            this.cbCodigoDescuento.Size = new System.Drawing.Size(228, 29);
            this.cbCodigoDescuento.TabIndex = 11;
            this.cbCodigoDescuento.Text = "Codigo de descuento?";
            this.cbCodigoDescuento.UseVisualStyleBackColor = true;
            this.cbCodigoDescuento.CheckedChanged += new System.EventHandler(this.cbCodigoDescuento_CheckedChanged);
            // 
            // FrmListadoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(972, 636);
            this.Controls.Add(this.cbCodigoDescuento);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnBorrarCliente);
            this.Controls.Add(this.btnLeerDB);
            this.Controls.Add(this.lblGanancias);
            this.Controls.Add(this.lblGananciasTexto);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.cboOrdenar);
            this.Controls.Add(this.lblOrdenar);
            this.Controls.Add(this.dgListado);
            this.Controls.Add(this.dbStatus);
            this.MaximizeBox = false;
            this.Name = "FrmListadoPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).EndInit();
            this.dbStatus.ResumeLayout(false);
            this.dbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListado;
        private System.Windows.Forms.ComboBox cboOrdenar;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblGananciasTexto;
        private System.Windows.Forms.Label lblGanancias;
        private System.Windows.Forms.ToolStripMenuItem mnuToolStripArchivos;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAbrir;
        private System.Windows.Forms.ToolStripMenuItem mnuItemGuardar;
        private System.Windows.Forms.Button btnLeerDB;
        private System.Windows.Forms.Button btnGuardarDB;
        private System.Windows.Forms.Button btnBorrarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.StatusStrip dbStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDB;
        private System.Windows.Forms.CheckBox cbCodigoDescuento;
    }
}