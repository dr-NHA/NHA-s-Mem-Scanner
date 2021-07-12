
namespace NHA_Memory_Tools.NHA_MainForm
{
    partial class NHA_File
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NHA_File));
            this.Hider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hider
            // 
            this.Hider.Dock = System.Windows.Forms.DockStyle.Top;
            this.Hider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hider.Location = new System.Drawing.Point(0, 0);
            this.Hider.Name = "Hider";
            this.Hider.Size = new System.Drawing.Size(483, 23);
            this.Hider.TabIndex = 1;
            this.Hider.Text = "Hide This Window";
            this.Hider.UseVisualStyleBackColor = true;
            this.Hider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hider_MouseDown);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "MORE COMING SOON CUNTS!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NHA_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(483, 224);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NHA_File";
            this.Text = "NHA\'s Not\'a File Wind\'a";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Hider;
        private System.Windows.Forms.Label label1;
    }
}