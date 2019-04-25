namespace TokenLab.Vision
{
    partial class frmInvitesReceived
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
            this.dgvInvitesReceived = new System.Windows.Forms.DataGridView();
            this.txbIdEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbStartDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbFinalDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbOwnerLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbAccepted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.brnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvitesReceived)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvitesReceived
            // 
            this.dgvInvitesReceived.AllowUserToAddRows = false;
            this.dgvInvitesReceived.AllowUserToDeleteRows = false;
            this.dgvInvitesReceived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvitesReceived.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txbIdEvent,
            this.txbStartDatetime,
            this.txbFinalDatetime,
            this.txbOwnerLogin,
            this.txbDescription,
            this.txbAccepted});
            this.dgvInvitesReceived.Location = new System.Drawing.Point(12, 12);
            this.dgvInvitesReceived.Name = "dgvInvitesReceived";
            this.dgvInvitesReceived.ReadOnly = true;
            this.dgvInvitesReceived.Size = new System.Drawing.Size(685, 144);
            this.dgvInvitesReceived.TabIndex = 1;
            // 
            // txbIdEvent
            // 
            this.txbIdEvent.DataPropertyName = "IdEvent";
            this.txbIdEvent.HeaderText = "IdEvent";
            this.txbIdEvent.Name = "txbIdEvent";
            this.txbIdEvent.ReadOnly = true;
            this.txbIdEvent.Visible = false;
            // 
            // txbStartDatetime
            // 
            this.txbStartDatetime.DataPropertyName = "StartDatetime";
            this.txbStartDatetime.HeaderText = "Data Inicial";
            this.txbStartDatetime.Name = "txbStartDatetime";
            this.txbStartDatetime.ReadOnly = true;
            // 
            // txbFinalDatetime
            // 
            this.txbFinalDatetime.DataPropertyName = "FinalDatetime";
            this.txbFinalDatetime.HeaderText = "Data Final";
            this.txbFinalDatetime.Name = "txbFinalDatetime";
            this.txbFinalDatetime.ReadOnly = true;
            // 
            // txbOwnerLogin
            // 
            this.txbOwnerLogin.DataPropertyName = "OwnerLogin";
            this.txbOwnerLogin.HeaderText = "Convidado por";
            this.txbOwnerLogin.Name = "txbOwnerLogin";
            this.txbOwnerLogin.ReadOnly = true;
            // 
            // txbDescription
            // 
            this.txbDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txbDescription.DataPropertyName = "Description";
            this.txbDescription.HeaderText = "Descrição";
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.ReadOnly = true;
            // 
            // txbAccepted
            // 
            this.txbAccepted.DataPropertyName = "InvitationStatus";
            this.txbAccepted.HeaderText = "Status";
            this.txbAccepted.Name = "txbAccepted";
            this.txbAccepted.ReadOnly = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(703, 12);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Aceitar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(703, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Voltar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // brnRemove
            // 
            this.brnRemove.Location = new System.Drawing.Point(703, 41);
            this.brnRemove.Name = "brnRemove";
            this.brnRemove.Size = new System.Drawing.Size(75, 23);
            this.brnRemove.TabIndex = 4;
            this.brnRemove.Text = "Remover";
            this.brnRemove.UseVisualStyleBackColor = true;
            this.brnRemove.Click += new System.EventHandler(this.BrnRemove_Click);
            // 
            // frmInvitesReceived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 169);
            this.Controls.Add(this.brnRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.dgvInvitesReceived);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInvitesReceived";
            this.Text = "Convites Recebidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvitesReceived)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvitesReceived;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbIdEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbStartDatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbFinalDatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbOwnerLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbAccepted;
        private System.Windows.Forms.Button brnRemove;
    }
}