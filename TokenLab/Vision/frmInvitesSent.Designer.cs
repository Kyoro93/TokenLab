namespace TokenLab.Vision
{
    partial class frmInvitesSent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.brnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvInvitesSent = new System.Windows.Forms.DataGridView();
            this.txbConvidado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbAccepted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbIdEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbStartDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbFinalDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbOwnerLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvitesSent)).BeginInit();
            this.SuspendLayout();
            // 
            // brnRemove
            // 
            this.brnRemove.Location = new System.Drawing.Point(703, 39);
            this.brnRemove.Name = "brnRemove";
            this.brnRemove.Size = new System.Drawing.Size(75, 23);
            this.brnRemove.TabIndex = 8;
            this.brnRemove.Text = "Remover";
            this.brnRemove.UseVisualStyleBackColor = true;
            this.brnRemove.Click += new System.EventHandler(this.BrnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(703, 95);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Voltar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // dgvInvitesSent
            // 
            this.dgvInvitesSent.AllowUserToAddRows = false;
            this.dgvInvitesSent.AllowUserToDeleteRows = false;
            this.dgvInvitesSent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvitesSent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txbConvidado,
            this.txbAccepted,
            this.txbIdEvent,
            this.txbStartDatetime,
            this.txbFinalDatetime,
            this.txbOwnerLogin,
            this.txbDescription});
            this.dgvInvitesSent.Location = new System.Drawing.Point(12, 12);
            this.dgvInvitesSent.Name = "dgvInvitesSent";
            this.dgvInvitesSent.ReadOnly = true;
            this.dgvInvitesSent.Size = new System.Drawing.Size(685, 144);
            this.dgvInvitesSent.TabIndex = 5;
            // 
            // txbConvidado
            // 
            this.txbConvidado.DataPropertyName = "AccessTo";
            this.txbConvidado.HeaderText = "Convidado";
            this.txbConvidado.Name = "txbConvidado";
            this.txbConvidado.ReadOnly = true;
            // 
            // txbAccepted
            // 
            this.txbAccepted.DataPropertyName = "InvitationStatus";
            this.txbAccepted.HeaderText = "Status";
            this.txbAccepted.Name = "txbAccepted";
            this.txbAccepted.ReadOnly = true;
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
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.txbStartDatetime.DefaultCellStyle = dataGridViewCellStyle1;
            this.txbStartDatetime.HeaderText = "Data Inicial";
            this.txbStartDatetime.Name = "txbStartDatetime";
            this.txbStartDatetime.ReadOnly = true;
            // 
            // txbFinalDatetime
            // 
            this.txbFinalDatetime.DataPropertyName = "FinalDatetime";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.txbFinalDatetime.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.txbOwnerLogin.Visible = false;
            // 
            // txbDescription
            // 
            this.txbDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txbDescription.DataPropertyName = "Description";
            this.txbDescription.HeaderText = "Descrição";
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.ReadOnly = true;
            // 
            // frmInvitesSent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 166);
            this.Controls.Add(this.brnRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvInvitesSent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInvitesSent";
            this.Text = "Convites Enviados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvitesSent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button brnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvInvitesSent;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbConvidado;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbAccepted;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbIdEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbStartDatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbFinalDatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbOwnerLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbDescription;
    }
}