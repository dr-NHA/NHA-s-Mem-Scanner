using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHA_Memory_Tools.NHA_MainForm{
    public partial class NHA_AddressList : Form{
        public NHA_MemoryMain MainCaller;
        public NHA_AddressList(NHA_MemoryMain CallIn){
            MainCaller = CallIn;
            InitializeComponent();
            this.TopLevel = false;
            TypeOfVALUE.Items.AddRange(NHA_MemoryMain.ScanTypeDef);
            TypeOfVALUE.SelectedIndex = 0;
        }

        public void AddNewAddress(string Description,string Address,string TypeVal){
            NHA_AddressListItem ADI = new NHA_AddressListItem(MainCaller);
            ADI.Address.Text = Address;
            ADI.Description.Text = Description;
            ADI.Type.Text = TypeVal;
            ADI.Show();
            AD_IT.Controls.Add(ADI);
            ADI.Dock = DockStyle.Top;
            ADI.BringToFront();
        }

        private void AddAddress_Click(object sender, EventArgs e){
            AddNewAddress(Description.Text, Address.Text, TypeOfVALUE.Text);
        }

        private void RemoveSelected_Click(object sender, EventArgs e){
            List<int> INDEXING = new List<int>();int INDEX = 0;
            foreach (NHA_AddressListItem ADI in AD_IT.Controls){
              if(  ADI.FreezeAddress.Checked){
                    INDEXING.Add(INDEX);
                }
                INDEX++;
            }
            foreach (int INDEXer in INDEXING)
            {
                try{
                (AD_IT.Controls[INDEXer] as NHA_AddressListItem).Close();
                    (AD_IT.Controls[INDEXer] as NHA_AddressListItem).Dispose();
                }
                catch { }
            }

        }


    }
}
