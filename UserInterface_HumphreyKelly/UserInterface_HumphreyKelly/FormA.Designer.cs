namespace UserInterface_HumphreyKelly
{
    partial class FormA
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
            this.FormAExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.Location = new System.Drawing.Point(18, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form A area";
            // 
            // FormAExitButton
            // 
            this.FormAExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormAExitButton.Location = new System.Drawing.Point(258, 200);
            this.FormAExitButton.Name = "FormAExitButton";
            this.FormAExitButton.Size = new System.Drawing.Size(255, 99);
            this.FormAExitButton.TabIndex = 1;
            this.FormAExitButton.Text = "Exit";
            this.FormAExitButton.UseVisualStyleBackColor = true;
            this.FormAExitButton.Click += new System.EventHandler(this.FormAExitButton_Click);
            // 
            // FormA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FormAExitButton);
            this.Controls.Add(this.label1);
            this.Name = "FormA";
            this.Text = "Form A";
            this.Load += new System.EventHandler(this.FormA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FormAExitButton;
    }
}