namespace VegunSoft.Any.View.Dev.Forms
{
    partial class FDisplayInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDisplayInfo));
            this._txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this._txtDescription.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _txtDescription
            // 
            this._txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtDescription.Location = new System.Drawing.Point(3, 3);
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDescription.Properties.Appearance.Options.UseFont = true;
            this._txtDescription.Properties.ReadOnly = true;
            this._txtDescription.Size = new System.Drawing.Size(321, 163);
            this._txtDescription.TabIndex = 40;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._btnClose, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._txtDescription, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(327, 206);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // _btnClose
            // 
            this._btnClose.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnClose.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this._btnClose.Appearance.Options.UseFont = true;
            this._btnClose.Appearance.Options.UseForeColor = true;
            this._btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnClose.Image = ((System.Drawing.Image)(resources.GetObject("_btnClose.Image")));
            this._btnClose.Location = new System.Drawing.Point(3, 172);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(321, 31);
            this._btnClose.TabIndex = 276;
            this._btnClose.Text = "Đóng";
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // FDisplayInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 206);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FDisplayInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông báo:";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FDisplayInfo_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this._txtDescription.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit _txtDescription;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton _btnClose;
    }
}