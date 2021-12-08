
namespace ExcelAddIn
{
    partial class SightMachineRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public SightMachineRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.Configuration = this.Factory.CreateRibbonButton();
            this.DataTabCycleButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "SIGHT MACHINE";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.Configuration);
            this.group1.Items.Add(this.DataTabCycleButton);
            this.group1.Name = "group1";
            // 
            // Configuration
            // 
            this.Configuration.Label = "Configuration";
            this.Configuration.Name = "Configuration";
            this.Configuration.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Configuration_Click);
            // 
            // DataTabCycleButton
            // 
            this.DataTabCycleButton.Label = "Load DataTab Cycle";
            this.DataTabCycleButton.Name = "DataTabCycleButton";
            this.DataTabCycleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DataTabCycleButton_Click);
            // 
            // SightMachineRibbon
            // 
            this.Name = "SightMachineRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Configuration;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton DataTabCycleButton;
    }

    partial class ThisRibbonCollection
    {
        internal SightMachineRibbon Ribbon1
        {
            get { return this.GetRibbon<SightMachineRibbon>(); }
        }
    }
}
