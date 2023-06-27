namespace VendaBoulevardAutoCentre
{
    partial class AboutUs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrChangeImage = new System.Windows.Forms.Timer(this.components);
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.pBxVBAuto = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBxVBAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Venda Boulevard has come a long way. We started in a small garage in Polokwane, h" +
    "aving only 3 part-time employees.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Focusing on car washes initially, we have since diversified our range of services" +
    " to car and part sales. ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tmrChangeImage
            // 
            this.tmrChangeImage.Enabled = true;
            this.tmrChangeImage.Interval = 1000;
            this.tmrChangeImage.Tick += new System.EventHandler(this.tmrChangeImage_Tick);
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "carwash3.jpg");
            this.imgList.Images.SetKeyName(1, "carwash5.jpg");
            this.imgList.Images.SetKeyName(2, "car part.jpg");
            this.imgList.Images.SetKeyName(3, "car seats.jpg");
            this.imgList.Images.SetKeyName(4, "used cars.jpg");
            // 
            // pBxVBAuto
            // 
            this.pBxVBAuto.Location = new System.Drawing.Point(12, 42);
            this.pBxVBAuto.Name = "pBxVBAuto";
            this.pBxVBAuto.Size = new System.Drawing.Size(258, 256);
            this.pBxVBAuto.TabIndex = 3;
            this.pBxVBAuto.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 42);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::VendaBoulevardAutoCentre.Properties.Resources.blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 318);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pBxVBAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AboutUs";
            this.Text = "AboutUs";
            ((System.ComponentModel.ISupportInitialize)(this.pBxVBAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer tmrChangeImage;
        private ImageList imgList;
        private PictureBox pBxVBAuto;
        private Button btnClose;
    }
}