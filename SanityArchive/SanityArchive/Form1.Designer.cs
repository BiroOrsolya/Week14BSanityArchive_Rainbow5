namespace SanityArchive
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
            this.filesOnDrive = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.path_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filesOnDrive
            // 
            this.filesOnDrive.FormattingEnabled = true;
            this.filesOnDrive.Location = new System.Drawing.Point(13, 96);
            this.filesOnDrive.Name = "filesOnDrive";
            this.filesOnDrive.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.filesOnDrive.Size = new System.Drawing.Size(259, 238);
            this.filesOnDrive.TabIndex = 0;
            this.filesOnDrive.DoubleClick += new System.EventHandler(this.filesOnDrive_DoubleClick);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 43);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 1;
            this.textBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // path_lb
            // 
            this.path_lb.AutoSize = true;
            this.path_lb.Location = new System.Drawing.Point(13, 27);
            this.path_lb.Name = "path_lb";
            this.path_lb.Size = new System.Drawing.Size(29, 13);
            this.path_lb.TabIndex = 3;
            this.path_lb.Text = "Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 346);
            this.Controls.Add(this.path_lb);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.filesOnDrive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox filesOnDrive;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label path_lb;
    }
}

