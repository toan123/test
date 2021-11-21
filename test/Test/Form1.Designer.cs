namespace Test
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
            this.components = new System.ComponentModel.Container();
            this.btn_normal = new System.Windows.Forms.Button();
            this.btn_Optimize = new System.Windows.Forms.Button();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Counter = new System.Windows.Forms.Label();
            this.btn_Other = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_normal
            // 
            this.btn_normal.Location = new System.Drawing.Point(43, 11);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(75, 23);
            this.btn_normal.TabIndex = 0;
            this.btn_normal.Text = "Normal";
            this.btn_normal.UseVisualStyleBackColor = true;
            this.btn_normal.Click += new System.EventHandler(this.btn_normal_Click);
            // 
            // btn_Optimize
            // 
            this.btn_Optimize.Location = new System.Drawing.Point(157, 12);
            this.btn_Optimize.Name = "btn_Optimize";
            this.btn_Optimize.Size = new System.Drawing.Size(75, 23);
            this.btn_Optimize.TabIndex = 1;
            this.btn_Optimize.Text = "Optimize";
            this.btn_Optimize.UseVisualStyleBackColor = true;
            this.btn_Optimize.Click += new System.EventHandler(this.btn_Optimize_Click);
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(133, 55);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.Size = new System.Drawing.Size(291, 435);
            this.dgv_data.TabIndex = 2;
            // 
            // lbl_Counter
            // 
            this.lbl_Counter.AutoSize = true;
            this.lbl_Counter.Location = new System.Drawing.Point(458, 21);
            this.lbl_Counter.Name = "lbl_Counter";
            this.lbl_Counter.Size = new System.Drawing.Size(44, 13);
            this.lbl_Counter.TabIndex = 3;
            this.lbl_Counter.Text = "Counter";
            // 
            // btn_Other
            // 
            this.btn_Other.Location = new System.Drawing.Point(284, 11);
            this.btn_Other.Name = "btn_Other";
            this.btn_Other.Size = new System.Drawing.Size(75, 23);
            this.btn_Other.TabIndex = 4;
            this.btn_Other.Text = "Others";
            this.btn_Other.UseVisualStyleBackColor = true;
            this.btn_Other.Click += new System.EventHandler(this.btn_Other_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 502);
            this.Controls.Add(this.btn_Other);
            this.Controls.Add(this.lbl_Counter);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.btn_Optimize);
            this.Controls.Add(this.btn_normal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Test Optimize";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_normal;
        private System.Windows.Forms.Button btn_Optimize;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Counter;
        private System.Windows.Forms.Button btn_Other;
    }
}

