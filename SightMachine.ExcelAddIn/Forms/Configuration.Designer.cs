
namespace ExcelAddIn.Forms
{
    partial class Configuration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateTimeFormatTextBox = new System.Windows.Forms.TextBox();
            this.PageSizeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ApiBaseUrlTextBox = new System.Windows.Forms.TextBox();
            this.ApiBaseUrlLabel = new System.Windows.Forms.Label();
            this.ApiSecretLabel = new System.Windows.Forms.Label();
            this.ApiSecretTextBox = new System.Windows.Forms.TextBox();
            this.APIKeyIdTextBox = new System.Windows.Forms.TextBox();
            this.APIKeyIdLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(143, 210);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(210, 28);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "CONNECT";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DateTimeFormatTextBox);
            this.panel1.Controls.Add(this.PageSizeTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.ApiBaseUrlTextBox);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.ApiBaseUrlLabel);
            this.panel1.Controls.Add(this.ApiSecretLabel);
            this.panel1.Controls.Add(this.ApiSecretTextBox);
            this.panel1.Controls.Add(this.APIKeyIdTextBox);
            this.panel1.Controls.Add(this.APIKeyIdLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 256);
            this.panel1.TabIndex = 1;
            // 
            // DateTimeFormatTextBox
            // 
            this.DateTimeFormatTextBox.Location = new System.Drawing.Point(143, 173);
            this.DateTimeFormatTextBox.Name = "DateTimeFormatTextBox";
            this.DateTimeFormatTextBox.Size = new System.Drawing.Size(438, 20);
            this.DateTimeFormatTextBox.TabIndex = 4;
            // 
            // PageSizeTextBox
            // 
            this.PageSizeTextBox.Location = new System.Drawing.Point(143, 135);
            this.PageSizeTextBox.Name = "PageSizeTextBox";
            this.PageSizeTextBox.Size = new System.Drawing.Size(438, 20);
            this.PageSizeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "DATE TIME FORMAT :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "PAGE SIZE :";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(358, 210);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(223, 28);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApiBaseUrlTextBox
            // 
            this.ApiBaseUrlTextBox.Location = new System.Drawing.Point(143, 20);
            this.ApiBaseUrlTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ApiBaseUrlTextBox.Name = "ApiBaseUrlTextBox";
            this.ApiBaseUrlTextBox.Size = new System.Drawing.Size(438, 20);
            this.ApiBaseUrlTextBox.TabIndex = 0;
            // 
            // ApiBaseUrlLabel
            // 
            this.ApiBaseUrlLabel.AutoSize = true;
            this.ApiBaseUrlLabel.Location = new System.Drawing.Point(47, 22);
            this.ApiBaseUrlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ApiBaseUrlLabel.Name = "ApiBaseUrlLabel";
            this.ApiBaseUrlLabel.Size = new System.Drawing.Size(86, 13);
            this.ApiBaseUrlLabel.TabIndex = 4;
            this.ApiBaseUrlLabel.Text = "API BASE URL :";
            // 
            // ApiSecretLabel
            // 
            this.ApiSecretLabel.AutoSize = true;
            this.ApiSecretLabel.Location = new System.Drawing.Point(79, 100);
            this.ApiSecretLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ApiSecretLabel.Name = "ApiSecretLabel";
            this.ApiSecretLabel.Size = new System.Drawing.Size(56, 13);
            this.ApiSecretLabel.TabIndex = 3;
            this.ApiSecretLabel.Text = "SECRET :";
            // 
            // ApiSecretTextBox
            // 
            this.ApiSecretTextBox.Location = new System.Drawing.Point(143, 97);
            this.ApiSecretTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ApiSecretTextBox.Name = "ApiSecretTextBox";
            this.ApiSecretTextBox.Size = new System.Drawing.Size(438, 20);
            this.ApiSecretTextBox.TabIndex = 2;
            // 
            // APIKeyIdTextBox
            // 
            this.APIKeyIdTextBox.Location = new System.Drawing.Point(143, 58);
            this.APIKeyIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.APIKeyIdTextBox.Name = "APIKeyIdTextBox";
            this.APIKeyIdTextBox.Size = new System.Drawing.Size(438, 20);
            this.APIKeyIdTextBox.TabIndex = 1;
            // 
            // APIKeyIdLabel
            // 
            this.APIKeyIdLabel.AutoSize = true;
            this.APIKeyIdLabel.Location = new System.Drawing.Point(83, 60);
            this.APIKeyIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.APIKeyIdLabel.Name = "APIKeyIdLabel";
            this.APIKeyIdLabel.Size = new System.Drawing.Size(54, 13);
            this.APIKeyIdLabel.TabIndex = 0;
            this.APIKeyIdLabel.Text = "API KEY :";
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 260);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Configuration";
            this.Text = "Sight Machine Configuration";
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button SaveButton;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label ApiSecretLabel;
        internal System.Windows.Forms.TextBox ApiSecretTextBox;
        internal System.Windows.Forms.TextBox APIKeyIdTextBox;
        internal System.Windows.Forms.Label APIKeyIdLabel;
        internal System.Windows.Forms.Label ApiBaseUrlLabel;
        internal System.Windows.Forms.TextBox ApiBaseUrlTextBox;
        internal System.Windows.Forms.Button CancelButton;
        internal System.Windows.Forms.TextBox DateTimeFormatTextBox;
        internal System.Windows.Forms.TextBox PageSizeTextBox;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
    }
}