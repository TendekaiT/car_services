namespace VendaBoulevardAutoCentre
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnAutoParts = new System.Windows.Forms.Button();
            this.btnCarwash = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda Boulevard Auto Centre meeting all your vehicle\'s needs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(39, 77);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(106, 43);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Vehicle Sale";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(256, 153);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(101, 33);
            this.btnLeave.TabIndex = 2;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnAutoParts
            // 
            this.btnAutoParts.Location = new System.Drawing.Point(187, 77);
            this.btnAutoParts.Name = "btnAutoParts";
            this.btnAutoParts.Size = new System.Drawing.Size(101, 43);
            this.btnAutoParts.TabIndex = 3;
            this.btnAutoParts.Text = "Auto Parts Lookup";
            this.btnAutoParts.UseVisualStyleBackColor = true;
            this.btnAutoParts.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCarwash
            // 
            this.btnCarwash.Location = new System.Drawing.Point(336, 77);
            this.btnCarwash.Name = "btnCarwash";
            this.btnCarwash.Size = new System.Drawing.Size(101, 43);
            this.btnCarwash.TabIndex = 4;
            this.btnCarwash.Text = "Car Wash";
            this.btnCarwash.UseVisualStyleBackColor = true;
            this.btnCarwash.Click += new System.EventHandler(this.btnCarwash_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Location = new System.Drawing.Point(472, 77);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(83, 45);
            this.btnAboutUs.TabIndex = 5;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VendaBoulevardAutoCentre.Properties.Resources.vb_proj;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnLeave;
            this.ClientSize = new System.Drawing.Size(582, 268);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.btnCarwash);
            this.Controls.Add(this.btnAutoParts);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "VB Auto Centre";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnStart;
        private Button btnLeave;
        private Button btnAutoParts;
        private Button btnCarwash;
        private Button btnAboutUs;
    }
}