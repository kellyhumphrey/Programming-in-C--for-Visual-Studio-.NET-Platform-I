namespace GatesCandyStore_HumphreyKelly
{
    partial class ChocolateForm
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
            this.StaticLabel4 = new System.Windows.Forms.Label();
            this.ChocolateComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.ChocolateNameLabel = new System.Windows.Forms.Label();
            this.ChocolateChoiceLabel = new System.Windows.Forms.Label();
            this.chocolateButton = new System.Windows.Forms.Button();
            this.chocolateQtyComboBox = new System.Windows.Forms.ComboBox();
            this.StaticLabel5 = new System.Windows.Forms.Label();
            this.StaticLabel6 = new System.Windows.Forms.Label();
            this.ExtCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StaticLabel4
            // 
            this.StaticLabel4.AutoSize = true;
            this.StaticLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticLabel4.Location = new System.Drawing.Point(28, 40);
            this.StaticLabel4.Name = "StaticLabel4";
            this.StaticLabel4.Size = new System.Drawing.Size(469, 29);
            this.StaticLabel4.TabIndex = 0;
            this.StaticLabel4.Text = "Pick the chocolate bar that you want to buy:";
            this.StaticLabel4.Click += new System.EventHandler(this.StaticLabel4_Click);
            // 
            // ChocolateComboBox
            // 
            this.ChocolateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChocolateComboBox.FormattingEnabled = true;
            this.ChocolateComboBox.Location = new System.Drawing.Point(33, 95);
            this.ChocolateComboBox.Name = "ChocolateComboBox";
            this.ChocolateComboBox.Size = new System.Drawing.Size(460, 37);
            this.ChocolateComboBox.TabIndex = 1;
            this.ChocolateComboBox.SelectedIndexChanged += new System.EventHandler(this.ChocolateComboBox_SelectedIndexChanged);
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(66, 175);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(0, 29);
            this.CustomerNameLabel.TabIndex = 2;
            // 
            // ChocolateNameLabel
            // 
            this.ChocolateNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChocolateNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChocolateNameLabel.Location = new System.Drawing.Point(34, 142);
            this.ChocolateNameLabel.Name = "ChocolateNameLabel";
            this.ChocolateNameLabel.Size = new System.Drawing.Size(361, 37);
            this.ChocolateNameLabel.TabIndex = 3;
            this.ChocolateNameLabel.Click += new System.EventHandler(this.ChocolateNameLabel_Click);
            // 
            // ChocolateChoiceLabel
            // 
            this.ChocolateChoiceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChocolateChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChocolateChoiceLabel.Location = new System.Drawing.Point(401, 142);
            this.ChocolateChoiceLabel.Name = "ChocolateChoiceLabel";
            this.ChocolateChoiceLabel.Size = new System.Drawing.Size(315, 37);
            this.ChocolateChoiceLabel.TabIndex = 4;
            this.ChocolateChoiceLabel.Click += new System.EventHandler(this.ChocolateChoiceLabel_Click);
            // 
            // chocolateButton
            // 
            this.chocolateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chocolateButton.Location = new System.Drawing.Point(298, 335);
            this.chocolateButton.Name = "chocolateButton";
            this.chocolateButton.Size = new System.Drawing.Size(212, 58);
            this.chocolateButton.TabIndex = 5;
            this.chocolateButton.Text = "Return to Main";
            this.chocolateButton.UseVisualStyleBackColor = true;
            this.chocolateButton.Click += new System.EventHandler(this.chocolateButton_Click);
            // 
            // chocolateQtyComboBox
            // 
            this.chocolateQtyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chocolateQtyComboBox.FormattingEnabled = true;
            this.chocolateQtyComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.chocolateQtyComboBox.Location = new System.Drawing.Point(34, 236);
            this.chocolateQtyComboBox.Name = "chocolateQtyComboBox";
            this.chocolateQtyComboBox.Size = new System.Drawing.Size(227, 37);
            this.chocolateQtyComboBox.TabIndex = 6;
            this.chocolateQtyComboBox.SelectedIndexChanged += new System.EventHandler(this.chocolateQtyComboBox_SelectedIndexChanged);
            // 
            // StaticLabel5
            // 
            this.StaticLabel5.AutoSize = true;
            this.StaticLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticLabel5.Location = new System.Drawing.Point(29, 194);
            this.StaticLabel5.Name = "StaticLabel5";
            this.StaticLabel5.Size = new System.Drawing.Size(243, 29);
            this.StaticLabel5.TabIndex = 7;
            this.StaticLabel5.Text = "Choose your quantity:";
            // 
            // StaticLabel6
            // 
            this.StaticLabel6.AutoSize = true;
            this.StaticLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticLabel6.Location = new System.Drawing.Point(349, 194);
            this.StaticLabel6.Name = "StaticLabel6";
            this.StaticLabel6.Size = new System.Drawing.Size(176, 29);
            this.StaticLabel6.TabIndex = 8;
            this.StaticLabel6.Text = "Extended Cost:";
            // 
            // ExtCostLabel
            // 
            this.ExtCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ExtCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtCostLabel.Location = new System.Drawing.Point(349, 236);
            this.ExtCostLabel.Name = "ExtCostLabel";
            this.ExtCostLabel.Size = new System.Drawing.Size(264, 44);
            this.ExtCostLabel.TabIndex = 9;
            // 
            // ChocolateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExtCostLabel);
            this.Controls.Add(this.StaticLabel6);
            this.Controls.Add(this.StaticLabel5);
            this.Controls.Add(this.chocolateQtyComboBox);
            this.Controls.Add(this.chocolateButton);
            this.Controls.Add(this.ChocolateChoiceLabel);
            this.Controls.Add(this.ChocolateNameLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.ChocolateComboBox);
            this.Controls.Add(this.StaticLabel4);
            this.Name = "ChocolateForm";
            this.Text = "Chocolate";
            this.Load += new System.EventHandler(this.ChocolateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StaticLabel4;
        private System.Windows.Forms.ComboBox ChocolateComboBox;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label ChocolateNameLabel;
        private System.Windows.Forms.Label ChocolateChoiceLabel;
        private System.Windows.Forms.Button chocolateButton;
        private System.Windows.Forms.ComboBox chocolateQtyComboBox;
        private System.Windows.Forms.Label StaticLabel5;
        private System.Windows.Forms.Label StaticLabel6;
        private System.Windows.Forms.Label ExtCostLabel;
    }
}