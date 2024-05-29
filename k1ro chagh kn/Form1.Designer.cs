using System.Windows.Forms;

namespace PictureBoxSizeChanger
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBox1;
        private Button buttonIncreaseSize;
        private Button buttonDecreaseSize;
        private Button buttonSelectImage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonIncreaseSize = new System.Windows.Forms.Button();
            this.buttonDecreaseSize = new System.Windows.Forms.Button();
            this.buttonSelectImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(305, 220);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonIncreaseSize
            // 
            this.buttonIncreaseSize.FlatAppearance.BorderSize = 0;
            this.buttonIncreaseSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncreaseSize.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncreaseSize.Location = new System.Drawing.Point(13, 697);
            this.buttonIncreaseSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonIncreaseSize.Name = "buttonIncreaseSize";
            this.buttonIncreaseSize.Size = new System.Drawing.Size(218, 51);
            this.buttonIncreaseSize.TabIndex = 1;
            this.buttonIncreaseSize.Text = "کیوان رو چاق کن";
            this.buttonIncreaseSize.UseVisualStyleBackColor = true;
            this.buttonIncreaseSize.Click += new System.EventHandler(this.buttonIncreaseSize_Click);
            // 
            // buttonDecreaseSize
            // 
            this.buttonDecreaseSize.FlatAppearance.BorderSize = 0;
            this.buttonDecreaseSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecreaseSize.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecreaseSize.Location = new System.Drawing.Point(618, 694);
            this.buttonDecreaseSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDecreaseSize.Name = "buttonDecreaseSize";
            this.buttonDecreaseSize.Size = new System.Drawing.Size(213, 51);
            this.buttonDecreaseSize.TabIndex = 2;
            this.buttonDecreaseSize.Text = "کیوان رو لاغر کن";
            this.buttonDecreaseSize.UseVisualStyleBackColor = true;
            this.buttonDecreaseSize.Click += new System.EventHandler(this.buttonDecreaseSize_Click);
            // 
            // buttonSelectImage
            // 
            this.buttonSelectImage.FlatAppearance.BorderSize = 0;
            this.buttonSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectImage.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectImage.Location = new System.Drawing.Point(305, 694);
            this.buttonSelectImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectImage.Name = "buttonSelectImage";
            this.buttonSelectImage.Size = new System.Drawing.Size(260, 51);
            this.buttonSelectImage.TabIndex = 3;
            this.buttonSelectImage.Text = "کیوان رو انتخواب کن";
            this.buttonSelectImage.UseVisualStyleBackColor = true;
            this.buttonSelectImage.Click += new System.EventHandler(this.buttonSelectImage_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(819, 93);
            this.label1.TabIndex = 4;
            this.label1.Text = "کیوان رو چاق کن";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 758);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelectImage);
            this.Controls.Add(this.buttonDecreaseSize);
            this.Controls.Add(this.buttonIncreaseSize);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کیوان رو چاق کن";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private Label label1;
    }
}
