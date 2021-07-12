
namespace NHA_Memory_Tools.NHA_ProcessFinder{
    partial class NHA_ProcessFinder{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent(){
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NHA_ProcessFinder));
            this.ProcessOptionsPanel = new System.Windows.Forms.Panel();
            this.ProcessSettingsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.AvoidSVC_ = new System.Windows.Forms.CheckBox();
            this.ProcessRefreshPanel = new System.Windows.Forms.Panel();
            this.RefreshList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchNameBox = new System.Windows.Forms.TextBox();
            this.ProcessList = new System.Windows.Forms.Panel();
            this.SelectedBox = new System.Windows.Forms.Panel();
            this.ProcessSelectedName = new System.Windows.Forms.Label();
            this.Use = new System.Windows.Forms.Button();
            this.Hider = new System.Windows.Forms.Button();
            this.ProcessOptionsPanel.SuspendLayout();
            this.ProcessSettingsFlow.SuspendLayout();
            this.ProcessRefreshPanel.SuspendLayout();
            this.SelectedBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessOptionsPanel
            // 
            this.ProcessOptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProcessOptionsPanel.Controls.Add(this.ProcessSettingsFlow);
            this.ProcessOptionsPanel.Controls.Add(this.ProcessRefreshPanel);
            this.ProcessOptionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProcessOptionsPanel.Location = new System.Drawing.Point(0, 23);
            this.ProcessOptionsPanel.Name = "ProcessOptionsPanel";
            this.ProcessOptionsPanel.Size = new System.Drawing.Size(391, 72);
            this.ProcessOptionsPanel.TabIndex = 0;
            // 
            // ProcessSettingsFlow
            // 
            this.ProcessSettingsFlow.AutoScroll = true;
            this.ProcessSettingsFlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProcessSettingsFlow.Controls.Add(this.AvoidSVC_);
            this.ProcessSettingsFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessSettingsFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ProcessSettingsFlow.Location = new System.Drawing.Point(136, 0);
            this.ProcessSettingsFlow.Name = "ProcessSettingsFlow";
            this.ProcessSettingsFlow.Size = new System.Drawing.Size(253, 70);
            this.ProcessSettingsFlow.TabIndex = 2;
            this.ProcessSettingsFlow.WrapContents = false;
            this.ProcessSettingsFlow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
            // 
            // AvoidSVC_
            // 
            this.AvoidSVC_.AutoSize = true;
            this.AvoidSVC_.Checked = true;
            this.AvoidSVC_.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AvoidSVC_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvoidSVC_.Location = new System.Drawing.Point(3, 3);
            this.AvoidSVC_.Name = "AvoidSVC_";
            this.AvoidSVC_.Size = new System.Drawing.Size(133, 17);
            this.AvoidSVC_.TabIndex = 1;
            this.AvoidSVC_.Text = "Avoid Default Service\'s";
            this.AvoidSVC_.UseVisualStyleBackColor = true;
            this.AvoidSVC_.CheckedChanged += new System.EventHandler(this.AvoidSVC__CheckedChanged);
            // 
            // ProcessRefreshPanel
            // 
            this.ProcessRefreshPanel.AutoScroll = true;
            this.ProcessRefreshPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProcessRefreshPanel.Controls.Add(this.RefreshList);
            this.ProcessRefreshPanel.Controls.Add(this.label1);
            this.ProcessRefreshPanel.Controls.Add(this.SearchNameBox);
            this.ProcessRefreshPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProcessRefreshPanel.Location = new System.Drawing.Point(0, 0);
            this.ProcessRefreshPanel.Name = "ProcessRefreshPanel";
            this.ProcessRefreshPanel.Size = new System.Drawing.Size(136, 70);
            this.ProcessRefreshPanel.TabIndex = 3;
            this.ProcessRefreshPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
            // 
            // RefreshList
            // 
            this.RefreshList.Dock = System.Windows.Forms.DockStyle.Top;
            this.RefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshList.Location = new System.Drawing.Point(0, 0);
            this.RefreshList.Name = "RefreshList";
            this.RefreshList.Size = new System.Drawing.Size(134, 23);
            this.RefreshList.TabIndex = 1;
            this.RefreshList.Text = "Refresh List";
            this.RefreshList.UseVisualStyleBackColor = true;
            this.RefreshList.Click += new System.EventHandler(this.RefreshList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search For Process:";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
            // 
            // SearchNameBox
            // 
            this.SearchNameBox.Location = new System.Drawing.Point(3, 44);
            this.SearchNameBox.Name = "SearchNameBox";
            this.SearchNameBox.Size = new System.Drawing.Size(126, 20);
            this.SearchNameBox.TabIndex = 2;
            this.SearchNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchNameBox_KeyDown);
            // 
            // ProcessList
            // 
            this.ProcessList.AutoScroll = true;
            this.ProcessList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProcessList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessList.Location = new System.Drawing.Point(0, 95);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(391, 208);
            this.ProcessList.TabIndex = 1;
            this.ProcessList.SizeChanged += new System.EventHandler(this.ProcessList_SizeChanged);
            this.ProcessList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
            // 
            // SelectedBox
            // 
            this.SelectedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedBox.Controls.Add(this.ProcessSelectedName);
            this.SelectedBox.Controls.Add(this.Use);
            this.SelectedBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectedBox.Location = new System.Drawing.Point(0, 303);
            this.SelectedBox.Name = "SelectedBox";
            this.SelectedBox.Size = new System.Drawing.Size(391, 24);
            this.SelectedBox.TabIndex = 2;
            // 
            // ProcessSelectedName
            // 
            this.ProcessSelectedName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessSelectedName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessSelectedName.Location = new System.Drawing.Point(0, 0);
            this.ProcessSelectedName.Name = "ProcessSelectedName";
            this.ProcessSelectedName.Size = new System.Drawing.Size(283, 22);
            this.ProcessSelectedName.TabIndex = 3;
            this.ProcessSelectedName.Text = "Search For Process:";
            this.ProcessSelectedName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProcessSelectedName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
            // 
            // Use
            // 
            this.Use.Dock = System.Windows.Forms.DockStyle.Right;
            this.Use.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Use.Location = new System.Drawing.Point(283, 0);
            this.Use.Name = "Use";
            this.Use.Size = new System.Drawing.Size(106, 22);
            this.Use.TabIndex = 2;
            this.Use.Text = "Use Process:";
            this.Use.UseVisualStyleBackColor = true;
            this.Use.Click += new System.EventHandler(this.Use_Click);
            // 
            // Hider
            // 
            this.Hider.Dock = System.Windows.Forms.DockStyle.Top;
            this.Hider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hider.Location = new System.Drawing.Point(0, 0);
            this.Hider.Name = "Hider";
            this.Hider.Size = new System.Drawing.Size(391, 23);
            this.Hider.TabIndex = 3;
            this.Hider.Text = "Close This Window";
            this.Hider.UseVisualStyleBackColor = true;
            this.Hider.Click += new System.EventHandler(this.Hider_Click);
            // 
            // NHA_ProcessFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 327);
            this.Controls.Add(this.ProcessList);
            this.Controls.Add(this.SelectedBox);
            this.Controls.Add(this.ProcessOptionsPanel);
            this.Controls.Add(this.Hider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NHA_ProcessFinder";
            this.Text = "NHA\'s Not\'a Process Find\'a";
            this.ProcessOptionsPanel.ResumeLayout(false);
            this.ProcessSettingsFlow.ResumeLayout(false);
            this.ProcessSettingsFlow.PerformLayout();
            this.ProcessRefreshPanel.ResumeLayout(false);
            this.ProcessRefreshPanel.PerformLayout();
            this.SelectedBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel ProcessOptionsPanel;
        public System.Windows.Forms.Panel ProcessList;
        private System.Windows.Forms.FlowLayoutPanel ProcessSettingsFlow;
        private System.Windows.Forms.CheckBox AvoidSVC_;
        private System.Windows.Forms.Panel ProcessRefreshPanel;
        public System.Windows.Forms.Button RefreshList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchNameBox;
        private System.Windows.Forms.Panel SelectedBox;
        public System.Windows.Forms.Button Use;
        public System.Windows.Forms.Label ProcessSelectedName;
        private System.Windows.Forms.Button Hider;
    }
}

