namespace ITeacher
{
    partial class Win
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnLvl = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(182, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 46);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Good Job!";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 48);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.Location = new System.Drawing.Point(212, 80);
            this.lblSub.Margin = new System.Windows.Forms.Padding(0);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(175, 20);
            this.lblSub.TabIndex = 4;
            this.lblSub.Text = "You won with this code:";
            // 
            // lblCode
            // 
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(0, 100);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(584, 200);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Code go her";
            // 
            // btnLvl
            // 
            this.btnLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl.Location = new System.Drawing.Point(100, 320);
            this.btnLvl.Margin = new System.Windows.Forms.Padding(0);
            this.btnLvl.Name = "btnLvl";
            this.btnLvl.Size = new System.Drawing.Size(170, 60);
            this.btnLvl.TabIndex = 6;
            this.btnLvl.Text = "Level Select";
            this.btnLvl.UseVisualStyleBackColor = true;
            this.btnLvl.Click += new System.EventHandler(this.btnLvl_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(330, 320);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(170, 60);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next Level";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 399);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLvl);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Name = "Win";
            this.Text = "Win";
            this.Shown += new System.EventHandler(this.Win_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnLvl;
        private System.Windows.Forms.Button btnNext;
    }
}