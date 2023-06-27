namespace VendaBoulevardAutoCentre
{
    partial class Carwash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carwash));
            this.cmbBxPackages = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPackages = new System.Windows.Forms.Label();
            this.lblExterior = new System.Windows.Forms.Label();
            this.lblInterior = new System.Windows.Forms.Label();
            this.lbxExterior = new System.Windows.Forms.ListBox();
            this.lbxInterior = new System.Windows.Forms.ListBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.cmbBxFragrances = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBxPackages
            // 
            this.cmbBxPackages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxPackages.FormattingEnabled = true;
            this.cmbBxPackages.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Executive",
            "Luxury"});
            this.cmbBxPackages.Location = new System.Drawing.Point(12, 63);
            this.cmbBxPackages.Name = "cmbBxPackages";
            this.cmbBxPackages.Size = new System.Drawing.Size(121, 23);
            this.cmbBxPackages.TabIndex = 0;
            this.cmbBxPackages.SelectedIndexChanged += new System.EventHandler(this.cmbBxPackages_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printOrderToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printOrderToolStripMenuItem
            // 
            this.printOrderToolStripMenuItem.Name = "printOrderToolStripMenuItem";
            this.printOrderToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.printOrderToolStripMenuItem.Text = "Print Order";
            this.printOrderToolStripMenuItem.Click += new System.EventHandler(this.printOrderToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblPackages
            // 
            this.lblPackages.AutoSize = true;
            this.lblPackages.Location = new System.Drawing.Point(12, 45);
            this.lblPackages.Name = "lblPackages";
            this.lblPackages.Size = new System.Drawing.Size(59, 15);
            this.lblPackages.TabIndex = 4;
            this.lblPackages.Text = "Packages:";
            // 
            // lblExterior
            // 
            this.lblExterior.AutoSize = true;
            this.lblExterior.Location = new System.Drawing.Point(158, 45);
            this.lblExterior.Name = "lblExterior";
            this.lblExterior.Size = new System.Drawing.Size(81, 15);
            this.lblExterior.TabIndex = 5;
            this.lblExterior.Text = "Exterior Work:";
            // 
            // lblInterior
            // 
            this.lblInterior.AutoSize = true;
            this.lblInterior.Location = new System.Drawing.Point(341, 45);
            this.lblInterior.Name = "lblInterior";
            this.lblInterior.Size = new System.Drawing.Size(79, 15);
            this.lblInterior.TabIndex = 6;
            this.lblInterior.Text = "Interior Work:";
            // 
            // lbxExterior
            // 
            this.lbxExterior.FormattingEnabled = true;
            this.lbxExterior.ItemHeight = 15;
            this.lbxExterior.Location = new System.Drawing.Point(158, 63);
            this.lbxExterior.Name = "lbxExterior";
            this.lbxExterior.Size = new System.Drawing.Size(161, 94);
            this.lbxExterior.TabIndex = 9;
            // 
            // lbxInterior
            // 
            this.lbxInterior.FormattingEnabled = true;
            this.lbxInterior.ItemHeight = 15;
            this.lbxInterior.Location = new System.Drawing.Point(341, 63);
            this.lbxInterior.Name = "lbxInterior";
            this.lbxInterior.Size = new System.Drawing.Size(169, 94);
            this.lbxInterior.TabIndex = 10;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // cmbBxFragrances
            // 
            this.cmbBxFragrances.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxFragrances.FormattingEnabled = true;
            this.cmbBxFragrances.Location = new System.Drawing.Point(12, 157);
            this.cmbBxFragrances.Name = "cmbBxFragrances";
            this.cmbBxFragrances.Size = new System.Drawing.Size(121, 23);
            this.cmbBxFragrances.TabIndex = 11;
            this.cmbBxFragrances.SelectedIndexChanged += new System.EventHandler(this.cmbBxFragrances_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fragrances:";
            // 
            // Carwash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VendaBoulevardAutoCentre.Properties.Resources.carwash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(538, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBxFragrances);
            this.Controls.Add(this.lbxInterior);
            this.Controls.Add(this.lbxExterior);
            this.Controls.Add(this.lblInterior);
            this.Controls.Add(this.lblExterior);
            this.Controls.Add(this.lblPackages);
            this.Controls.Add(this.cmbBxPackages);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Carwash";
            this.Text = "Carwash";
            this.Load += new System.EventHandler(this.Carwash_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbBxPackages;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem printOrderToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label lblPackages;
        private Label lblExterior;
        private Label lblInterior;
        private ListBox lbxExterior;
        private ListBox lbxInterior;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private ComboBox cmbBxFragrances;
        private Label label1;
    }
}