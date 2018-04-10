namespace ImageEditor
{
    partial class ImageOperationsForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageDetalsContainer = new System.Windows.Forms.SplitContainer();
            this.lblImageName = new System.Windows.Forms.Label();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.lblLoadImage = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.btnExportImage = new System.Windows.Forms.Button();
            this.pbxOutputImage = new System.Windows.Forms.PictureBox();
            this.lblOutputImageName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDetalsContainer)).BeginInit();
            this.imageDetalsContainer.Panel1.SuspendLayout();
            this.imageDetalsContainer.Panel2.SuspendLayout();
            this.imageDetalsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOutputImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExportImage);
            this.panel2.Controls.Add(this.btnBrowseImage);
            this.panel2.Controls.Add(this.txtImagePath);
            this.panel2.Controls.Add(this.lblLoadImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 63);
            this.panel2.TabIndex = 1;
            // 
            // imageDetalsContainer
            // 
            this.imageDetalsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageDetalsContainer.Location = new System.Drawing.Point(0, 0);
            this.imageDetalsContainer.Name = "imageDetalsContainer";
            // 
            // imageDetalsContainer.Panel1
            // 
            this.imageDetalsContainer.Panel1.Controls.Add(this.pbxImage);
            this.imageDetalsContainer.Panel1.Controls.Add(this.lblImageName);
            this.imageDetalsContainer.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // imageDetalsContainer.Panel2
            // 
            this.imageDetalsContainer.Panel2.Controls.Add(this.pbxOutputImage);
            this.imageDetalsContainer.Panel2.Controls.Add(this.lblOutputImageName);
            this.imageDetalsContainer.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.imageDetalsContainer.Size = new System.Drawing.Size(642, 308);
            this.imageDetalsContainer.SplitterDistance = 333;
            this.imageDetalsContainer.TabIndex = 2;
            // 
            // lblImageName
            // 
            this.lblImageName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblImageName.Location = new System.Drawing.Point(3, 3);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(327, 13);
            this.lblImageName.TabIndex = 0;
            this.lblImageName.Text = "Image:";
            // 
            // pbxImage
            // 
            this.pbxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxImage.Location = new System.Drawing.Point(3, 16);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(327, 289);
            this.pbxImage.TabIndex = 1;
            this.pbxImage.TabStop = false;
            // 
            // lblLoadImage
            // 
            this.lblLoadImage.AutoSize = true;
            this.lblLoadImage.Location = new System.Drawing.Point(3, 3);
            this.lblLoadImage.Name = "lblLoadImage";
            this.lblLoadImage.Size = new System.Drawing.Size(60, 13);
            this.lblLoadImage.TabIndex = 0;
            this.lblLoadImage.Text = "Open path:";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(8, 20);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.ReadOnly = true;
            this.txtImagePath.Size = new System.Drawing.Size(462, 20);
            this.txtImagePath.TabIndex = 1;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(477, 18);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseImage.TabIndex = 2;
            this.btnBrowseImage.Text = "Browse";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // btnExportImage
            // 
            this.btnExportImage.Location = new System.Drawing.Point(557, 17);
            this.btnExportImage.Name = "btnExportImage";
            this.btnExportImage.Size = new System.Drawing.Size(75, 23);
            this.btnExportImage.TabIndex = 3;
            this.btnExportImage.Text = "Export";
            this.btnExportImage.UseVisualStyleBackColor = true;
            // 
            // pbxOutputImage
            // 
            this.pbxOutputImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxOutputImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxOutputImage.Location = new System.Drawing.Point(3, 16);
            this.pbxOutputImage.Name = "pbxOutputImage";
            this.pbxOutputImage.Size = new System.Drawing.Size(299, 289);
            this.pbxOutputImage.TabIndex = 3;
            this.pbxOutputImage.TabStop = false;
            // 
            // lblOutputImageName
            // 
            this.lblOutputImageName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOutputImageName.Location = new System.Drawing.Point(3, 3);
            this.lblOutputImageName.Name = "lblOutputImageName";
            this.lblOutputImageName.Size = new System.Drawing.Size(299, 13);
            this.lblOutputImageName.TabIndex = 2;
            this.lblOutputImageName.Text = "Output Image:";
            // 
            // ImageOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 371);
            this.Controls.Add(this.imageDetalsContainer);
            this.Controls.Add(this.panel2);
            this.Name = "ImageOperationsForm";
            this.Text = "Image Operations";
            this.Load += new System.EventHandler(this.ImageOperationsForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.imageDetalsContainer.Panel1.ResumeLayout(false);
            this.imageDetalsContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageDetalsContainer)).EndInit();
            this.imageDetalsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOutputImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExportImage;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Label lblLoadImage;
        private System.Windows.Forms.SplitContainer imageDetalsContainer;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.PictureBox pbxOutputImage;
        private System.Windows.Forms.Label lblOutputImageName;
    }
}

