
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
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).BeginInit();
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
            this.dgListado.Location = new System.Drawing.Point(2, 53);
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
            this.cboOrdenar.Location = new System.Drawing.Point(841, 18);
            this.cboOrdenar.Name = "cboOrdenar";
            this.cboOrdenar.Size = new System.Drawing.Size(121, 23);
            this.cboOrdenar.TabIndex = 0;
            this.cboOrdenar.SelectedValueChanged += new System.EventHandler(this.cboOrdenar_SelectedValueChanged);
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrdenar.Location = new System.Drawing.Point(760, 21);
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
            this.btnAtender.Location = new System.Drawing.Point(429, 566);
            this.btnAtender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(119, 66);
            this.btnAtender.TabIndex = 3;
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
            this.btnVolver.Location = new System.Drawing.Point(2, 568);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(114, 60);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblGananciasTexto
            // 
            this.lblGananciasTexto.AutoSize = true;
            this.lblGananciasTexto.BackColor = System.Drawing.Color.GhostWhite;
            this.lblGananciasTexto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGananciasTexto.Location = new System.Drawing.Point(760, 586);
            this.lblGananciasTexto.Name = "lblGananciasTexto";
            this.lblGananciasTexto.Size = new System.Drawing.Size(107, 25);
            this.lblGananciasTexto.TabIndex = 4;
            this.lblGananciasTexto.Text = "Ganancias:";
            // 
            // lblGanancias
            // 
            this.lblGanancias.AutoSize = true;
            this.lblGanancias.BackColor = System.Drawing.Color.GhostWhite;
            this.lblGanancias.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGanancias.Location = new System.Drawing.Point(864, 586);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(0, 25);
            this.lblGanancias.TabIndex = 9;
            // 
            // FrmListadoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 632);
            this.Controls.Add(this.lblGanancias);
            this.Controls.Add(this.lblGananciasTexto);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.cboOrdenar);
            this.Controls.Add(this.lblOrdenar);
            this.Controls.Add(this.dgListado);
            this.MaximizeBox = false;
            this.Name = "FrmListadoPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Pedidos";
            this.Load += new System.EventHandler(this.FrmListadoPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).EndInit();
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
    }
}