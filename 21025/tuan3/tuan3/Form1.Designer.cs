namespace tuan3
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(85, 128);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(107, 31);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Account";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(75, 218);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(117, 31);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Password";
            // 
            // t2
            // 
            this.t2.BackColor = System.Drawing.SystemColors.Info;
            this.t2.Location = new System.Drawing.Point(260, 211);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(278, 38);
            this.t2.TabIndex = 3;
            // 
            // t1
            // 
            this.t1.BackColor = System.Drawing.SystemColors.Info;
            this.t1.Location = new System.Drawing.Point(260, 128);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(278, 38);
            this.t1.TabIndex = 4;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.LawnGreen;
            this.b1.Location = new System.Drawing.Point(588, 123);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(105, 40);
            this.b1.TabIndex = 5;
            this.b1.Text = "Sign in";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 346);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.Name = "Form1";
            this.Text = "App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox t2;
        public System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Button b1;
    }
}

