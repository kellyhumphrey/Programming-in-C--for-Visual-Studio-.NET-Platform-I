namespace UserInterface_HumphreyKelly
{
    partial class Display
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callAMessageBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.processToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAFormToolStripMenuItem,
            this.callAMessageBoxToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openAFormToolStripMenuItem
            // 
            this.openAFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formAToolStripMenuItem,
            this.formBToolStripMenuItem});
            this.openAFormToolStripMenuItem.Name = "openAFormToolStripMenuItem";
            this.openAFormToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openAFormToolStripMenuItem.Text = "Open a form";
            // 
            // callAMessageBoxToolStripMenuItem
            // 
            this.callAMessageBoxToolStripMenuItem.Name = "callAMessageBoxToolStripMenuItem";
            this.callAMessageBoxToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.callAMessageBoxToolStripMenuItem.Text = "Call a MessageBox";
            this.callAMessageBoxToolStripMenuItem.Click += new System.EventHandler(this.callAMessageBoxToolStripMenuItem_Click);
            // 
            // formAToolStripMenuItem
            // 
            this.formAToolStripMenuItem.Name = "formAToolStripMenuItem";
            this.formAToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.formAToolStripMenuItem.Text = "Form A";
            this.formAToolStripMenuItem.Click += new System.EventHandler(this.formAToolStripMenuItem_Click);
            // 
            // formBToolStripMenuItem
            // 
            this.formBToolStripMenuItem.Name = "formBToolStripMenuItem";
            this.formBToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.formBToolStripMenuItem.Text = "Form B";
            this.formBToolStripMenuItem.Click += new System.EventHandler(this.formBToolStripMenuItem_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Display";
            this.Text = "User Interface";
            this.Load += new System.EventHandler(this.Display_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callAMessageBoxToolStripMenuItem;
    }
}

