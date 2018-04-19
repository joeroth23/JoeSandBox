namespace ScriptRunMan
{
    partial class frmRunScripts
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
            this.txtScriptDir = new System.Windows.Forms.TextBox();
            this.PickSciptDir = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDirPick = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Script Location:";
            // 
            // txtScriptDir
            // 
            this.txtScriptDir.Location = new System.Drawing.Point(128, 44);
            this.txtScriptDir.Name = "txtScriptDir";
            this.txtScriptDir.Size = new System.Drawing.Size(462, 20);
            this.txtScriptDir.TabIndex = 1;
            // 
            // PickSciptDir
            // 
            this.PickSciptDir.HelpRequest += new System.EventHandler(this.PickSciptDir_HelpRequest);
            // 
            // btnDirPick
            // 
            this.btnDirPick.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDirPick.Location = new System.Drawing.Point(606, 42);
            this.btnDirPick.Name = "btnDirPick";
            this.btnDirPick.Size = new System.Drawing.Size(75, 23);
            this.btnDirPick.TabIndex = 2;
            this.btnDirPick.Text = "...";
            this.btnDirPick.UseVisualStyleBackColor = true;
            this.btnDirPick.Click += new System.EventHandler(this.btnDirPick_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(33, 102);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMsg.Size = new System.Drawing.Size(648, 258);
            this.txtMsg.TabIndex = 3;
            this.txtMsg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(451, 380);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 42);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run Scripts";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(581, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 42);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRunScripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 444);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnDirPick);
            this.Controls.Add(this.txtScriptDir);
            this.Controls.Add(this.label1);
            this.Name = "frmRunScripts";
            this.Text = "LPM DB Script Run";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScriptDir;
        private System.Windows.Forms.FolderBrowserDialog PickSciptDir;
        private System.Windows.Forms.Button btnDirPick;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
    }
}

