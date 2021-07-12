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
    public partial class NHA_AddressListItem : Form{
        public NHA_AddressListItem(NHA_MemoryMain MainCallIn){
            InitializeComponent();
            this.TopLevel = false;
            Type.Items.AddRange(NHA_MemoryMain.ScanTypeDef);
            Type.SelectedIndex = 0;
            Refresh(MainCallIn);
        }
        public bool Killed = false;
        public async Task Refresh(NHA_MemoryMain MainCaller){
            bool Sel = false;
            for (; ; ){
                if (Killed||this.IsDisposed) { break; }
                if (Sel==true){
                    Sel = false;
                }
                
                if (this.ActiveControl==Value){
                    Sel = true;
                    if (Value.Text != "") {

                        MainCaller.MemHandler.WriteMemory(Address.Text, Type.Text, Value.Text, "");
                    }
                }else { 
              Value.Text=  MainCaller.ReadHandler(Address.Text,(string)Type.SelectedItem);}

                await Task.Delay(100);
            }
        }
        bool ValueAllowed = true;
      public  Memory.AOB_AddressResult Stored;
        private void Value_TextChanged(object sender, EventArgs e){
            ValueAllowed = true;
        }


    }
}
