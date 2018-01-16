namespace Day02_0700经理评分
{
    partial class FrmAdd
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAssert = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btn_Score = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAssert = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(69, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "员工姓名";
            // 
            // lblAssert
            // 
            this.lblAssert.AutoSize = true;
            this.lblAssert.Location = new System.Drawing.Point(69, 122);
            this.lblAssert.Name = "lblAssert";
            this.lblAssert.Size = new System.Drawing.Size(55, 13);
            this.lblAssert.TabIndex = 0;
            this.lblAssert.Text = "员工评价";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(69, 187);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 13);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "员工评分";
            // 
            // btn_Score
            // 
            this.btn_Score.Location = new System.Drawing.Point(59, 241);
            this.btn_Score.Name = "btn_Score";
            this.btn_Score.Size = new System.Drawing.Size(75, 23);
            this.btn_Score.TabIndex = 2;
            this.btn_Score.Text = "评分";
            this.btn_Score.UseVisualStyleBackColor = true;
            this.btn_Score.Click += new System.EventHandler(this.btn_Score_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(152, 241);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtAssert
            // 
            this.txtAssert.Location = new System.Drawing.Point(152, 122);
            this.txtAssert.Name = "txtAssert";
            this.txtAssert.Size = new System.Drawing.Size(100, 20);
            this.txtAssert.TabIndex = 3;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(152, 187);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 20);
            this.txtScore.TabIndex = 3;
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 378);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAssert);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Score);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblAssert);
            this.Controls.Add(this.lblName);
            this.Name = "FrmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdd";
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAssert;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btn_Score;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAssert;
        private System.Windows.Forms.TextBox txtScore;
    }
}