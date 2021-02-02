namespace VegunSoft.App.Icon
{
    partial class IconExplorerForm64
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IconExplorerForm64));
            this.Commission64 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // Commission64
            // 
            this.Commission64.Appearance.Font = new System.Drawing.Font("Verdana", 9F);
            this.Commission64.Appearance.Options.UseFont = true;
            this.Commission64.Image = ((System.Drawing.Image)(resources.GetObject("Commission64.Image")));
            this.Commission64.ImageIndex = 2;
            this.Commission64.Location = new System.Drawing.Point(13, 12);
            this.Commission64.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Commission64.Name = "Commission64";
            this.Commission64.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Commission64.Size = new System.Drawing.Size(206, 100);
            this.Commission64.TabIndex = 108;
            this.Commission64.Text = "Commission64";
            // 
            // IconExplorerForm64
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Commission64);
            this.Name = "IconExplorerForm64";
            this.Text = "IconExplorerForm64";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Commission64;
    }
}