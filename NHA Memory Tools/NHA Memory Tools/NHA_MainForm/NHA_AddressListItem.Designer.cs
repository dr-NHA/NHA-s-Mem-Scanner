
namespace NHA_Memory_Tools.NHA_MainForm
{
    partial class NHA_AddressListItem
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
            this.Description = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Value = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.ComboBox();
            this.SectionSplitting = new System.Windows.Forms.TableLayoutPanel();
            this.FreezeAddress = new System.Windows.Forms.CheckBox();
            this.SectionSplitting.SuspendLayout();
            this.SuspendLayout();
            // 
            // Description
            // 
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Location = new System.Drawing.Point(25, 4);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(118, 20);
            this.Description.TabIndex = 0;
            // 
            // Address
            // 
            this.Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Address.Location = new System.Drawing.Point(150, 4);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(113, 20);
            this.Address.TabIndex = 1;
            // 
            // Value
            // 
            this.Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value.Location = new System.Drawing.Point(397, 4);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(62, 20);
            this.Value.TabIndex = 3;
            this.Value.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // Type
            // 
            this.Type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(270, 4);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(120, 21);
            this.Type.TabIndex = 4;
            // 
            // SectionSplitting
            // 
            this.SectionSplitting.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.SectionSplitting.ColumnCount = 5;
            this.SectionSplitting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.47368F));
            this.SectionSplitting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.52631F));
            this.SectionSplitting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.SectionSplitting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.SectionSplitting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.SectionSplitting.Controls.Add(this.Description, 1, 0);
            this.SectionSplitting.Controls.Add(this.Address, 2, 0);
            this.SectionSplitting.Controls.Add(this.Value, 4, 0);
            this.SectionSplitting.Controls.Add(this.Type, 3, 0);
            this.SectionSplitting.Controls.Add(this.FreezeAddress, 0, 0);
            this.SectionSplitting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionSplitting.Location = new System.Drawing.Point(0, 0);
            this.SectionSplitting.Name = "SectionSplitting";
            this.SectionSplitting.RowCount = 1;
            this.SectionSplitting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SectionSplitting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SectionSplitting.Size = new System.Drawing.Size(463, 34);
            this.SectionSplitting.TabIndex = 5;
            // 
            // FreezeAddress
            // 
            this.FreezeAddress.AutoSize = true;
            this.FreezeAddress.Location = new System.Drawing.Point(4, 4);
            this.FreezeAddress.Name = "FreezeAddress";
            this.FreezeAddress.Size = new System.Drawing.Size(14, 14);
            this.FreezeAddress.TabIndex = 5;
            this.FreezeAddress.UseVisualStyleBackColor = true;
            // 
            // NHA_AddressListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 34);
            this.Controls.Add(this.SectionSplitting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NHA_AddressListItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "NHA_AddressListItem";
            this.SectionSplitting.ResumeLayout(false);
            this.SectionSplitting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel SectionSplitting;
        public System.Windows.Forms.TextBox Description;
        public System.Windows.Forms.TextBox Address;
        public System.Windows.Forms.TextBox Value;
        public System.Windows.Forms.ComboBox Type;
        public System.Windows.Forms.CheckBox FreezeAddress;
    }
}