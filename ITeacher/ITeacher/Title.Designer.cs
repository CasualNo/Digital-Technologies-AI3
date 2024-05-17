namespace ITeacher
{
    partial class Title
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLvls = new System.Windows.Forms.Button();
            this.btnOpts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Courier New", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(356, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(511, 110);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ITeacher";
            // 
            // btnLvls
            // 
            this.btnLvls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLvls.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvls.Location = new System.Drawing.Point(425, 180);
            this.btnLvls.Name = "btnLvls";
            this.btnLvls.Size = new System.Drawing.Size(374, 68);
            this.btnLvls.TabIndex = 1;
            this.btnLvls.Text = "Level Select";
            this.btnLvls.UseVisualStyleBackColor = true;
            this.btnLvls.Click += new System.EventHandler(this.btnLvls_Click);
            // 
            // btnOpts
            // 
            this.btnOpts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpts.Location = new System.Drawing.Point(425, 270);
            this.btnOpts.Name = "btnOpts";
            this.btnOpts.Size = new System.Drawing.Size(374, 68);
            this.btnOpts.TabIndex = 2;
            this.btnOpts.Text = "Options";
            this.btnOpts.UseVisualStyleBackColor = true;
            this.btnOpts.Click += new System.EventHandler(this.btnOpts_Click);
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 695);
            this.Controls.Add(this.btnOpts);
            this.Controls.Add(this.btnLvls);
            this.Controls.Add(this.lblTitle);
            this.Name = "Title";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLvls;
        private System.Windows.Forms.Button btnOpts;
    }
}

