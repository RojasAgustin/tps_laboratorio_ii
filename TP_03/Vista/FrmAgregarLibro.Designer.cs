
namespace Vista
{
    partial class FrmAgregarLibro
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
            this.rbtnNoFiccion = new System.Windows.Forms.RadioButton();
            this.rbtnComic = new System.Windows.Forms.RadioButton();
            this.rbtnNovela = new System.Windows.Forms.RadioButton();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new ControlesDeUsuario.TxtSoloNumeros();
            this.txtPaginas = new ControlesDeUsuario.TxtSoloNumeros();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.cboClasificacion = new System.Windows.Forms.ComboBox();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.lblBooleano = new System.Windows.Forms.Label();
            this.cbBooleano = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtnNoFiccion
            // 
            this.rbtnNoFiccion.AutoSize = true;
            this.rbtnNoFiccion.Location = new System.Drawing.Point(333, 9);
            this.rbtnNoFiccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnNoFiccion.Name = "rbtnNoFiccion";
            this.rbtnNoFiccion.Size = new System.Drawing.Size(82, 19);
            this.rbtnNoFiccion.TabIndex = 3;
            this.rbtnNoFiccion.Text = "No Ficcion";
            this.rbtnNoFiccion.UseVisualStyleBackColor = true;
            this.rbtnNoFiccion.CheckedChanged += new System.EventHandler(this.rbtnNoFiccion_CheckedChanged);
            // 
            // rbtnComic
            // 
            this.rbtnComic.AutoSize = true;
            this.rbtnComic.Location = new System.Drawing.Point(267, 9);
            this.rbtnComic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnComic.Name = "rbtnComic";
            this.rbtnComic.Size = new System.Drawing.Size(60, 19);
            this.rbtnComic.TabIndex = 2;
            this.rbtnComic.Text = "Comic";
            this.rbtnComic.UseVisualStyleBackColor = true;
            this.rbtnComic.CheckedChanged += new System.EventHandler(this.rbtnComic_CheckedChanged);
            // 
            // rbtnNovela
            // 
            this.rbtnNovela.AutoSize = true;
            this.rbtnNovela.Checked = true;
            this.rbtnNovela.Location = new System.Drawing.Point(206, 9);
            this.rbtnNovela.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnNovela.Name = "rbtnNovela";
            this.rbtnNovela.Size = new System.Drawing.Size(62, 19);
            this.rbtnNovela.TabIndex = 1;
            this.rbtnNovela.TabStop = true;
            this.rbtnNovela.Text = "Novela";
            this.rbtnNovela.UseVisualStyleBackColor = true;
            this.rbtnNovela.CheckedChanged += new System.EventHandler(this.rbtnNovela_CheckedChanged);
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoProducto.Location = new System.Drawing.Point(62, 9);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(126, 15);
            this.lblTipoProducto.TabIndex = 0;
            this.lblTipoProducto.Text = "TIPO DE PRODUCTO: ";
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.Color.GhostWhite;
            this.txtAutor.Location = new System.Drawing.Point(90, 74);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(192, 23);
            this.txtAutor.TabIndex = 6;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.GhostWhite;
            this.txtTitulo.Location = new System.Drawing.Point(90, 40);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(192, 23);
            this.txtTitulo.TabIndex = 4;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAutor.Location = new System.Drawing.Point(13, 77);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(51, 15);
            this.lblAutor.TabIndex = 16;
            this.lblAutor.Text = "AUTOR:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(12, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(52, 15);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "TITULO:";
            // 
            // txtEditorial
            // 
            this.txtEditorial.BackColor = System.Drawing.Color.GhostWhite;
            this.txtEditorial.Location = new System.Drawing.Point(90, 110);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(192, 23);
            this.txtEditorial.TabIndex = 8;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEditorial.Location = new System.Drawing.Point(13, 110);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(71, 15);
            this.lblEditorial.TabIndex = 18;
            this.lblEditorial.Text = "EDITORIAL:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(333, 43);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(51, 15);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "PRECIO:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(415, 36);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(134, 22);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(415, 71);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(134, 22);
            this.txtPaginas.TabIndex = 7;
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaginas.Location = new System.Drawing.Point(333, 78);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(61, 15);
            this.lblPaginas.TabIndex = 17;
            this.lblPaginas.Text = "PAGINAS:";
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.BackColor = System.Drawing.Color.GhostWhite;
            this.cboClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboClasificacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboClasificacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(415, 106);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(134, 23);
            this.cboClasificacion.TabIndex = 9;
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClasificacion.Location = new System.Drawing.Point(333, 110);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(57, 15);
            this.lblClasificacion.TabIndex = 19;
            this.lblClasificacion.Text = "GENERO:";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdioma.Location = new System.Drawing.Point(13, 150);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(55, 15);
            this.lblIdioma.TabIndex = 20;
            this.lblIdioma.Text = "IDIOMA:";
            // 
            // cboIdioma
            // 
            this.cboIdioma.BackColor = System.Drawing.Color.GhostWhite;
            this.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboIdioma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboIdioma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Location = new System.Drawing.Point(90, 146);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(98, 23);
            this.cboIdioma.TabIndex = 10;
            // 
            // lblBooleano
            // 
            this.lblBooleano.AutoSize = true;
            this.lblBooleano.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBooleano.Location = new System.Drawing.Point(333, 150);
            this.lblBooleano.Name = "lblBooleano";
            this.lblBooleano.Size = new System.Drawing.Size(82, 15);
            this.lblBooleano.TabIndex = 21;
            this.lblBooleano.Text = "HARDCOVER:";
            // 
            // cbBooleano
            // 
            this.cbBooleano.AutoSize = true;
            this.cbBooleano.Location = new System.Drawing.Point(421, 150);
            this.cbBooleano.Name = "cbBooleano";
            this.cbBooleano.Size = new System.Drawing.Size(15, 14);
            this.cbBooleano.TabIndex = 11;
            this.cbBooleano.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSalir.CausesValidation = false;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(13, 193);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 41);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAgregar.CausesValidation = false;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(396, 193);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 41);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmAgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 245);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbBooleano);
            this.Controls.Add(this.lblBooleano);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.cboIdioma);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.cboClasificacion);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rbtnNoFiccion);
            this.Controls.Add(this.rbtnComic);
            this.Controls.Add(this.rbtnNovela);
            this.Controls.Add(this.lblTipoProducto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgregarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Libro";
            this.Load += new System.EventHandler(this.FrmAgregarLibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnNoFiccion;
        private System.Windows.Forms.RadioButton rbtnComic;
        private System.Windows.Forms.RadioButton rbtnNovela;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblPrecio;
        private ControlesDeUsuario.TxtSoloNumeros txtPrecio;
        private ControlesDeUsuario.TxtSoloNumeros txtPaginas;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.ComboBox cboClasificacion;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox cboIdioma;
        private System.Windows.Forms.Label lblBooleano;
        private System.Windows.Forms.CheckBox cbBooleano;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
    }
}