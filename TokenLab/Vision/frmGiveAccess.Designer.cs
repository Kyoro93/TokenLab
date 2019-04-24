namespace TokenLab.Vision
{
    partial class frmGiveAccess
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbAccessTo = new System.Windows.Forms.TextBox();
            this.btnInvite = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // txbAccessTo
            // 
            this.txbAccessTo.Location = new System.Drawing.Point(64, 6);
            this.txbAccessTo.Name = "txbAccessTo";
            this.txbAccessTo.Size = new System.Drawing.Size(100, 20);
            this.txbAccessTo.TabIndex = 1;
            // 
            // btnInvite
            // 
            this.btnInvite.Location = new System.Drawing.Point(89, 32);
            this.btnInvite.Name = "btnInvite";
            this.btnInvite.Size = new System.Drawing.Size(75, 23);
            this.btnInvite.TabIndex = 2;
            this.btnInvite.Text = "Convidar";
            this.btnInvite.UseVisualStyleBackColor = true;
            this.btnInvite.Click += new System.EventHandler(this.BtnInvite_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(8, 32);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // frmGiveAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 64);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInvite);
            this.Controls.Add(this.txbAccessTo);
            this.Controls.Add(this.label1);
            this.Name = "frmGiveAccess";
            this.Text = "Convidar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAccessTo;
        private System.Windows.Forms.Button btnInvite;
        private System.Windows.Forms.Button btnCancel;
    }
}