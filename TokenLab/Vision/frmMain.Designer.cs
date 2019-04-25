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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEvent = new System.Windows.Forms.DataGridView();
            this.txbIdEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbStartDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbFinalDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbOwnerLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewEvent = new System.Windows.Forms.Button();
            this.btnAlterEvent = new System.Windows.Forms.Button();
            this.btnDelEvent = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnInvited = new System.Windows.Forms.Button();
            this.btnInvite = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlEvent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnviados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlEvent.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.dgvEvent.Location = new System.Drawing.Point(13, 27);
            this.dgvEvent.Name = "dgvEvent";
            this.dgvEvent.ReadOnly = true;
            this.dgvEvent.Size = new System.Drawing.Size(685, 411);
            this.dgvEvent.TabIndex = 0;
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
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.txbStartDatetime.DefaultCellStyle = dataGridViewCellStyle3;
            this.txbStartDatetime.HeaderText = "Data Inicial";
            this.txbStartDatetime.Name = "txbStartDatetime";
            this.txbStartDatetime.ReadOnly = true;
            // 
            // txbFinalDatetime
            // 
            this.txbFinalDatetime.DataPropertyName = "FinalDatetime";
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            this.txbFinalDatetime.DefaultCellStyle = dataGridViewCellStyle4;
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
            // btnNewEvent
            // 
            this.btnNewEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewEvent.Location = new System.Drawing.Point(5, 5);
            this.btnNewEvent.Name = "btnNewEvent";
            this.btnNewEvent.Size = new System.Drawing.Size(73, 21);
            this.btnNewEvent.TabIndex = 1;
            this.btnNewEvent.Text = "Adicionar";
            this.btnNewEvent.UseVisualStyleBackColor = true;
            this.btnNewEvent.Click += new System.EventHandler(this.BtnNewEvent_Click);
            // 
            // btnAlterEvent
            // 
            this.btnAlterEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterEvent.Location = new System.Drawing.Point(5, 32);
            this.btnAlterEvent.Name = "btnAlterEvent";
            this.btnAlterEvent.Size = new System.Drawing.Size(73, 21);
            this.btnAlterEvent.TabIndex = 2;
            this.btnAlterEvent.Text = "Alterar";
            this.btnAlterEvent.UseVisualStyleBackColor = true;
            this.btnAlterEvent.Click += new System.EventHandler(this.BtnAlterEvent_Click);
            // 
            // btnDelEvent
            // 
            this.btnDelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelEvent.Location = new System.Drawing.Point(5, 59);
            this.btnDelEvent.Name = "btnDelEvent";
            this.btnDelEvent.Size = new System.Drawing.Size(73, 21);
            this.btnDelEvent.TabIndex = 3;
            this.btnDelEvent.Text = "Remover";
            this.btnDelEvent.UseVisualStyleBackColor = true;
            this.btnDelEvent.Click += new System.EventHandler(this.BtnDelEvent_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(709, 290);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(75, 34);
            this.btnChangePass.TabIndex = 4;
            this.btnChangePass.Text = "Alterar Senha";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.BtnChangePass_Click);
            // 
            // btnInvited
            // 
            this.btnInvited.Location = new System.Drawing.Point(3, 32);
            this.btnInvited.Name = "btnInvited";
            this.btnInvited.Size = new System.Drawing.Size(75, 23);
            this.btnInvited.TabIndex = 5;
            this.btnInvited.Text = "Recebidos";
            this.btnInvited.UseVisualStyleBackColor = true;
            this.btnInvited.Click += new System.EventHandler(this.BtnInvited_Click);
            // 
            // btnInvite
            // 
            this.btnInvite.Location = new System.Drawing.Point(3, 3);
            this.btnInvite.Name = "btnInvite";
            this.btnInvite.Size = new System.Drawing.Size(75, 23);
            this.btnInvite.TabIndex = 6;
            this.btnInvite.Text = "Convidar";
            this.btnInvite.UseVisualStyleBackColor = true;
            this.btnInvite.Click += new System.EventHandler(this.BtnInvite_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.SAIRToolStripMenuItem_Click);
            // 
            // pnlEvent
            // 
            this.pnlEvent.AccessibleName = "Eventos";
            this.pnlEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEvent.Controls.Add(this.btnNewEvent);
            this.pnlEvent.Controls.Add(this.btnDelEvent);
            this.pnlEvent.Controls.Add(this.btnAlterEvent);
            this.pnlEvent.Location = new System.Drawing.Point(705, 51);
            this.pnlEvent.Name = "pnlEvent";
            this.pnlEvent.Size = new System.Drawing.Size(83, 92);
            this.pnlEvent.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(704, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Eventos";
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "Eventos";
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEnviados);
            this.panel1.Controls.Add(this.btnInvite);
            this.panel1.Controls.Add(this.btnInvited);
            this.panel1.Location = new System.Drawing.Point(705, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 91);
            this.panel1.TabIndex = 10;
            // 
            // btnEnviados
            // 
            this.btnEnviados.Location = new System.Drawing.Point(3, 61);
            this.btnEnviados.Name = "btnEnviados";
            this.btnEnviados.Size = new System.Drawing.Size(75, 23);
            this.btnEnviados.TabIndex = 7;
            this.btnEnviados.Text = "Enviados";
            this.btnEnviados.UseVisualStyleBackColor = true;
            this.btnEnviados.Click += new System.EventHandler(this.BtnEnviados_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(704, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Convites";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.Color.Tomato;
            this.panel2.Location = new System.Drawing.Point(705, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 15);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tomato;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.ForeColor = System.Drawing.Color.Tomato;
            this.panel3.Location = new System.Drawing.Point(705, 395);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 15);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.ForeColor = System.Drawing.Color.Tomato;
            this.panel4.Location = new System.Drawing.Point(705, 416);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 15);
            this.panel4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "OK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(726, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Finalizado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(727, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Aceito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(715, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Legenda";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.dgvEvent);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlEvent);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlEvent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvent;
        private System.Windows.Forms.Button btnNewEvent;
        private System.Windows.Forms.Button btnAlterEvent;
        private System.Windows.Forms.Button btnDelEvent;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnInvited;
        private System.Windows.Forms.Button btnInvite;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.Panel pnlEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnviados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbIdEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbStartDatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbFinalDatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbOwnerLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

