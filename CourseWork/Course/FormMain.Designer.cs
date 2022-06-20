
namespace Course
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserBtn = new System.Windows.Forms.Button();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserBtn
            // 
            this.UserBtn.Location = new System.Drawing.Point(80, 108);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(194, 42);
            this.UserBtn.TabIndex = 0;
            this.UserBtn.Text = "User";
            this.UserBtn.UseVisualStyleBackColor = true;
            this.UserBtn.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // AdminBtn
            // 
            this.AdminBtn.Location = new System.Drawing.Point(80, 175);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(194, 42);
            this.AdminBtn.TabIndex = 1;
            this.AdminBtn.Text = "Admin";
            this.AdminBtn.UseVisualStyleBackColor = true;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a mode:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminBtn);
            this.Controls.Add(this.UserBtn);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UserBtn;
        private System.Windows.Forms.Button AdminBtn;
        private System.Windows.Forms.Label label1;
    }
}

