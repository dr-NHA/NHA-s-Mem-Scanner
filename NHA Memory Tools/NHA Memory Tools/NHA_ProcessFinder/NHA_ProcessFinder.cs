using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace NHA_Memory_Tools.NHA_ProcessFinder
{
    public partial class NHA_ProcessFinder : Form
    {

        

private void DragForm_MouseDown(object sender, MouseEventArgs e){
if (e.Button == MouseButtons.Left){
Program.MoveExtWindow(Handle);
}
}

        public NHA_ProcessFinder(){
            InitializeComponent();
            Defualt_AvoidSVC_ = AvoidSVC_.Checked;
            RefreshProcessListTask();
            OldPL_Size = ProcessList.Width;
        }

        public void RefreshList_Click(object sender, EventArgs e){
            RefreshProcessListTask();
        }


        public static string[] _SystemServiceNames =new string[] {
            "svchost","sihost","conhost","dllhost","ctfmon","sshd",
            "spoolsv","sqlwriter","winlogon","taskhostw","fontdrvhost",
            "dwm","services","wininit","csrss","igfxpers","TrustedInstaller",
            "smss","Idle","System", "lsass" };
        public static bool Defualt_AvoidSVC_ = false;

        public static bool _DefaultCompare(string NameOfProcess) {
            if (Defualt_AvoidSVC_ == true&&!_SystemServiceNames.Contains(NameOfProcess)) {
                return true;
            }
            return false;
        }
        Func<string,bool> ProcessCompareFunction = _DefaultCompare;
        public void StartUseSelectedProcess(Process Proc){
            PreSelectedProcess = Proc;
            ProcessSelectedName.Text = "Selected: "+Proc.ProcessName;
        }
        public Process PreSelectedProcess;
        public Process SelectedProcess;


        public List<ProcessListItem> AddingItems = new List<ProcessListItem>();
        public async Task RefreshProcessListTask(){
            PreSelectedProcess = null;
            foreach(ProcessListItem ProcItm in ProcessList.Controls){
             foreach(Control Iteem in   ProcItm.Controls){
                    Iteem.Dispose();
                }
                ProcItm.Dispose();
            }
            foreach(ProcessListItem ProcItm in AddingItems){
             foreach(Control Iteem in   ProcItm.Controls){
                    Iteem.Dispose();
                }
                ProcItm.Dispose();
            }
            AddingItems.Clear();
            GC.Collect();

            foreach (Process Proc in Process.GetProcesses()){
                if(ProcessCompareFunction(Proc.ProcessName)){
                ProcessListItem ProcessItem = new ProcessListItem();
                    ProcessItem.Name = Proc.ProcessName;
                    ProcessItem.ApplicationName.Text = Proc.ProcessName;
                    void ApplicationName_Click(object sender, EventArgs e){
                        StartUseSelectedProcess(Proc);
                    }
                    ProcessItem.ApplicationName.Click += ApplicationName_Click;
                    ProcessItem.Width = ProcessList.Width - 35;
                    ProcessItem.Height = ProcessList.Height / 10;
                    ProcessItem.Dock = DockStyle.Top;
                    ProcessItem.BringToFront();
                    ProcessItem.Show();
                    AddingItems.Add(ProcessItem);
                    }
            }
            ProcessList.Controls.Clear();
            ProcessList.Controls.AddRange(AddingItems.ToArray());
        }


        public int OldPL_Size = 0;
        private void ProcessList_SizeChanged(object sender, EventArgs e){
            if(OldPL_Size!= ProcessList.Width){
                OldPL_Size = ProcessList.Width;
            async Task RFSH(){
                int PXI = 0;int PXIM = 25;
            foreach (ProcessListItem ProcessItem in ProcessList.Controls){
                    ProcessItem.Width = ProcessList.Width - 35;
                    await Task.Delay(1);
                    if (PXI==PXIM) { PXI = 0;
                        await Task.Delay(3);
                    } else { PXI++; }
            }
            }
            RFSH();
                }
        }

        private void AvoidSVC__CheckedChanged(object sender, EventArgs e){
            Defualt_AvoidSVC_ = AvoidSVC_.Checked;
        }

        private void SearchNameBox_KeyDown(object sender, KeyEventArgs e){
            if(e.KeyCode==Keys.Enter){
            e.Handled = false;
                FindProcByName(SearchNameBox.Text);
            }
        }

        public string LastProcessName = "";
        public bool Finding = false;
        public async Task FindProcByName(string ItemName) {
            if(Finding==false){Finding=true;
            bool found = false;
            foreach (ProcessListItem ProcItm in ProcessList.Controls) {
                string NAMED = ProcItm.Name.ToLower();
                if (NAMED.Contains(ItemName) && LastProcessName != NAMED) {
                    ProcessList.ScrollControlIntoView(ProcItm);
                    LastProcessName = NAMED;
                    found = true;
                    break;
                }
            }

            if (found == false) {
                LastProcessName = "";
            }
            Finding = false;
        }
        }

        private void Use_Click(object sender, EventArgs e){
            SelectedProcess = PreSelectedProcess;
            this.Hide();
        }

        private void Hider_Click(object sender, EventArgs e){
            this.Hide();
        }



    }
}
