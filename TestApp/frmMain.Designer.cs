namespace TestApp
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.chkCheck1 = new System.Windows.Forms.CheckBox();
            this.chkCheck2 = new System.Windows.Forms.CheckBox();
            this.optOption1 = new System.Windows.Forms.RadioButton();
            this.optOption2 = new System.Windows.Forms.RadioButton();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(15, 25);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(315, 20);
            this.txtPath.TabIndex = 1;
            // 
            // chkCheck1
            // 
            this.chkCheck1.AutoSize = true;
            this.chkCheck1.Location = new System.Drawing.Point(15, 64);
            this.chkCheck1.Name = "chkCheck1";
            this.chkCheck1.Size = new System.Drawing.Size(66, 17);
            this.chkCheck1.TabIndex = 2;
            this.chkCheck1.Text = "Check 1";
            this.chkCheck1.UseVisualStyleBackColor = true;
            // 
            // chkCheck2
            // 
            this.chkCheck2.AutoSize = true;
            this.chkCheck2.Location = new System.Drawing.Point(15, 87);
            this.chkCheck2.Name = "chkCheck2";
            this.chkCheck2.Size = new System.Drawing.Size(66, 17);
            this.chkCheck2.TabIndex = 3;
            this.chkCheck2.Text = "Check 2";
            this.chkCheck2.UseVisualStyleBackColor = true;
            // 
            // optOption1
            // 
            this.optOption1.AutoSize = true;
            this.optOption1.Location = new System.Drawing.Point(15, 110);
            this.optOption1.Name = "optOption1";
            this.optOption1.Size = new System.Drawing.Size(65, 17);
            this.optOption1.TabIndex = 4;
            this.optOption1.TabStop = true;
            this.optOption1.Text = "Option 1";
            this.optOption1.UseVisualStyleBackColor = true;
            // 
            // optOption2
            // 
            this.optOption2.AutoSize = true;
            this.optOption2.Location = new System.Drawing.Point(15, 133);
            this.optOption2.Name = "optOption2";
            this.optOption2.Size = new System.Drawing.Size(65, 17);
            this.optOption2.TabIndex = 5;
            this.optOption2.TabStop = true;
            this.optOption2.Text = "Option 2";
            this.optOption2.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(15, 156);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 6;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(96, 156);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 7;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(346, 25);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(425, 154);
            this.txtLog.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 649);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.optOption2);
            this.Controls.Add(this.optOption1);
            this.Controls.Add(this.chkCheck2);
            this.Controls.Add(this.chkCheck1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Test App";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.CheckBox chkCheck1;
        private System.Windows.Forms.CheckBox chkCheck2;
        private System.Windows.Forms.RadioButton optOption1;
        private System.Windows.Forms.RadioButton optOption2;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.TextBox txtLog;
    }
}

