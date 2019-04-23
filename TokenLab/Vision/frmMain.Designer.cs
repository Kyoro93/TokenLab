namespace TokenLab
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEvent = new System.Windows.Forms.DataGridView();
            this.btnNewEvent = new System.Windows.Forms.Button();
            this.btnAlterEvent = new System.Windows.Forms.Button();
            this.btnDelEvent = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnInvited = new System.Windows.Forms.Button();
            this.txbIdEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbStartDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbFinalDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbOwnerLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvent
            // 
            this.dgvEvent.AllowUserToAddRows = false;
            this.dgvEvent.AllowUserToDeleteRows = false;
            this.dgvEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txbIdEvent,
            this.txbStartDatetime,
            this.txbFinalDatetime,
            this.txbOwnerLogin,
            this.txbDescription});
            this.dgvEvent.Location = new System.Drawing.Point(13, 12);
            this.dgvEvent.Name = "dgvEvent";
            this.dgvEvent.ReadOnly = true;
            this.dgvEvent.Size = new System.Drawing.Size(685, 426);
            this.dgvEvent.TabIndex = 0;
            // 
            // btnNewEvent
            // 
            this.btnNewEvent.Location = new System.Drawing.Point(713, 22);
            this.btnNewEvent.Name = "btnNewEvent";
            this.btnNewEvent.Size = new System.Drawing.Size(75, 23);
            this.btnNewEvent.TabIndex = 1;
            this.btnNewEvent.Text = "Adicionar";
            this.btnNewEvent.UseVisualStyleBackColor = true;
            this.btnNewEvent.Click += new System.EventHandler(this.BtnNewEvent_Click);
            // 
            // btnAlterEvent
            // 
            this.btnAlterEvent.Location = new System.Drawing.Point(713, 51);
            this.btnAlterEvent.Name = "btnAlterEvent";
            this.btnAlterEvent.Size = new System.Drawing.Size(75, 23);
            this.btnAlterEvent.TabIndex = 2;
            this.btnAlterEvent.Text = "Alterar";
            this.btnAlterEvent.UseVisualStyleBackColor = true;
            this.btnAlterEvent.Click += new System.EventHandler(this.BtnAlterEvent_Click);
            // 
            // btnDelEvent
            // 
            this.btnDelEvent.Location = new System.Drawing.Point(713, 80);
            this.btnDelEvent.Name = "btnDelEvent";
            this.btnDelEvent.Size = new System.Drawing.Size(75, 23);
            this.btnDelEvent.TabIndex = 3;
            this.btnDelEvent.Text = "Remover";
            this.btnDelEvent.UseVisualStyleBackColor = true;
            this.btnDelEvent.Click += new System.EventHandler(this.BtnDelEvent_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(704, 178);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(84, 23);
            this.btnChangePass.TabIndex = 4;
            this.btnChangePass.Text = "Alterar Senha";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.BtnChangePass_Click);
            // 
            // btnInvited
            // 
            this.btnInvited.Location = new System.Drawing.Point(713, 109);
            this.btnInvited.Name = "btnInvited";
            this.btnInvited.Size = new System.Drawing.Size(75, 23);
            this.btnInvited.TabIndex = 5;
            this.btnInvited.Text = "Convidados";
            this.btnInvited.UseVisualStyleBackColor = true;
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
            this.txbOwnerLogin.HeaderText = "Criador";
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInvited);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnDelEvent);
            this.Controls.Add(this.btnAlterEvent);
            this.Controls.Add(this.btnNewEvent);
            this.Controls.Add(this.dgvEvent);
            this.Name = "Main";
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvent;
        private System.Windows.Forms.Button btnNewEvent;
        private System.Windows.Forms.Button btnAlterEvent;
        private System.Windows.Forms.Button btnDelEvent;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnInvited;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbIdEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbStartDatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbFinalDatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbOwnerLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbDescription;
    }
}

