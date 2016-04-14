namespace SanityArchive
{
    partial class DestinationFileDialog
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
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(132, 43);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(140, 20);
            this.fileNameBox.TabIndex = 6;
            this.fileNameBox.Leave += new System.EventHandler(this.fileNameBox_Leave);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(129, 27);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(55, 13);
            this.fileNameLabel.TabIndex = 7;
            this.fileNameLabel.Text = "File name:";
            // 
            // DestinationFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 386);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.fileNameBox);
            this.Name = "DestinationFileDialog";
            this.Text = "DestinationFileDialog";
            this.Controls.SetChildIndex(this.fileNameBox, 0);
            this.Controls.SetChildIndex(this.fileNameLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.Label fileNameLabel;
    }
}