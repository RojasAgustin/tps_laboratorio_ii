
namespace ControlesDeUsuario
{
    partial class TxtSoloNumeros
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNum.Location = new System.Drawing.Point(0, 1);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(161, 23);
            this.txtNum.TabIndex = 1;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // TxtSoloNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNum);
            this.Name = "TxtSoloNumeros";
            this.Size = new System.Drawing.Size(164, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
    }
}
