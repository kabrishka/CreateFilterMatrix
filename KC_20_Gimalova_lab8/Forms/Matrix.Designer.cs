namespace KC_20_Gimalova_lab8.Forms
{
    partial class Matrix
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
            this.trackRows = new System.Windows.Forms.TrackBar();
            this.numericK = new System.Windows.Forms.NumericUpDown();
            this.trackColumns = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // trackRows
            // 
            this.trackRows.LargeChange = 1;
            this.trackRows.Location = new System.Drawing.Point(46, 66);
            this.trackRows.Minimum = 1;
            this.trackRows.Name = "trackRows";
            this.trackRows.Size = new System.Drawing.Size(293, 56);
            this.trackRows.TabIndex = 0;
            this.trackRows.Value = 1;
            this.trackRows.Scroll += new System.EventHandler(this.trackRows_Scroll);
            // 
            // numericK
            // 
            this.numericK.DecimalPlaces = 1;
            this.numericK.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericK.Location = new System.Drawing.Point(66, 265);
            this.numericK.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            65536});
            this.numericK.Minimum = new decimal(new int[] {
            55,
            0,
            0,
            -2147418112});
            this.numericK.Name = "numericK";
            this.numericK.Size = new System.Drawing.Size(120, 22);
            this.numericK.TabIndex = 2;
            this.numericK.ValueChanged += new System.EventHandler(this.numericK_ValueChanged);
            // 
            // trackColumns
            // 
            this.trackColumns.LargeChange = 1;
            this.trackColumns.Location = new System.Drawing.Point(46, 167);
            this.trackColumns.Minimum = 1;
            this.trackColumns.Name = "trackColumns";
            this.trackColumns.Size = new System.Drawing.Size(293, 56);
            this.trackColumns.TabIndex = 3;
            this.trackColumns.Value = 1;
            this.trackColumns.Scroll += new System.EventHandler(this.trackColumns_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(204)))), ((int)(((byte)(208)))));
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "N (число строк)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(204)))), ((int)(((byte)(208)))));
            this.label2.Location = new System.Drawing.Point(62, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "M (число столбцов)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(204)))), ((int)(((byte)(208)))));
            this.label3.Location = new System.Drawing.Point(62, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "k (константа)";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(204)))), ((int)(((byte)(208)))));
            this.lblN.Location = new System.Drawing.Point(345, 66);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(17, 24);
            this.lblN.TabIndex = 7;
            this.lblN.Text = "1";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(204)))), ((int)(((byte)(208)))));
            this.lblM.Location = new System.Drawing.Point(345, 167);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(17, 24);
            this.lblM.TabIndex = 8;
            this.lblM.Text = "1";
            // 
            // Matrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(429, 399);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackColumns);
            this.Controls.Add(this.numericK);
            this.Controls.Add(this.trackRows);
            this.Name = "Matrix";
            this.Text = "Matrix";
            ((System.ComponentModel.ISupportInitialize)(this.trackRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackRows;
        private System.Windows.Forms.NumericUpDown numericK;
        private System.Windows.Forms.TrackBar trackColumns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblM;
    }
}