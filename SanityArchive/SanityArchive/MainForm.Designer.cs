namespace SanityArchive
{
    partial class MainForm
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
            this.copyButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.compressButton = new System.Windows.Forms.Button();
            this.decompressButton = new System.Windows.Forms.Button();
            this.encriptButton = new System.Windows.Forms.Button();
            this.decriptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(12, 352);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 4;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(12, 387);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(75, 23);
            this.moveButton.TabIndex = 5;
            this.moveButton.Text = "Move";
            this.moveButton.UseVisualStyleBackColor = true;
            // 
            // compressButton
            // 
            this.compressButton.Location = new System.Drawing.Point(104, 352);
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(75, 23);
            this.compressButton.TabIndex = 6;
            this.compressButton.Text = "Compress";
            this.compressButton.UseVisualStyleBackColor = true;
            // 
            // decompressButton
            // 
            this.decompressButton.Location = new System.Drawing.Point(104, 387);
            this.decompressButton.Name = "decompressButton";
            this.decompressButton.Size = new System.Drawing.Size(75, 23);
            this.decompressButton.TabIndex = 7;
            this.decompressButton.Text = "Decompress";
            this.decompressButton.UseVisualStyleBackColor = true;
            // 
            // encriptButton
            // 
            this.encriptButton.Location = new System.Drawing.Point(197, 352);
            this.encriptButton.Name = "encriptButton";
            this.encriptButton.Size = new System.Drawing.Size(75, 23);
            this.encriptButton.TabIndex = 8;
            this.encriptButton.Text = "Encript";
            this.encriptButton.UseVisualStyleBackColor = true;
            // 
            // decriptButton
            // 
            this.decriptButton.Location = new System.Drawing.Point(197, 387);
            this.decriptButton.Name = "decriptButton";
            this.decriptButton.Size = new System.Drawing.Size(75, 23);
            this.decriptButton.TabIndex = 9;
            this.decriptButton.Text = "Decript";
            this.decriptButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 422);
            this.Controls.Add(this.decriptButton);
            this.Controls.Add(this.encriptButton);
            this.Controls.Add(this.decompressButton);
            this.Controls.Add(this.compressButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.copyButton);
            this.Name = "MainForm";
            this.Text = "Sanity Archive";
            this.Controls.SetChildIndex(this.copyButton, 0);
            this.Controls.SetChildIndex(this.moveButton, 0);
            this.Controls.SetChildIndex(this.compressButton, 0);
            this.Controls.SetChildIndex(this.decompressButton, 0);
            this.Controls.SetChildIndex(this.encriptButton, 0);
            this.Controls.SetChildIndex(this.decriptButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button compressButton;
        private System.Windows.Forms.Button decompressButton;
        private System.Windows.Forms.Button encriptButton;
        private System.Windows.Forms.Button decriptButton;
    }
}