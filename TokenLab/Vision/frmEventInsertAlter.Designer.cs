namespace TokenLab.Vision
{
    partial class frmEventInsertAlter
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
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFinalDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbStartTime = new System.Windows.Forms.MaskedTextBox();
            this.mtbFinalTime = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(73, 12);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(471, 114);
            this.rtbDescription.TabIndex = 0;
            this.rtbDescription.Text = "";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(73, 181);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(223, 20);
            this.dtpStartDate.TabIndex = 1;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.ControlDates);
            // 
            // dtpFinalDate
            // 
            this.dtpFinalDate.Location = new System.Drawing.Point(321, 181);
            this.dtpFinalDate.Name = "dtpFinalDate";
            this.dtpFinalDate.Size = new System.Drawing.Size(223, 20);
            this.dtpFinalDate.TabIndex = 2;
            this.dtpFinalDate.ValueChanged += new System.EventHandler(this.ControlDates);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "INICIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "FIM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hora";
            // 
            // mtbStartTime
            // 
            this.mtbStartTime.Location = new System.Drawing.Point(73, 220);
            this.mtbStartTime.Mask = "00:00";
            this.mtbStartTime.Name = "mtbStartTime";
            this.mtbStartTime.Size = new System.Drawing.Size(100, 20);
            this.mtbStartTime.TabIndex = 14;
            this.mtbStartTime.ValidatingType = typeof(System.DateTime);
            // 
            // mtbFinalTime
            // 
            this.mtbFinalTime.Location = new System.Drawing.Point(321, 220);
            this.mtbFinalTime.Mask = "00:00";
            this.mtbFinalTime.Name = "mtbFinalTime";
            this.mtbFinalTime.Size = new System.Drawing.Size(100, 20);
            this.mtbFinalTime.TabIndex = 15;
            this.mtbFinalTime.ValidatingType = typeof(System.DateTime);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(550, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(550, 50);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // frmEventInsertAlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 252);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mtbFinalTime);
            this.Controls.Add(this.mtbStartTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFinalDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.rtbDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEventInsertAlter";
            this.Text = "Edição de evento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpFinalDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbStartTime;
        private System.Windows.Forms.MaskedTextBox mtbFinalTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}