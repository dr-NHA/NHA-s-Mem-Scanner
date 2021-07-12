using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
//using System.Windows.Forms;
using System.Security.Principal;
using System.Threading.Tasks;

namespace NHA_Memory_Tools.NHA_MainForm
{
    public partial class NHA_MemoryMain : Form
    {
        public NHA_File FileHandler = new NHA_File();
        public Memory.Mem MemHandler = new Memory.Mem();
        public NHA_MemoryMain(){
            _AddressList = new NHA_AddressList(this);
            InitializeComponent();
            _AddressList.Show();
            _AddressList.Width = AddressList.Width;
            AddressList.Controls.Add(_AddressList);

            string[] TabItemNames = new string[] { 
            "NHA ENGINE <3",
            "File",
            "Settings",
            "Help"
            };
            List<TabPage> PGIL = new List<TabPage>();
            foreach (string XName in TabItemNames){
                TabPage PGI = new TabPage();
                PGI.Name = XName;
                PGI.Text = XName;
                PGIL.Add(PGI);
            }
            TabHandler.TabPages.Clear();
            TabHandler.TabPages.AddRange(PGIL.ToArray());
            TabHandler.SelectedIndex = 0;
            ScanValueType.Items.AddRange(ScanTypeDef);
            ScanValueType.SelectedIndex = 0;
        }

        public NHA_AddressList _AddressList;
        private void NHA_MemoryMain_Load(object sender, EventArgs e){
            //   
        }

        private void AddressList_SizeChanged(object sender, EventArgs e){
            foreach (Control OBI in AddressList.Controls) { OBI.Width = AddressList.Width; }
        }

        private void TabHandler_SelectedIndexChanged(object sender, EventArgs e){
            if (TabHandler.SelectedIndex>0){
                if (TabHandler.SelectedIndex ==1){
                    ShowFileHandler();
                }
                TabHandler.SelectedIndex = 0;
            }
        }

        public void ShowFileHandler(){
            if (FileHandler.Visible==false){
                FileHandler.Show();
            }
        }

        private void CheckConnection_Click(object sender, EventArgs e){
            NHA_ProcessInfo.Text = "No Connected Process!";
            if(FileHandler.PROFILER.Visible==false){
            FileHandler.PROFILER.SelectedProcess = null;
            FileHandler.PROFILER.Show();
            async Task OOP(){
             for(; ; ){
            if (FileHandler.PROFILER.SelectedProcess != null){
                NHA_ProcessInfo.Text = "Process: "+FileHandler.PROFILER.SelectedProcess.ProcessName+", ID: "+FileHandler.PROFILER.SelectedProcess.Id.ToString();
                            ScanCompletion.Text="Connected To Process: "+ MemHandler.OpenProcess(FileHandler.PROFILER.SelectedProcess.Id).ToString();
          break;}
                    if (FileHandler.PROFILER.Visible==false) { break; }
                    await Task.Delay(111);
            }

            }
            OOP();
        }}

        public static string[] ScanTypeDef = new string[] { 
        "Int",
        "Float",
        "String",
        "Long",
        "4ByteHex",
        "8ByteHex",
        "AOB",
        "ADV-AOB",
        };

        private void ScanValueType_SelectedIndexChanged(object sender, EventArgs e){
        }

        private void ScanValueType_TextChanged(object sender, EventArgs e){
            if (!ScanTypeDef.Contains(ScanValueType.Text)){
                ScanValueType.Text = ScanTypeDef.First();
            }
        }

        private void ScanStart_Click(object sender, EventArgs e){
            DoSelScan(!ResonForBitswap());
        }

       public string AobMaster(string typeofaob){
            if (typeofaob==ScanTypeDef[0]){//int
            int Passed;if (int.TryParse(ScanValue.Text, out Passed)){return Passed.ToString("X2");}
            } else if (typeofaob==ScanTypeDef[1]){//float
            float Passed;if (float.TryParse(ScanValue.Text, out Passed)){ string SwapFish = "";
                    foreach (byte REP in BitConverter.GetBytes(Passed)) { SwapFish += REP.ToString("X2")+" "; } return SwapFish.Trim();
                }
            } else if (typeofaob==ScanTypeDef[3]){//Long
            long Passed;if (long.TryParse(ScanValue.Text, out Passed)){return Passed.ToString("X2");}
            } else if (typeofaob==ScanTypeDef[5]||typeofaob==ScanTypeDef[4]){//8ByteHex
            return ScanValue.Text.Trim();
            }else if ((string) ScanValueType.SelectedItem == ScanTypeDef[2]){
              return BitConverter.ToString(Encoding.Default.GetBytes(ScanValue.Text)).Replace('-', ' ');
                }else   if ((string)ScanValueType.SelectedItem == ScanTypeDef[6]){
                return ScanValue.Text.Trim();
                }
                return "";
            }

