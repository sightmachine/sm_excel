
namespace ExcelAddIn.Forms
{
    partial class DataCycle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataCycle));
            this.MachineTypeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LoadDataTabCyclesButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectMachineListBox = new System.Windows.Forms.ListBox();
            this.SelectMachine = new System.Windows.Forms.Label();
            this.MachineTypeComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MachineTypeLabel
            // 
            this.MachineTypeLabel.AutoSize = true;
            this.MachineTypeLabel.Location = new System.Drawing.Point(24, 25);
            this.MachineTypeLabel.Name = "MachineTypeLabel";
            this.MachineTypeLabel.Size = new System.Drawing.Size(93, 13);
            this.MachineTypeLabel.TabIndex = 0;
            this.MachineTypeLabel.Text = "MACHINE TYPE :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EndDateTimePicker);
            this.panel1.Controls.Add(this.StartDateTimePicker);
            this.panel1.Controls.Add(this.LoadDataTabCyclesButton);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SelectMachineListBox);
            this.panel1.Controls.Add(this.SelectMachine);
            this.panel1.Controls.Add(this.MachineTypeComboBox);
            this.panel1.Controls.Add(this.MachineTypeLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 319);
            this.panel1.TabIndex = 1;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(123, 233);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(401, 20);
            this.EndDateTimePicker.TabIndex = 13;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(123, 200);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(401, 20);
            this.StartDateTimePicker.TabIndex = 12;
            // 
            // LoadDataTabCyclesButton
            // 
            this.LoadDataTabCyclesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LoadDataTabCyclesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadDataTabCyclesButton.Location = new System.Drawing.Point(125, 270);
            this.LoadDataTabCyclesButton.Name = "LoadDataTabCyclesButton";
            this.LoadDataTabCyclesButton.Size = new System.Drawing.Size(194, 27);
            this.LoadDataTabCyclesButton.TabIndex = 11;
            this.LoadDataTabCyclesButton.Text = "LOAD DATATAB CYCLES";
            this.LoadDataTabCyclesButton.UseVisualStyleBackColor = false;
            this.LoadDataTabCyclesButton.Click += new System.EventHandler(this.LoadDataTabCyclesButton_Click_1);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(325, 270);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(199, 27);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "END DATE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "START DATE :";
            // 
            // SelectMachineListBox
            // 
            this.SelectMachineListBox.AccessibleName = "SelectMachineListBox";
            this.SelectMachineListBox.FormattingEnabled = true;
            this.SelectMachineListBox.HorizontalScrollbar = true;
            this.SelectMachineListBox.Location = new System.Drawing.Point(125, 62);
            this.SelectMachineListBox.Name = "SelectMachineListBox";
            this.SelectMachineListBox.ScrollAlwaysVisible = true;
            this.SelectMachineListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SelectMachineListBox.Size = new System.Drawing.Size(399, 121);
            this.SelectMachineListBox.TabIndex = 3;
            this.SelectMachineListBox.SelectedIndexChanged += new System.EventHandler(this.SelectMachineListBox_SelectedIndexChanged);
            // 
            // SelectMachine
            // 
            this.SelectMachine.AutoSize = true;
            this.SelectMachine.Location = new System.Drawing.Point(6, 62);
            this.SelectMachine.Name = "SelectMachine";
            this.SelectMachine.Size = new System.Drawing.Size(113, 13);
            this.SelectMachine.TabIndex = 2;
            this.SelectMachine.Text = "SELECT MACHINES :";
            // 
            // MachineTypeComboBox
            // 
            this.MachineTypeComboBox.FormattingEnabled = true;
            this.MachineTypeComboBox.Location = new System.Drawing.Point(125, 22);
            this.MachineTypeComboBox.Name = "MachineTypeComboBox";
            this.MachineTypeComboBox.Size = new System.Drawing.Size(399, 21);
            this.MachineTypeComboBox.TabIndex = 1;
            this.MachineTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.MachineTypeComboBox_SelectedIndexChanged);
            // 
            // DataCycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 320);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataCycle";
            this.Text = "Data Cycle Tab";
            this.Load += new System.EventHandler(this.DataCycle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label MachineTypeLabel;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.ListBox SelectMachineListBox;
        internal System.Windows.Forms.Label SelectMachine;
        internal System.Windows.Forms.ComboBox MachineTypeComboBox;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button CancelButton;
        internal System.Windows.Forms.Button LoadDataTabCyclesButton;
        internal System.Windows.Forms.DateTimePicker StartDateTimePicker;
        internal System.Windows.Forms.DateTimePicker EndDateTimePicker;
        internal System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}