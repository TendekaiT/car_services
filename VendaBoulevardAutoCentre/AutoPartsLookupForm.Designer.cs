namespace VendaBoulevardAutoCentre
{
    partial class AutoPartsLookupForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBxBrand = new System.Windows.Forms.GroupBox();
            this.rdBnBrandX = new System.Windows.Forms.RadioButton();
            this.rdBnBrandC = new System.Windows.Forms.RadioButton();
            this.rdBnBrandA = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerPartNo = new System.Windows.Forms.TextBox();
            this.txtVBAutoPartNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLookup = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpBxBrand.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.grpBxBrand);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCustomerPartNo);
            this.groupBox1.Location = new System.Drawing.Point(51, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Brand and Enter Part Number";
            // 
            // grpBxBrand
            // 
            this.grpBxBrand.Controls.Add(this.rdBnBrandX);
            this.grpBxBrand.Controls.Add(this.rdBnBrandC);
            this.grpBxBrand.Controls.Add(this.rdBnBrandA);
            this.grpBxBrand.Location = new System.Drawing.Point(15, 49);
            this.grpBxBrand.Name = "grpBxBrand";
            this.grpBxBrand.Size = new System.Drawing.Size(105, 100);
            this.grpBxBrand.TabIndex = 5;
            this.grpBxBrand.TabStop = false;
            this.grpBxBrand.Text = "Brand";
            // 
            // rdBnBrandX
            // 
            this.rdBnBrandX.AutoSize = true;
            this.rdBnBrandX.Location = new System.Drawing.Point(6, 72);
            this.rdBnBrandX.Name = "rdBnBrandX";
            this.rdBnBrandX.Size = new System.Drawing.Size(66, 19);
            this.rdBnBrandX.TabIndex = 2;
            this.rdBnBrandX.TabStop = true;
            this.rdBnBrandX.Text = "Brand X";
            this.rdBnBrandX.UseVisualStyleBackColor = true;
            // 
            // rdBnBrandC
            // 
            this.rdBnBrandC.AutoSize = true;
            this.rdBnBrandC.Location = new System.Drawing.Point(5, 47);
            this.rdBnBrandC.Name = "rdBnBrandC";
            this.rdBnBrandC.Size = new System.Drawing.Size(67, 19);
            this.rdBnBrandC.TabIndex = 1;
            this.rdBnBrandC.TabStop = true;
            this.rdBnBrandC.Text = "Brand C";
            this.rdBnBrandC.UseVisualStyleBackColor = true;
            // 
            // rdBnBrandA
            // 
            this.rdBnBrandA.AutoSize = true;
            this.rdBnBrandA.Location = new System.Drawing.Point(6, 22);
            this.rdBnBrandA.Name = "rdBnBrandA";
            this.rdBnBrandA.Size = new System.Drawing.Size(67, 19);
            this.rdBnBrandA.TabIndex = 0;
            this.rdBnBrandA.TabStop = true;
            this.rdBnBrandA.Text = "Brand A";
            this.rdBnBrandA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Their part number";
            // 
            // txtCustomerPartNo
            // 
            this.txtCustomerPartNo.Location = new System.Drawing.Point(148, 99);
            this.txtCustomerPartNo.Name = "txtCustomerPartNo";
            this.txtCustomerPartNo.Size = new System.Drawing.Size(100, 23);
            this.txtCustomerPartNo.TabIndex = 1;
            // 
            // txtVBAutoPartNo
            // 
            this.txtVBAutoPartNo.Location = new System.Drawing.Point(378, 137);
            this.txtVBAutoPartNo.Name = "txtVBAutoPartNo";
            this.txtVBAutoPartNo.ReadOnly = true;
            this.txtVBAutoPartNo.Size = new System.Drawing.Size(100, 23);
            this.txtVBAutoPartNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "VB Auto Part Number";
            // 
            // btnLookup
            // 
            this.btnLookup.Location = new System.Drawing.Point(124, 264);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(75, 23);
            this.btnLookup.TabIndex = 3;
            this.btnLookup.Text = "Lookup";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(224, 264);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(329, 264);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AutoPartsLookupForm
            // 
            this.AcceptButton = this.btnLookup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VendaBoulevardAutoCentre.Properties.Resources.mechanic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(522, 299);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVBAutoPartNo);
            this.Controls.Add(this.groupBox1);
            this.Name = "AutoPartsLookupForm";
            this.Text = "AutoPartsLookupForm";
            this.Load += new System.EventHandler(this.AutoPartsLookupForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBxBrand.ResumeLayout(false);
            this.grpBxBrand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtCustomerPartNo;
        private TextBox txtVBAutoPartNo;
        private Label label2;
        private Button btnLookup;
        private Button btnClear;
        private Button btnExit;
        private GroupBox grpBxBrand;
        private RadioButton rdBnBrandX;
        private RadioButton rdBnBrandC;
        private RadioButton rdBnBrandA;
    }
}