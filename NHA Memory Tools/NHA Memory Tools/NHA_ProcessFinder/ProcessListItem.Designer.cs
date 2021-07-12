
namespace NHA_Memory_Tools.NHA_ProcessFinder
{
    partial class ProcessListItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.ApplicationName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ApplicationName
            // 
            this.ApplicationName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplicationName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplicationName.Location = new System.Drawing.Point(0, 0);
            this.ApplicationName.Name = "ApplicationName";
            this.ApplicationName.Size = new System.Drawing.Size(560, 52);
            this.ApplicationName.TabIndex = 1;
            this.ApplicationName.Text = "NHA_KING";
            this.ApplicationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProcessListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 52);
            this.Controls.Add(this.ApplicationName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessListItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ProcessListItem";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label ApplicationName;
    }
}