namespace ITeacher
{
    partial class LvlSelect
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
            this.btnTitle = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOpts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn1_1 = new System.Windows.Forms.Button();
            this.btn1_s = new System.Windows.Forms.Button();
            this.btn1_2 = new System.Windows.Forms.Button();
            this.btn1_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTitle
            // 
            this.btnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F);
            this.btnTitle.Location = new System.Drawing.Point(13, 13);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(139, 57);
            this.btnTitle.TabIndex = 0;
            this.btnTitle.Text = "Title";
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Courier New", 56F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(323, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(577, 85);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Level Select";
            // 
            // btnOpts
            // 
            this.btnOpts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpts.Location = new System.Drawing.Point(1055, 13);
            this.btnOpts.Name = "btnOpts";
            this.btnOpts.Size = new System.Drawing.Size(139, 57);
            this.btnOpts.TabIndex = 2;
            this.btnOpts.Text = "Options";
            this.btnOpts.UseVisualStyleBackColor = true;
            this.btnOpts.Click += new System.EventHandler(this.btnOpts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "1: Introduction";
            // 
            // btn1_1
            // 
            this.btn1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F);
            this.btn1_1.Location = new System.Drawing.Point(195, 180);
            this.btn1_1.Name = "btn1_1";
            this.btn1_1.Size = new System.Drawing.Size(41, 36);
            this.btn1_1.TabIndex = 4;
            this.btn1_1.Text = "1";
            this.btn1_1.UseVisualStyleBackColor = true;
            this.btn1_1.Click += new System.EventHandler(this.btn1_1_Click);
            // 
            // btn1_s
            // 
            this.btn1_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F);
            this.btn1_s.Location = new System.Drawing.Point(531, 226);
            this.btn1_s.Name = "btn1_s";
            this.btn1_s.Size = new System.Drawing.Size(124, 36);
            this.btn1_s.TabIndex = 5;
            this.btn1_s.Text = "Sandbox";
            this.btn1_s.UseVisualStyleBackColor = true;
            this.btn1_s.Click += new System.EventHandler(this.btn1_s_Click);
            // 
            // btn1_2
            // 
            this.btn1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F);
            this.btn1_2.Location = new System.Drawing.Point(260, 180);
            this.btn1_2.Name = "btn1_2";
            this.btn1_2.Size = new System.Drawing.Size(41, 36);
            this.btn1_2.TabIndex = 6;
            this.btn1_2.Text = "2";
            this.btn1_2.UseVisualStyleBackColor = true;
            this.btn1_2.Click += new System.EventHandler(this.btn1_2_Click);
            // 
            // btn1_3
            // 
            this.btn1_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F);
            this.btn1_3.Location = new System.Drawing.Point(321, 180);
            this.btn1_3.Name = "btn1_3";
            this.btn1_3.Size = new System.Drawing.Size(41, 36);
            this.btn1_3.TabIndex = 7;
            this.btn1_3.Text = "3";
            this.btn1_3.UseVisualStyleBackColor = true;
            this.btn1_3.Click += new System.EventHandler(this.btn1_3_Click);
            // 
            // LvlSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 695);
            this.Controls.Add(this.btn1_3);
            this.Controls.Add(this.btn1_2);
            this.Controls.Add(this.btn1_s);
            this.Controls.Add(this.btn1_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpts);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnTitle);
            this.Name = "LvlSelect";
            this.Text = "LvlSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnOpts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1_1;
        private System.Windows.Forms.Button btn1_s;
        private System.Windows.Forms.Button btn1_2;
        private System.Windows.Forms.Button btn1_3;
    }
}