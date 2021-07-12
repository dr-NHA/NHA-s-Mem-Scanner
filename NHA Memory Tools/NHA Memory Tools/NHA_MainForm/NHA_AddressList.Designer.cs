
namespace NHA_Memory_Tools.NHA_MainForm
{
    partial class NHA_AddressList
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
            this.MASK = new System.Windows.Forms.Panel();
            this.AddressListAdditionPanel = new System.Windows.Forms.Panel();
            this.SectionSplitting = new System.Windows.Forms.TableLayoutPanel();
            this.Description = new System.Windows.Forms.TextBox();
            this.TypeOfVALUE = new System.Windows.Forms.ComboBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.AddAddress = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoveSelected = new System.Windows.Forms.Button();
            this.AD_IT = new System.Windows.Forms.Panel();
            this.TopInfo = new System.Windows.Forms.Panel();
            this.INFO = new System.Windows.Forms.Label();
            this.MASK.SuspendLayout();
            this.AddressListAdditionPanel.SuspendLayout();
            this.SectionSplitting.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TopInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MASK
            // 
            this.MASK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MASK.Controls.Add(this.AD_IT);
            this.MASK.Controls.Add(this.AddressListAdditionPanel);
            this.MASK.Controls.Add(this.TopInfo);
            this.MASK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MASK.Location = new System.Drawing.Point(0, 0);
            this.MASK.Name = "MASK";
            this.MASK.Size = new System.Drawing.Size(556, 166);
            this.MASK.TabIndex = 0;
            // 
            // AddressListAdditionPanel
            // 
            this.AddressListAdditionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressListAdditionPanel.Controls.Add(this.SectionSplitting);
            this.AddressListAdditionPanel.Controls.Add(this.AddAddress);
            this.AddressListAdditionPanel.Controls.Add(this.panel2);
            this.AddressListAdditionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddressListAdditionPanel.Location = new System.Drawing.Point(0, 17);
            this.AddressListAdditionPanel.Name = "AddressListAdditionPanel";
            this.AddressListAdditionPanel.Size = new System.Drawing.Size(554, 33);
            this.AddressListAdditionPanel.TabIndex = 3;
            // 
            // SectionSplitting
            // 
            this.SectionSplitting.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.SectionSplitting.ColumnCount = 3;
            this.SectionSplitting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.23547F));
            this.SectionSplitting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.76453F));
            this.SectionSplitting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.SectionSplitting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.SectionSplitting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.SectionSplitting.Controls.Add(this.Description, 0, 0);
            this.SectionSplitting.Controls.Add(this.TypeOfVALUE, 2, 0);
            this.SectionSplitting.Controls.Add(this.Address, 1, 0);
            this.SectionSplitting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionSplitting.Location = new System.Drawing.Point(0, 0);
            this.SectionSplitting.Name = "SectionSplitting";
            this.SectionSplitting.RowCount = 1;
            this.SectionSplitting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SectionSplitting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SectionSplitting.Size = new System.Drawing.Size(305, 31);
            this.SectionSplitting.TabIndex = 6;
            // 
            // Description
            // 
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Location = new System.Drawing.Point(4, 4);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(106, 20);
            this.Description.TabIndex = 5;
            // 
            // TypeOfVALUE
            // 
            this.TypeOfVALUE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeOfVALUE.FormattingEnabled = true;
            this.TypeOfVALUE.Location = new System.Drawing.Point(234, 4);
            this.TypeOfVALUE.Name = "TypeOfVALUE";
            this.TypeOfVALUE.Size = new System.Drawing.Size(67, 21);
            this.TypeOfVALUE.TabIndex = 8;
            // 
            // Address
            // 
            this.Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Address.Location = new System.Drawing.Point(117, 4);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(110, 20);
            this.Address.TabIndex = 6;
            // 
            // AddAddress
            // 
            this.AddAddress.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAddress.Location = new System.Drawing.Point(305, 0);
            this.AddAddress.Name = "AddAddress";
            this.AddAddress.Size = new System.Drawing.Size(123, 31);
            this.AddAddress.TabIndex = 0;
            this.AddAddress.Text = "Add To Address List";
            this.AddAddress.UseVisualStyleBackColor = true;
            this.AddAddress.Click += new System.EventHandler(this.AddAddress_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RemoveSelected);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(428, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 31);
            this.panel2.TabIndex = 0;
            // 
            // RemoveSelected
            // 
            this.RemoveSelected.Dock = System.Windows.Forms.DockStyle.Right;
            this.RemoveSelected.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelected.Location = new System.Drawing.Point(6, 0);
            this.RemoveSelected.Name = "RemoveSelected";
            this.RemoveSelected.Size = new System.Drawing.Size(118, 31);
            this.RemoveSelected.TabIndex = 1;
            this.RemoveSelected.Text = "Remove Selected";
            this.RemoveSelected.UseVisualStyleBackColor = true;
            this.RemoveSelected.Click += new System.EventHandler(this.RemoveSelected_Click);
            // 
            // AD_IT
            // 
            this.AD_IT.AutoScroll = true;
            this.AD_IT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AD_IT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AD_IT.Location = new System.Drawing.Point(0, 50);
            this.AD_IT.Name = "AD_IT";
            this.AD_IT.Size = new System.Drawing.Size(554, 114);
            this.AD_IT.TabIndex = 4;
            // 
            // TopInfo
            // 
            this.TopInfo.Controls.Add(this.INFO);
            this.TopInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopInfo.Location = new System.Drawing.Point(0, 0);
            this.TopInfo.Name = "TopInfo";
            this.TopInfo.Size = new System.Drawing.Size(554, 17);
            this.TopInfo.TabIndex = 5;
            // 
            // INFO
            // 
            this.INFO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.INFO.Location = new System.Drawing.Point(0, 0);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(554, 17);
            this.INFO.TabIndex = 0;
            this.INFO.Text = "DESCRIPTION      |      ADDRESS      |      VALUETYPE";
            this.INFO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NHA_AddressList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 166);
            this.Controls.Add(this.MASK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NHA_AddressList";
            this.Text = "NHA_AddressList";
            this.MASK.ResumeLayout(false);
            this.AddressListAdditionPanel.ResumeLayout(false);
            this.SectionSplitting.ResumeLayout(false);
            this.SectionSplitting.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.TopInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MASK;
        private System.Windows.Forms.Panel AddressListAdditionPanel;
        private System.Windows.Forms.TableLayoutPanel SectionSplitting;
        public System.Windows.Forms.TextBox Description;
        public System.Windows.Forms.ComboBox TypeOfVALUE;
        public System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Button AddAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RemoveSelected;
        public System.Windows.Forms.Panel AD_IT;
        private System.Windows.Forms.Panel TopInfo;
        private System.Windows.Forms.Label INFO;
    }
}