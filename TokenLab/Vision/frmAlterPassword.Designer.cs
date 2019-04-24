namespace TokenLab.Vision
{
    partial class frmAlterPassword
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
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbRepeatPass = new System.Windows.Forms.TextBox();
            this.btnAlter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nova senha:";
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(127, 12);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(100, 20);
            this.txbPass.TabIndex = 1;
            this.txbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxbPass_KeyDown);
            // 
            // txbRepeatPass
            // 
            this.txbRepeatPass.Location = new System.Drawing.Point(127, 38);
            this.txbRepeatPass.Name = "txbRepeatPass";
            this.txbRepeatPass.Size = new System.Drawing.Size(100, 20);
            this.txbRepeatPass.TabIndex = 2;
            this.txbRepeatPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxbPass_KeyDown);
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(152, 64);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 3;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.BtnAlter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Repita a nova senha:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(71, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // frmAlterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 97);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.txbRepeatPass);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterPassword";
            this.Text = "Alterar senha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAlterPassword_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbRepeatPass;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
    }
}