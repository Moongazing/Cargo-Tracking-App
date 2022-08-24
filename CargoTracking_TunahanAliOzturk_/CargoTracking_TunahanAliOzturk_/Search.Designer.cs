namespace CargoTracking_TunahanAliOzturk_
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCargoId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReceiverName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenderPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReceiverPhone = new System.Windows.Forms.TextBox();
            this.cbCargoId = new System.Windows.Forms.CheckBox();
            this.cbSenderPhone = new System.Windows.Forms.CheckBox();
            this.cbReceiverPhone = new System.Windows.Forms.CheckBox();
            this.cbSenderName = new System.Windows.Forms.CheckBox();
            this.cbReceiverName = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 233);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtCargoId
            // 
            this.txtCargoId.Location = new System.Drawing.Point(687, 114);
            this.txtCargoId.Name = "txtCargoId";
            this.txtCargoId.Size = new System.Drawing.Size(186, 22);
            this.txtCargoId.TabIndex = 2;
            this.txtCargoId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cargo Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sender Name:";
            // 
            // txtSenderName
            // 
            this.txtSenderName.Location = new System.Drawing.Point(687, 249);
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(186, 22);
            this.txtSenderName.TabIndex = 4;
            this.txtSenderName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(684, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Receiver Name:";
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.Location = new System.Drawing.Point(687, 294);
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(186, 22);
            this.txtReceiverName.TabIndex = 6;
            this.txtReceiverName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sender Phone:";
            // 
            // txtSenderPhone
            // 
            this.txtSenderPhone.Location = new System.Drawing.Point(687, 159);
            this.txtSenderPhone.Name = "txtSenderPhone";
            this.txtSenderPhone.Size = new System.Drawing.Size(186, 22);
            this.txtSenderPhone.TabIndex = 8;
            this.txtSenderPhone.TextChanged += new System.EventHandler(this.txtSenderPhone_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(684, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Receiver Phone:";
            // 
            // txtReceiverPhone
            // 
            this.txtReceiverPhone.Location = new System.Drawing.Point(687, 204);
            this.txtReceiverPhone.Name = "txtReceiverPhone";
            this.txtReceiverPhone.Size = new System.Drawing.Size(186, 22);
            this.txtReceiverPhone.TabIndex = 10;
            this.txtReceiverPhone.TextChanged += new System.EventHandler(this.txtReceiverPhone_TextChanged);
            // 
            // cbCargoId
            // 
            this.cbCargoId.AutoSize = true;
            this.cbCargoId.Location = new System.Drawing.Point(36, 71);
            this.cbCargoId.Name = "cbCargoId";
            this.cbCargoId.Size = new System.Drawing.Size(83, 21);
            this.cbCargoId.TabIndex = 12;
            this.cbCargoId.Text = "Cargo Id";
            this.cbCargoId.UseVisualStyleBackColor = true;
            this.cbCargoId.CheckedChanged += new System.EventHandler(this.cbCargoId_CheckedChanged);
            // 
            // cbSenderPhone
            // 
            this.cbSenderPhone.AutoSize = true;
            this.cbSenderPhone.Location = new System.Drawing.Point(133, 71);
            this.cbSenderPhone.Name = "cbSenderPhone";
            this.cbSenderPhone.Size = new System.Drawing.Size(121, 21);
            this.cbSenderPhone.TabIndex = 13;
            this.cbSenderPhone.Text = "Sender Phone";
            this.cbSenderPhone.UseVisualStyleBackColor = true;
            this.cbSenderPhone.CheckedChanged += new System.EventHandler(this.cbSenderPhone_CheckedChanged);
            // 
            // cbReceiverPhone
            // 
            this.cbReceiverPhone.AutoSize = true;
            this.cbReceiverPhone.Location = new System.Drawing.Point(260, 71);
            this.cbReceiverPhone.Name = "cbReceiverPhone";
            this.cbReceiverPhone.Size = new System.Drawing.Size(131, 21);
            this.cbReceiverPhone.TabIndex = 14;
            this.cbReceiverPhone.Text = "Receiver Phone";
            this.cbReceiverPhone.UseVisualStyleBackColor = true;
            this.cbReceiverPhone.CheckedChanged += new System.EventHandler(this.cbReceiverPhone_CheckedChanged);
            // 
            // cbSenderName
            // 
            this.cbSenderName.AutoSize = true;
            this.cbSenderName.Location = new System.Drawing.Point(397, 71);
            this.cbSenderName.Name = "cbSenderName";
            this.cbSenderName.Size = new System.Drawing.Size(117, 21);
            this.cbSenderName.TabIndex = 15;
            this.cbSenderName.Text = "Sender Name";
            this.cbSenderName.UseVisualStyleBackColor = true;
            this.cbSenderName.CheckedChanged += new System.EventHandler(this.cbSenderName_CheckedChanged);
            // 
            // cbReceiverName
            // 
            this.cbReceiverName.AutoSize = true;
            this.cbReceiverName.Location = new System.Drawing.Point(520, 71);
            this.cbReceiverName.Name = "cbReceiverName";
            this.cbReceiverName.Size = new System.Drawing.Size(127, 21);
            this.cbReceiverName.TabIndex = 16;
            this.cbReceiverName.Text = "Receiver Name";
            this.cbReceiverName.UseVisualStyleBackColor = true;
            this.cbReceiverName.CheckedChanged += new System.EventHandler(this.cbReceiverName_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(8, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1635, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(13, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Search";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(127, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Select Search Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(105, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "|\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(587, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(285, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "© All rights reserved by Tunahan Ali Öztürk.";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 379);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbReceiverName);
            this.Controls.Add(this.cbSenderName);
            this.Controls.Add(this.cbReceiverPhone);
            this.Controls.Add(this.cbSenderPhone);
            this.Controls.Add(this.cbCargoId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtReceiverPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSenderPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReceiverName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenderName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCargoId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCargoId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReceiverName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenderPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReceiverPhone;
        private System.Windows.Forms.CheckBox cbCargoId;
        private System.Windows.Forms.CheckBox cbSenderPhone;
        private System.Windows.Forms.CheckBox cbReceiverPhone;
        private System.Windows.Forms.CheckBox cbSenderName;
        private System.Windows.Forms.CheckBox cbReceiverName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}