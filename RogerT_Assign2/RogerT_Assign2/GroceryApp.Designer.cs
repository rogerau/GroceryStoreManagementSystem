
namespace RogerT_Assign2
{
    partial class GroceryAppForm
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
            this.GroceryListBox = new System.Windows.Forms.ListBox();
            this.LDGroupBox = new System.Windows.Forms.GroupBox();
            this.LDButton = new System.Windows.Forms.Button();
            this.UDGroupBox = new System.Windows.Forms.GroupBox();
            this.SGButton = new System.Windows.Forms.Button();
            this.UQRButton = new System.Windows.Forms.Button();
            this.DGButton = new System.Windows.Forms.Button();
            this.UQRLabel = new System.Windows.Forms.Label();
            this.UQRTextBox = new System.Windows.Forms.TextBox();
            this.UQSTextBox = new System.Windows.Forms.TextBox();
            this.UQSLabel = new System.Windows.Forms.Label();
            this.UQSButton = new System.Windows.Forms.Button();
            this.SDGroupBox = new System.Windows.Forms.GroupBox();
            this.SRRButton = new System.Windows.Forms.Button();
            this.SSRButton = new System.Windows.Forms.Button();
            this.SDButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LDGroupBox.SuspendLayout();
            this.UDGroupBox.SuspendLayout();
            this.SDGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroceryListBox
            // 
            this.GroceryListBox.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroceryListBox.FormattingEnabled = true;
            this.GroceryListBox.ItemHeight = 14;
            this.GroceryListBox.Location = new System.Drawing.Point(31, 71);
            this.GroceryListBox.Name = "GroceryListBox";
            this.GroceryListBox.Size = new System.Drawing.Size(1089, 200);
            this.GroceryListBox.TabIndex = 0;
            this.GroceryListBox.SelectedIndexChanged += new System.EventHandler(this.GroceryListBox_SelectedIndexChanged);
            // 
            // LDGroupBox
            // 
            this.LDGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LDGroupBox.Controls.Add(this.LDButton);
            this.LDGroupBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LDGroupBox.Location = new System.Drawing.Point(62, 301);
            this.LDGroupBox.Name = "LDGroupBox";
            this.LDGroupBox.Size = new System.Drawing.Size(202, 114);
            this.LDGroupBox.TabIndex = 1;
            this.LDGroupBox.TabStop = false;
            this.LDGroupBox.Text = "Load Data";
            // 
            // LDButton
            // 
            this.LDButton.AutoSize = true;
            this.LDButton.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LDButton.Location = new System.Drawing.Point(22, 38);
            this.LDButton.Name = "LDButton";
            this.LDButton.Size = new System.Drawing.Size(154, 44);
            this.LDButton.TabIndex = 0;
            this.LDButton.Text = "Load Grocery Data";
            this.LDButton.UseVisualStyleBackColor = true;
            this.LDButton.Click += new System.EventHandler(this.LDButton_Click);
            // 
            // UDGroupBox
            // 
            this.UDGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UDGroupBox.Controls.Add(this.SGButton);
            this.UDGroupBox.Controls.Add(this.UQRButton);
            this.UDGroupBox.Controls.Add(this.DGButton);
            this.UDGroupBox.Controls.Add(this.UQRLabel);
            this.UDGroupBox.Controls.Add(this.UQRTextBox);
            this.UDGroupBox.Controls.Add(this.UQSTextBox);
            this.UDGroupBox.Controls.Add(this.UQSLabel);
            this.UDGroupBox.Controls.Add(this.UQSButton);
            this.UDGroupBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UDGroupBox.Location = new System.Drawing.Point(290, 301);
            this.UDGroupBox.Name = "UDGroupBox";
            this.UDGroupBox.Size = new System.Drawing.Size(573, 151);
            this.UDGroupBox.TabIndex = 2;
            this.UDGroupBox.TabStop = false;
            this.UDGroupBox.Text = "Update Data";
            // 
            // SGButton
            // 
            this.SGButton.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SGButton.Location = new System.Drawing.Point(332, 106);
            this.SGButton.Name = "SGButton";
            this.SGButton.Size = new System.Drawing.Size(166, 39);
            this.SGButton.TabIndex = 7;
            this.SGButton.Text = "Sort Items Based on Sales";
            this.SGButton.UseVisualStyleBackColor = true;
            this.SGButton.Click += new System.EventHandler(this.SGButton_Click);
            // 
            // UQRButton
            // 
            this.UQRButton.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UQRButton.Location = new System.Drawing.Point(332, 48);
            this.UQRButton.Name = "UQRButton";
            this.UQRButton.Size = new System.Drawing.Size(166, 49);
            this.UQRButton.TabIndex = 6;
            this.UQRButton.Text = "Update Restocked Qty For Selected Item";
            this.UQRButton.UseVisualStyleBackColor = true;
            this.UQRButton.Click += new System.EventHandler(this.UQRButton_Click);
            // 
            // DGButton
            // 
            this.DGButton.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DGButton.Location = new System.Drawing.Point(84, 97);
            this.DGButton.Name = "DGButton";
            this.DGButton.Size = new System.Drawing.Size(146, 48);
            this.DGButton.TabIndex = 5;
            this.DGButton.Text = "Delete Selected Grocery Item";
            this.DGButton.UseVisualStyleBackColor = true;
            this.DGButton.Click += new System.EventHandler(this.DGButton_Click);
            // 
            // UQRLabel
            // 
            this.UQRLabel.AutoSize = true;
            this.UQRLabel.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UQRLabel.Location = new System.Drawing.Point(266, 28);
            this.UQRLabel.Name = "UQRLabel";
            this.UQRLabel.Size = new System.Drawing.Size(140, 15);
            this.UQRLabel.TabIndex = 4;
            this.UQRLabel.Text = "Quantity Restocked:";
            // 
            // UQRTextBox
            // 
            this.UQRTextBox.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UQRTextBox.Location = new System.Drawing.Point(412, 23);
            this.UQRTextBox.Name = "UQRTextBox";
            this.UQRTextBox.Size = new System.Drawing.Size(125, 22);
            this.UQRTextBox.TabIndex = 3;
            // 
            // UQSTextBox
            // 
            this.UQSTextBox.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UQSTextBox.Location = new System.Drawing.Point(135, 25);
            this.UQSTextBox.Name = "UQSTextBox";
            this.UQSTextBox.Size = new System.Drawing.Size(125, 22);
            this.UQSTextBox.TabIndex = 2;
            // 
            // UQSLabel
            // 
            this.UQSLabel.AutoSize = true;
            this.UQSLabel.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UQSLabel.Location = new System.Drawing.Point(24, 28);
            this.UQSLabel.Name = "UQSLabel";
            this.UQSLabel.Size = new System.Drawing.Size(105, 15);
            this.UQSLabel.TabIndex = 1;
            this.UQSLabel.Text = "Quantity Sold:";
            // 
            // UQSButton
            // 
            this.UQSButton.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UQSButton.Location = new System.Drawing.Point(84, 53);
            this.UQSButton.Name = "UQSButton";
            this.UQSButton.Size = new System.Drawing.Size(146, 38);
            this.UQSButton.TabIndex = 0;
            this.UQSButton.Text = "Update Sold Qty For Selected Item";
            this.UQSButton.UseVisualStyleBackColor = true;
            this.UQSButton.Click += new System.EventHandler(this.UQSButton_Click);
            // 
            // SDGroupBox
            // 
            this.SDGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SDGroupBox.Controls.Add(this.SRRButton);
            this.SDGroupBox.Controls.Add(this.SSRButton);
            this.SDGroupBox.Controls.Add(this.SDButton);
            this.SDGroupBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SDGroupBox.Location = new System.Drawing.Point(891, 301);
            this.SDGroupBox.Name = "SDGroupBox";
            this.SDGroupBox.Size = new System.Drawing.Size(216, 155);
            this.SDGroupBox.TabIndex = 3;
            this.SDGroupBox.TabStop = false;
            this.SDGroupBox.Text = "Save Data";
            // 
            // SRRButton
            // 
            this.SRRButton.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SRRButton.Location = new System.Drawing.Point(26, 100);
            this.SRRButton.Name = "SRRButton";
            this.SRRButton.Size = new System.Drawing.Size(150, 45);
            this.SRRButton.TabIndex = 2;
            this.SRRButton.Text = "Save Restock Needs Report";
            this.SRRButton.UseVisualStyleBackColor = true;
            this.SRRButton.Click += new System.EventHandler(this.SRRButton_Click);
            // 
            // SSRButton
            // 
            this.SSRButton.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SSRButton.Location = new System.Drawing.Point(26, 62);
            this.SSRButton.Name = "SSRButton";
            this.SSRButton.Size = new System.Drawing.Size(150, 29);
            this.SSRButton.TabIndex = 1;
            this.SSRButton.Text = "Save Sales Report";
            this.SSRButton.UseVisualStyleBackColor = true;
            this.SSRButton.Click += new System.EventHandler(this.SSRButton_Click);
            // 
            // SDButton
            // 
            this.SDButton.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SDButton.Location = new System.Drawing.Point(26, 23);
            this.SDButton.Name = "SDButton";
            this.SDButton.Size = new System.Drawing.Size(150, 29);
            this.SDButton.TabIndex = 0;
            this.SDButton.Text = "Save Grocery Data";
            this.SDButton.UseVisualStyleBackColor = true;
            this.SDButton.Click += new System.EventHandler(this.SDButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Consolas", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(220, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(711, 44);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Super Store Grocery Management System";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Silver;
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusLabel.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.Location = new System.Drawing.Point(314, 464);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(497, 57);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Operation Status Displayed Here!";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroceryAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1153, 542);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SDGroupBox);
            this.Controls.Add(this.UDGroupBox);
            this.Controls.Add(this.LDGroupBox);
            this.Controls.Add(this.GroceryListBox);
            this.Name = "GroceryAppForm";
            this.Text = "Grocery App";
            this.Load += new System.EventHandler(this.GroceryAppForm_Load);
            this.LDGroupBox.ResumeLayout(false);
            this.LDGroupBox.PerformLayout();
            this.UDGroupBox.ResumeLayout(false);
            this.UDGroupBox.PerformLayout();
            this.SDGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox GroceryListBox;
        private System.Windows.Forms.GroupBox LDGroupBox;
        private System.Windows.Forms.Button LDButton;
        private System.Windows.Forms.GroupBox UDGroupBox;
        private System.Windows.Forms.Label UQSLabel;
        private System.Windows.Forms.Button UQSButton;
        private System.Windows.Forms.GroupBox SDGroupBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox UQSTextBox;
        private System.Windows.Forms.Label UQRLabel;
        private System.Windows.Forms.TextBox UQRTextBox;
        private System.Windows.Forms.Button SGButton;
        private System.Windows.Forms.Button UQRButton;
        private System.Windows.Forms.Button DGButton;
        private System.Windows.Forms.Button SRRButton;
        private System.Windows.Forms.Button SSRButton;
        private System.Windows.Forms.Button SDButton;
    }
}

