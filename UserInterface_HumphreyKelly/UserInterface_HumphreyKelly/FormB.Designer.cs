namespace UserInterface_HumphreyKelly
{
    partial class FormB
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.RightClickMeLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.callMessageBox1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callMessageBox2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormBExitButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form B area";
            // 
            // RightClickMeLabel
            // 
            this.RightClickMeLabel.AutoSize = true;
            this.RightClickMeLabel.ContextMenuStrip = this.contextMenuStrip1;
            this.RightClickMeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightClickMeLabel.Location = new System.Drawing.Point(40, 176);
            this.RightClickMeLabel.Name = "RightClickMeLabel";
            this.RightClickMeLabel.Size = new System.Drawing.Size(264, 44);
            this.RightClickMeLabel.TabIndex = 1;
            this.RightClickMeLabel.Text = "Right-Click Me!";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callMessageBox1ToolStripMenuItem,
            this.callMessageBox2ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(232, 68);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // callMessageBox1ToolStripMenuItem
            // 
            this.callMessageBox1ToolStripMenuItem.Name = "callMessageBox1ToolStripMenuItem";
            this.callMessageBox1ToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.callMessageBox1ToolStripMenuItem.Text = "Call MessageBox 1";
            this.callMessageBox1ToolStripMenuItem.Click += new System.EventHandler(this.callMessageBox1ToolStripMenuItem_Click);
            // 
            // callMessageBox2ToolStripMenuItem
            // 
            this.callMessageBox2ToolStripMenuItem.Name = "callMessageBox2ToolStripMenuItem";
            this.callMessageBox2ToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.callMessageBox2ToolStripMenuItem.Text = "Call MessageBox 2";
            this.callMessageBox2ToolStripMenuItem.Click += new System.EventHandler(this.callMessageBox2ToolStripMenuItem_Click);
            // 
            // FormBExitButton
            // 
            this.FormBExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBExitButton.Location = new System.Drawing.Point(270, 259);
            this.FormBExitButton.Name = "FormBExitButton";
            this.FormBExitButton.Size = new System.Drawing.Size(255, 109);
            this.FormBExitButton.TabIndex = 3;
            this.FormBExitButton.Text = "Exit";
            this.FormBExitButton.UseVisualStyleBackColor = true;
            this.FormBExitButton.Click += new System.EventHandler(this.FormBExitButton_Click);
            // 
            // FormB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FormBExitButton);
            this.Controls.Add(this.RightClickMeLabel);
            this.Controls.Add(this.label1);
            this.Name = "FormB";
            this.Text = "Form B";
            this.Load += new System.EventHandler(this.FormB_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RightClickMeLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem callMessageBox1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callMessageBox2ToolStripMenuItem;
        private System.Windows.Forms.Button FormBExitButton;
    }
}