      public  string ReadHandler(string AddressToRead,string typeofaob) { 
            if (typeofaob==ScanTypeDef[0]){//int
           return MemHandler.ReadInt(AddressToRead).ToString();
            } else if (typeofaob==ScanTypeDef[1]){//float
           return MemHandler.ReadFloat(AddressToRead,"",false).ToString();
            } else if (typeofaob==ScanTypeDef[3]){//Long
           return MemHandler.ReadLong(AddressToRead).ToString();
            } else if (typeofaob==ScanTypeDef[5]||typeofaob==ScanTypeDef[4]){//8ByteHex
           return MemHandler.ReadLong(AddressToRead).ToString("X2");
            }else if ((string) ScanValueType.SelectedItem == ScanTypeDef[2]){
           return MemHandler.ReadString(AddressToRead);
                }else   if ((string)ScanValueType.SelectedItem == ScanTypeDef[6]){
                string Bldr = "";
                foreach (byte VAL in MemHandler.ReadBytes(AddressToRead, 10)) { Bldr += VAL.ToString("X2")+" "; }
                return Bldr.Trim();
                }
            return "??";
        }

        public bool ResonForBitswap(){
                 string typeofaob=(string)ScanValueType.SelectedItem;
            if (typeofaob==ScanTypeDef[0]){//int
           return true;
            } else if (typeofaob==ScanTypeDef[3]){//Long
           return true;
            } else if (typeofaob==ScanTypeDef[5]||typeofaob==ScanTypeDef[4]){//8ByteHex
           return true;
            }else if ((string) ScanValueType.SelectedItem == ScanTypeDef[2]){
           return true;
                }
            return false;
        }

        public string AOB_MAKEFROMTEXT(bool DontBitSwap)
        {
            string BT_ = AobMaster((string)ScanValueType.SelectedItem);
            if (BT_ != "")
            {
                if (DontBitSwap == false)
                {
                    string BT__NEW = "";
                    foreach (char REV in BT_.Reverse())
                    {
                        BT__NEW += REV.ToString();
                    }
                    BT_ = ""; var i = 0; int Passing = 0;
                    foreach (char REV in BT__NEW)
                    {
                        if (BT__NEW.Length % 2 != 0 && Passing == BT__NEW.Length - 1)
                        {
                            BT_ += REV + "0";
                        }
                        else
                        {
                            BT_ += REV; Passing++;
                        }
                        if (i == 1)
                        {
                            i = 0; BT_ += " ";
                        }
                        else
                        {
                            i++;
                        }
                    }
                    for (; ; )
                    {
                        if (BT_.Length <= 9)
                        {
                            BT_ += " 00";
                        }
                        else
                        {
                            break;
                        }
                    }
                    string[] SPLIX = BT_.Split(' ');
                    BT_ = "";
                    foreach (string Slice in SPLIX)
                    {
                        foreach (char SLIXER in Slice.Reverse()) { BT_ += SLIXER; }
                        BT_ += " ";
                    }
                    BT_ = BT_.Replace("  ", " ").Trim();
                }
            }
            return BT_;
        }
        
          public async Task DoSelScan(bool DontBitSwap=false){
            string BT_ = AOB_MAKEFROMTEXT(DontBitSwap);
            if(BT_!=""){
                ScanAsHex.Text = BT_;
               RunScan(BT_);
        }
        }

      public  async Task RunScan(string AOB){
            MemHandler.MemoryRegionSizes = new long[]{
               long.Parse( RegionSizeMin.Value.ToString()),
               long.Parse( RegionSizeMax.Value.ToString())
            };
          Task AOB_H=  MemHandler.AoBScan(Convert.ToUInt64(ScanRegionSizeLow.Text,16), Convert.ToUInt64(ScanRegionSizeHigh.Text, 16), AOB, true, true, true, "");
            List<string> UsedAddresses = new List<string>();
          //  AOB_H.Start();
            for (; ; ){
            if(AOB_H.IsCompleted){
                        await Task.Delay(200);
                    ScanCompletion.Text="Results Are In!!!";
                    RefreshList();
                    break;
                }else{
                    ScanCompletion.Text = MemHandler.AoB_OutInfo;
                }
                await Task.Delay(100);
            }

        }


        private void ScanTypePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ScanValuePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ScanTypeTitle_Click(object sender, EventArgs e)
        {

        }

        private void ChangedUnchangedCollection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NextScan_Click(object sender, EventArgs e){
            NextScanFunc();
        }
        
