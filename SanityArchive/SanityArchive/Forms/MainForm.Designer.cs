namespace SanityArchive
{
    namespace Forms
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
                this.extractButton = new System.Windows.Forms.Button();
                this.encriptButton = new System.Windows.Forms.Button();
                this.decriptButton = new System.Windows.Forms.Button();
                this.button1 = new System.Windows.Forms.Button();
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
                this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
                // 
                // moveButton
                // 
                this.moveButton.Location = new System.Drawing.Point(12, 387);
                this.moveButton.Name = "moveButton";
                this.moveButton.Size = new System.Drawing.Size(75, 23);
                this.moveButton.TabIndex = 5;
                this.moveButton.Text = "Move";
                this.moveButton.UseVisualStyleBackColor = true;
                this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
                // 
                // compressButton
                // 
                this.compressButton.Location = new System.Drawing.Point(104, 352);
                this.compressButton.Name = "compressButton";
                this.compressButton.Size = new System.Drawing.Size(75, 23);
                this.compressButton.TabIndex = 6;
                this.compressButton.Text = "Compress";
                this.compressButton.UseVisualStyleBackColor = true;
                this.compressButton.Click += new System.EventHandler(this.compressButton_Click);
                // 
                // extractButton
                // 
                this.extractButton.Location = new System.Drawing.Point(104, 387);
                this.extractButton.Name = "extractButton";
                this.extractButton.Size = new System.Drawing.Size(75, 23);
                this.extractButton.TabIndex = 7;
                this.extractButton.Text = "Extract";
                this.extractButton.UseVisualStyleBackColor = true;
                this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
                // 
                // encriptButton
                // 
                this.encriptButton.Location = new System.Drawing.Point(197, 352);
                this.encriptButton.Name = "encriptButton";
                this.encriptButton.Size = new System.Drawing.Size(75, 23);
                this.encriptButton.TabIndex = 8;
                this.encriptButton.Text = "Encript";
                this.encriptButton.UseVisualStyleBackColor = true;
                this.encriptButton.Click += new System.EventHandler(this.encryptButton_Click);
                // 
                // decriptButton
                // 
                this.decriptButton.Location = new System.Drawing.Point(197, 387);
                this.decriptButton.Name = "decriptButton";
                this.decriptButton.Size = new System.Drawing.Size(75, 23);
                this.decriptButton.TabIndex = 9;
                this.decriptButton.Text = "Decript";
                this.decriptButton.UseVisualStyleBackColor = true;
                this.decriptButton.Click += new System.EventHandler(this.decryptButton_Click);
                // 
                // button1
                // 
                this.button1.Location = new System.Drawing.Point(12, 426);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(75, 23);
                this.button1.TabIndex = 10;
                this.button1.Text = "CalcSpace";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Click += new System.EventHandler(this.calcSpaceButton_Click);
                // 
                // MainForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(284, 471);
                this.Controls.Add(this.button1);
                this.Controls.Add(this.decriptButton);
                this.Controls.Add(this.encriptButton);
                this.Controls.Add(this.extractButton);
                this.Controls.Add(this.compressButton);
                this.Controls.Add(this.moveButton);
                this.Controls.Add(this.copyButton);
                this.Name = "MainForm";
                this.Text = "Sanity Archive";
                this.Controls.SetChildIndex(this.filesOnDrive, 0);
                this.Controls.SetChildIndex(this.textBox, 0);
                this.Controls.SetChildIndex(this.copyButton, 0);
                this.Controls.SetChildIndex(this.moveButton, 0);
                this.Controls.SetChildIndex(this.compressButton, 0);
                this.Controls.SetChildIndex(this.extractButton, 0);
                this.Controls.SetChildIndex(this.encriptButton, 0);
                this.Controls.SetChildIndex(this.decriptButton, 0);
                this.Controls.SetChildIndex(this.button1, 0);
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Button copyButton;
            private System.Windows.Forms.Button moveButton;
            private System.Windows.Forms.Button compressButton;
            private System.Windows.Forms.Button extractButton;
            private System.Windows.Forms.Button encriptButton;
            private System.Windows.Forms.Button decriptButton;
            private System.Windows.Forms.Button button1;
        } 
    }
}