namespace GatesCandyStore_HumphreyKelly
{
    partial class GumForm
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
            this.StaticLabel5 = new System.Windows.Forms.Label();
            this.candyComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.choiceLabel = new System.Windows.Forms.Label();
            this.StaticLabel6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.extendedCostLabel = new System.Windows.Forms.Label();
            this.quantityComboBox = new System.Windows.Forms.ComboBox();
            this.chocolateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StaticLabel5
            // 
            this.StaticLabel5.AutoSize = true;
            this.StaticLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticLabel5.Location = new System.Drawing.Point(19, 39);
            this.StaticLabel5.Name = "StaticLabel5";
            this.StaticLabel5.Size = new System.Drawing.Size(417, 29);
            this.StaticLabel5.TabIndex = 0;
            this.StaticLabel5.Text = "Pick the flavor of gum you want to buy:";
            // 
            // candyComboBox
            // 
            this.candyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candyComboBox.FormattingEnabled = true;
            this.candyComboBox.Location = new System.Drawing.Point(24, 79);
            this.candyComboBox.Name = "candyComboBox";
            this.candyComboBox.Size = new System.Drawing.Size(359, 37);
            this.candyComboBox.TabIndex = 1;
            this.candyComboBox.SelectedIndexChanged += new System.EventHandler(this.candyComboBox_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(24, 126);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(359, 42);
            this.nameLabel.TabIndex = 2;
            // 
            // choiceLabel
            // 
            this.choiceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.choiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceLabel.Location = new System.Drawing.Point(389, 126);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(359, 42);
            this.choiceLabel.TabIndex = 3;
            // 
            // StaticLabel6
            // 
            this.StaticLabel6.AutoSize = true;
            this.StaticLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticLabel6.Location = new System.Drawing.Point(346, 193);
            this.StaticLabel6.Name = "StaticLabel6";
            this.StaticLabel6.Size = new System.Drawing.Size(176, 29);
            this.StaticLabel6.TabIndex = 10;
            this.StaticLabel6.Text = "Extended Cost:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose your quantity:";
            // 
            // extendedCostLabel
            // 
            this.extendedCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.extendedCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendedCostLabel.Location = new System.Drawing.Point(351, 238);
            this.extendedCostLabel.Name = "extendedCostLabel";
            this.extendedCostLabel.Size = new System.Drawing.Size(264, 44);
            this.extendedCostLabel.TabIndex = 13;
            // 
            // quantityComboBox
            // 
            this.quantityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityComboBox.FormattingEnabled = true;
            this.quantityComboBox.Items.AddRange(new object[] {
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
            this.quantityComboBox.Location = new System.Drawing.Point(36, 238);
            this.quantityComboBox.Name = "quantityComboBox";
            this.quantityComboBox.Size = new System.Drawing.Size(227, 37);
            this.quantityComboBox.TabIndex = 12;
            this.quantityComboBox.SelectedIndexChanged += new System.EventHandler(this.quantityComboBox_SelectedIndexChanged);
            // 
            // chocolateButton
            // 
            this.chocolateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chocolateButton.Location = new System.Drawing.Point(285, 334);
            this.chocolateButton.Name = "chocolateButton";
            this.chocolateButton.Size = new System.Drawing.Size(212, 58);
            this.chocolateButton.TabIndex = 11;
            this.chocolateButton.Text = "Return to Main";
            this.chocolateButton.UseVisualStyleBackColor = true;
            this.chocolateButton.Click += new System.EventHandler(this.chocolateButton_Click);
            // 
            // GumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.extendedCostLabel);
            this.Controls.Add(this.quantityComboBox);
            this.Controls.Add(this.chocolateButton);
            this.Controls.Add(this.StaticLabel6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choiceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.candyComboBox);
            this.Controls.Add(this.StaticLabel5);
            this.Name = "GumForm";
            this.Text = "Gum";
            this.Load += new System.EventHandler(this.Gum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StaticLabel5;
        private System.Windows.Forms.ComboBox candyComboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label choiceLabel;
        private System.Windows.Forms.Label StaticLabel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label extendedCostLabel;
        private System.Windows.Forms.ComboBox quantityComboBox;
        private System.Windows.Forms.Button chocolateButton;
    }
}