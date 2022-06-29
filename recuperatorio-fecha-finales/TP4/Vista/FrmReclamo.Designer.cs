
namespace Vista
{
    partial class FrmReclamo
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblReclamo = new System.Windows.Forms.Label();
            this.rtbReclamo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnConfirmar.CausesValidation = false;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirmar.Location = new System.Drawing.Point(217, 174);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(88, 29);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.GhostWhite;
            this.btnVolver.CausesValidation = false;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.Location = new System.Drawing.Point(-2, 174);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(80, 29);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblReclamo
            // 
            this.lblReclamo.AutoSize = true;
            this.lblReclamo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReclamo.Location = new System.Drawing.Point(-2, 9);
            this.lblReclamo.Name = "lblReclamo";
            this.lblReclamo.Size = new System.Drawing.Size(112, 15);
            this.lblReclamo.TabIndex = 5;
            this.lblReclamo.Text = "Ingrese su reclamo";
            // 
            // rtbReclamo
            // 
            this.rtbReclamo.BackColor = System.Drawing.Color.Snow;
            this.rtbReclamo.Location = new System.Drawing.Point(-2, 27);
            this.rtbReclamo.Name = "rtbReclamo";
            this.rtbReclamo.Size = new System.Drawing.Size(307, 104);
            this.rtbReclamo.TabIndex = 0;
            this.rtbReclamo.Text = "";
            // 
            // FrmReclamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(300, 202);
            this.Controls.Add(this.rtbReclamo);
            this.Controls.Add(this.lblReclamo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnVolver);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReclamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enviar Reclamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblReclamo;
        private System.Windows.Forms.RichTextBox rtbReclamo;
    }
}