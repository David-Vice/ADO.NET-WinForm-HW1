namespace ADO.NET_WinForm_HW1
{
    partial class Form1
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelState = new System.Windows.Forms.Label();
            this.task_3_1 = new System.Windows.Forms.Button();
            this.task_3_2 = new System.Windows.Forms.Button();
            this.task_3_3 = new System.Windows.Forms.Button();
            this.task_3_4 = new System.Windows.Forms.Button();
            this.task_3_5 = new System.Windows.Forms.Button();
            this.task_3_6 = new System.Windows.Forms.Button();
            this.task_4_6 = new System.Windows.Forms.Button();
            this.task_4_5 = new System.Windows.Forms.Button();
            this.task_4_4 = new System.Windows.Forms.Button();
            this.task_4_3 = new System.Windows.Forms.Button();
            this.task_4_2 = new System.Windows.Forms.Button();
            this.task_4_1 = new System.Windows.Forms.Button();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.task_4_7 = new System.Windows.Forms.Button();
            this.task_4_8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.Lime;
            this.buttonConnect.Location = new System.Drawing.Point(12, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(89, 36);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.Red;
            this.buttonDisconnect.Location = new System.Drawing.Point(107, 12);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(89, 36);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.BackColor = System.Drawing.Color.Yellow;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.ForeColor = System.Drawing.Color.Black;
            this.labelState.Location = new System.Drawing.Point(12, 63);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(53, 20);
            this.labelState.TabIndex = 2;
            this.labelState.Text = "State";
            // 
            // task_3_1
            // 
            this.task_3_1.Location = new System.Drawing.Point(12, 98);
            this.task_3_1.Name = "task_3_1";
            this.task_3_1.Size = new System.Drawing.Size(89, 36);
            this.task_3_1.TabIndex = 3;
            this.task_3_1.Text = "task3.1";
            this.task_3_1.UseVisualStyleBackColor = true;
            this.task_3_1.Click += new System.EventHandler(this.task_3_1_Click);
            // 
            // task_3_2
            // 
            this.task_3_2.Location = new System.Drawing.Point(12, 140);
            this.task_3_2.Name = "task_3_2";
            this.task_3_2.Size = new System.Drawing.Size(89, 36);
            this.task_3_2.TabIndex = 4;
            this.task_3_2.Text = "task3.2";
            this.task_3_2.UseVisualStyleBackColor = true;
            this.task_3_2.Click += new System.EventHandler(this.task_3_2_Click);
            // 
            // task_3_3
            // 
            this.task_3_3.Location = new System.Drawing.Point(12, 182);
            this.task_3_3.Name = "task_3_3";
            this.task_3_3.Size = new System.Drawing.Size(89, 36);
            this.task_3_3.TabIndex = 5;
            this.task_3_3.Text = "task3.3";
            this.task_3_3.UseVisualStyleBackColor = true;
            this.task_3_3.Click += new System.EventHandler(this.task_3_3_Click);
            // 
            // task_3_4
            // 
            this.task_3_4.Location = new System.Drawing.Point(12, 224);
            this.task_3_4.Name = "task_3_4";
            this.task_3_4.Size = new System.Drawing.Size(89, 36);
            this.task_3_4.TabIndex = 6;
            this.task_3_4.Text = "task3.4";
            this.task_3_4.UseVisualStyleBackColor = true;
            this.task_3_4.Click += new System.EventHandler(this.task_3_4_Click);
            // 
            // task_3_5
            // 
            this.task_3_5.Location = new System.Drawing.Point(12, 266);
            this.task_3_5.Name = "task_3_5";
            this.task_3_5.Size = new System.Drawing.Size(89, 36);
            this.task_3_5.TabIndex = 7;
            this.task_3_5.Text = "task3.5";
            this.task_3_5.UseVisualStyleBackColor = true;
            this.task_3_5.Click += new System.EventHandler(this.task_3_5_Click);
            // 
            // task_3_6
            // 
            this.task_3_6.Location = new System.Drawing.Point(12, 308);
            this.task_3_6.Name = "task_3_6";
            this.task_3_6.Size = new System.Drawing.Size(89, 36);
            this.task_3_6.TabIndex = 8;
            this.task_3_6.Text = "task3.6";
            this.task_3_6.UseVisualStyleBackColor = true;
            this.task_3_6.Click += new System.EventHandler(this.task_3_6_Click);
            // 
            // task_4_6
            // 
            this.task_4_6.Location = new System.Drawing.Point(107, 308);
            this.task_4_6.Name = "task_4_6";
            this.task_4_6.Size = new System.Drawing.Size(89, 36);
            this.task_4_6.TabIndex = 14;
            this.task_4_6.Text = "task4.6";
            this.task_4_6.UseVisualStyleBackColor = true;
            this.task_4_6.Click += new System.EventHandler(this.task_4_6_Click);
            // 
            // task_4_5
            // 
            this.task_4_5.Location = new System.Drawing.Point(107, 266);
            this.task_4_5.Name = "task_4_5";
            this.task_4_5.Size = new System.Drawing.Size(89, 36);
            this.task_4_5.TabIndex = 13;
            this.task_4_5.Text = "task4.5";
            this.task_4_5.UseVisualStyleBackColor = true;
            this.task_4_5.Click += new System.EventHandler(this.task_4_5_Click);
            // 
            // task_4_4
            // 
            this.task_4_4.Location = new System.Drawing.Point(107, 224);
            this.task_4_4.Name = "task_4_4";
            this.task_4_4.Size = new System.Drawing.Size(89, 36);
            this.task_4_4.TabIndex = 12;
            this.task_4_4.Text = "task4.4";
            this.task_4_4.UseVisualStyleBackColor = true;
            this.task_4_4.Click += new System.EventHandler(this.task_4_4_Click);
            // 
            // task_4_3
            // 
            this.task_4_3.Location = new System.Drawing.Point(107, 182);
            this.task_4_3.Name = "task_4_3";
            this.task_4_3.Size = new System.Drawing.Size(89, 36);
            this.task_4_3.TabIndex = 11;
            this.task_4_3.Text = "task4.3";
            this.task_4_3.UseVisualStyleBackColor = true;
            this.task_4_3.Click += new System.EventHandler(this.task_4_3_Click);
            // 
            // task_4_2
            // 
            this.task_4_2.Location = new System.Drawing.Point(107, 140);
            this.task_4_2.Name = "task_4_2";
            this.task_4_2.Size = new System.Drawing.Size(89, 36);
            this.task_4_2.TabIndex = 10;
            this.task_4_2.Text = "task4.2";
            this.task_4_2.UseVisualStyleBackColor = true;
            this.task_4_2.Click += new System.EventHandler(this.task_4_2_Click);
            // 
            // task_4_1
            // 
            this.task_4_1.Location = new System.Drawing.Point(107, 98);
            this.task_4_1.Name = "task_4_1";
            this.task_4_1.Size = new System.Drawing.Size(89, 36);
            this.task_4_1.TabIndex = 9;
            this.task_4_1.Text = "task4.1";
            this.task_4_1.UseVisualStyleBackColor = true;
            this.task_4_1.Click += new System.EventHandler(this.task_4_1_Click);
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AllowUserToDeleteRows = false;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(234, 12);
            this.dataGV.Name = "dataGV";
            this.dataGV.ReadOnly = true;
            this.dataGV.RowHeadersWidth = 51;
            this.dataGV.RowTemplate.Height = 24;
            this.dataGV.Size = new System.Drawing.Size(554, 426);
            this.dataGV.TabIndex = 15;
            // 
            // task_4_7
            // 
            this.task_4_7.Location = new System.Drawing.Point(107, 350);
            this.task_4_7.Name = "task_4_7";
            this.task_4_7.Size = new System.Drawing.Size(89, 36);
            this.task_4_7.TabIndex = 16;
            this.task_4_7.Text = "task4.7";
            this.task_4_7.UseVisualStyleBackColor = true;
            this.task_4_7.Click += new System.EventHandler(this.task_4_7_Click);
            // 
            // task_4_8
            // 
            this.task_4_8.Location = new System.Drawing.Point(107, 391);
            this.task_4_8.Name = "task_4_8";
            this.task_4_8.Size = new System.Drawing.Size(89, 36);
            this.task_4_8.TabIndex = 17;
            this.task_4_8.Text = "task4.8";
            this.task_4_8.UseVisualStyleBackColor = true;
            this.task_4_8.Click += new System.EventHandler(this.task_4_8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.task_4_8);
            this.Controls.Add(this.task_4_7);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.task_4_6);
            this.Controls.Add(this.task_4_5);
            this.Controls.Add(this.task_4_4);
            this.Controls.Add(this.task_4_3);
            this.Controls.Add(this.task_4_2);
            this.Controls.Add(this.task_4_1);
            this.Controls.Add(this.task_3_6);
            this.Controls.Add(this.task_3_5);
            this.Controls.Add(this.task_3_4);
            this.Controls.Add(this.task_3_3);
            this.Controls.Add(this.task_3_2);
            this.Controls.Add(this.task_3_1);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Button task_3_1;
        private System.Windows.Forms.Button task_3_2;
        private System.Windows.Forms.Button task_3_3;
        private System.Windows.Forms.Button task_3_4;
        private System.Windows.Forms.Button task_3_5;
        private System.Windows.Forms.Button task_3_6;
        private System.Windows.Forms.Button task_4_6;
        private System.Windows.Forms.Button task_4_5;
        private System.Windows.Forms.Button task_4_4;
        private System.Windows.Forms.Button task_4_3;
        private System.Windows.Forms.Button task_4_2;
        private System.Windows.Forms.Button task_4_1;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Button task_4_7;
        private System.Windows.Forms.Button task_4_8;
    }
}

