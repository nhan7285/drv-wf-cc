namespace VegunSoft.Layer.Gui.Any.Provider.Forms
{
    partial class FImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FImage));
            this.panel1 = new System.Windows.Forms.Panel();
            this._pbCustomerImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pbCustomerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._pbCustomerImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 553);
            this.panel1.TabIndex = 0;
            // 
            // _pbCustomerImage
            // 
            this._pbCustomerImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pbCustomerImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pbCustomerImage.Image = ((System.Drawing.Image)(resources.GetObject("_pbCustomerImage.Image")));
           // this._pbCustomerImage.InitialImage = global::QlyNhakhoa.Properties.Resources.logoDRVUONG;
            this._pbCustomerImage.Location = new System.Drawing.Point(0, 0);
            this._pbCustomerImage.Margin = new System.Windows.Forms.Padding(26, 0, 26, 0);
            this._pbCustomerImage.Name = "_pbCustomerImage";
            this._pbCustomerImage.Size = new System.Drawing.Size(509, 553);
            this._pbCustomerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._pbCustomerImage.TabIndex = 138;
            this._pbCustomerImage.TabStop = false;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 553);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowBigImage";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pbCustomerImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox _pbCustomerImage;
    }
}