          public async Task NextScanFunc(){
                List<Memory.AOB_AddressResult> Addix = MemHandler.AoB_OutAddys;
            string Parsed = ScanValue.Text;
            int Max = ScanValue.Text.Length;if (Max>9) { Max = 9; }
            int BRE = 1;
            int BREADD =90000;
            int BRECC = BREADD;
            for (; ; ){
            if (BRECC<Addix.Count){
                    BRECC = BRECC + BREADD;
                    BRE++;
                }else{
                    break;
                }
            }
            int Passed = 0; int PassedM = Addix.Count/ BRE;
            string B4 = "Comparing Address's With: " + ScanValue.Text.Substring(0, Max);
            string SF = "/" + Addix.Count;
            int Comp = 0;
            void SetB4(){
            ScanCompletion.Text = B4+ " "+ Comp.ToString()+ SF; Comp++;
                }
            SetB4();
            List<Memory.AOB_AddressResult> ADRI = new List<Memory.AOB_AddressResult>();
            foreach (Memory.AOB_AddressResult Addi in Addix){
                try {
                    string OLD = ReadHandler(Addi.Address, (string)ScanValueType.SelectedItem);
                    if (OLD == Parsed){
                        ADRI.Add(Addi);
                    }  
                    if (Passed== PassedM){Passed = 0;
                        await Task.Delay(50);
                            }else{
                            Passed++;
                    }
                    SET_OLD(Addi,OLD);
                    SetB4();
                        }catch{}
                }
            MemHandler.AoB_OutAddys = ADRI;
            Addix.Clear();
                RefreshList();
 }
      public  async Task SET_OLD(Memory.AOB_AddressResult X,string XX){
            X.OLD = XX;
        }
        

       public async Task RefreshList(){

            int Passed = 0; int PassedM = 8000;
            AddressListX.Items.Clear();
            int MaxSize = 15069;
            ScanCompletion.Text = "Address List Filling: Started!";
            if (MemHandler.AoB_OutAddys.Count < MaxSize) { MaxSize = MemHandler.AoB_OutAddys.Count; }
            for (var i=0;i<= MaxSize; i++){
                    AddressListX.Items.Add("("+
                        MemHandler.AoB_OutAddys[i].RegionSize.ToString()+"#" +
                        MemHandler.AoB_OutAddys[i].BaseAddress+")> "+
                        MemHandler.AoB_OutAddys[i].Address+": "+
                        ReadHandler(MemHandler.AoB_OutAddys[i].Address, (string)ScanValueType.SelectedItem));
            if (Passed== PassedM){Passed = 0;
                        await Task.Delay(50);
                            }else{
                            Passed++;
                        }
                    }
            ScanCompletion.Text = "Address List Filling: Finished";
        }

        private void RefreshAddressListX_Click(object sender, EventArgs e){
            RefreshList();
        }

        private void ScanValue_KeyDown(object sender, KeyEventArgs e){

            if (e.KeyCode==Keys.Enter){
            string BT_ = AOB_MAKEFROMTEXT(!ResonForBitswap());
            if(BT_!=""){
                ScanAsHex.Text = BT_;
            }
                ScanAsHex.Text = AobMaster("Float");
        }
            }

        private void AddToAddressList_Click(object sender, EventArgs e){
            foreach(string Select in AddressListX.SelectedItems)
            _AddressList.AddNewAddress("Un Named", Select.Split(':')[0].Split('>')[1].Trim(), (string)ScanValueType.SelectedItem);
        }

        private void UnchangedValue_Click(object sender, EventArgs e){
            UnchangedValue_TASK();
        }


          public  async Task UnchangedValue_TASK(){
                     List<Memory.AOB_AddressResult> Addix = MemHandler.AoB_OutAddys;
            string Parsed = ScanValue.Text;
            int Max = ScanValue.Text.Length;if (Max>9) { Max = 9; }
            int BRE = 1;
            int BREADD =90000;
            int BRECC = BREADD;
            for (; ; ){
            if (BRECC<Addix.Count){
                    BRECC = BRECC + BREADD;
                    BRE++;
                }else{
                    break;
                }
            }
            int Passed = 0; int PassedM = Addix.Count/ BRE;
            string B4 = "Comparing Address's With: " + ScanValue.Text.Substring(0, Max);
            string SF = "/" + Addix.Count;
            int Comp = 0;
            void SetB4(){
            ScanCompletion.Text = B4+ " "+ Comp.ToString()+ SF; Comp++;
                }
            SetB4();
            List<Memory.AOB_AddressResult> ADRI = new List<Memory.AOB_AddressResult>();
            foreach (Memory.AOB_AddressResult Addi in Addix){  try {
                    string OLD = ReadHandler(Addi.Address, (string)ScanValueType.SelectedItem);
                    if (OLD == Addi.OLD){
                        ADRI.Add(Addi);
                    }  
                    SET_OLD(Addi, OLD);
                        }catch{}
                    if (Passed== PassedM){Passed = 0;
                        await Task.Delay(50);
                            }else{
                            Passed++;
                    }
                    SetB4();
                }
            MemHandler.AoB_OutAddys = ADRI;
            Addix.Clear();
            RefreshList();
            }

        private void PeekInfo_Click(object sender, EventArgs e){
            if (AddressListX.SelectedIndex!=-1) { 
            string INFOX = (string)AddressListX.SelectedItems[0];
            SelectedRegionSize.Text = INFOX.Split('#')[0].Split('(')[1];
            SelectedInfoBase.Text = INFOX.Split('#')[1].Split(')')[0];
            SelectedInfoAddress.Text = INFOX.Split('>')[1].Split(':')[0].Trim();
        }}
    }
}
