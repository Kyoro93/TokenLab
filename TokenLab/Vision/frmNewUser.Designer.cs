namespace TokenLab.Vision
{
    partial class frmNewUser
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbRepeatPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(106, 87);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(187, 87);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(101, 32);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(162, 20);
            this.txbPass.TabIndex = 9;
            this.txbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxbUser_KeyDown);
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(101, 6);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(162, 20);
            this.txbUser.TabIndex = 8;
            this.txbUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxbUser_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuário:";
            // 
            // txbRepeatPass
            // 
            this.txbRepeatPass.Location = new System.Drawing.Point(101, 58);
            this.txbRepeatPass.Name = "txbRepeatPass";
            this.txbRepeatPass.Size = new System.Drawing.Size(162, 20);
            this.txbRepeatPass.TabIndex = 13;
            this.txbRepeatPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxbUser_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Repetir Senha:";
            // 
            // frmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 119);
            this.Controls.Add(this.txbRepeatPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewUser";
            this.Text = "Cadastrar usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbRepeatPass;
        private System.Windows.Forms.Label label3;
    }
}