
namespace VegunSoft.Schedule.App
{
    partial class FScheduleDemo
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
            this.ucSchedulePersonelStatus1 = new VegunSoft.Schedule.View.Dev.Personnel.UcSchedulePersonelStatus();
            this.SuspendLayout();
            // 
            // ucSchedulePersonelStatus1
            // 
            this.ucSchedulePersonelStatus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSchedulePersonelStatus1.Location = new System.Drawing.Point(0, 0);
            this.ucSchedulePersonelStatus1.Name = "ucSchedulePersonelStatus1";
            this.ucSchedulePersonelStatus1.Size = new System.Drawing.Size(800, 450);
            this.ucSchedulePersonelStatus1.TabIndex = 0;
            // 
            // FScheduleDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucSchedulePersonelStatus1);
            this.Name = "FScheduleDemo";
            this.Text = "FScheduleDemo";
            this.ResumeLayout(false);

        }

        #endregion

        private View.Dev.Personnel.UcSchedulePersonelStatus ucSchedulePersonelStatus1;
    }
}