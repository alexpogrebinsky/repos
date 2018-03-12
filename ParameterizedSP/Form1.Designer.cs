namespace ParameterizedSP
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
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.GetTotalSalesButton = new System.Windows.Forms.Button();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID:";
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(143, 62);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(212, 22);
            this.CustomerIDTextBox.TabIndex = 1;
            this.CustomerIDTextBox.TextChanged += new System.EventHandler(this.CustomerIDTextBox_TextChanged);
            // 
            // GetTotalSalesButton
            // 
            this.GetTotalSalesButton.Location = new System.Drawing.Point(32, 102);
            this.GetTotalSalesButton.Name = "GetTotalSalesButton";
            this.GetTotalSalesButton.Size = new System.Drawing.Size(165, 23);
            this.GetTotalSalesButton.TabIndex = 2;
            this.GetTotalSalesButton.Text = "Get Total Sales";
            this.GetTotalSalesButton.UseVisualStyleBackColor = true;
            this.GetTotalSalesButton.Click += new System.EventHandler(this.GetTotalSalesButton_Click);
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Location = new System.Drawing.Point(29, 147);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(83, 17);
            this.TotalSalesLabel.TabIndex = 3;
            this.TotalSalesLabel.Text = "Total Sales:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 247);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.GetTotalSalesButton);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.Button GetTotalSalesButton;
        private System.Windows.Forms.Label TotalSalesLabel;
    }
}

