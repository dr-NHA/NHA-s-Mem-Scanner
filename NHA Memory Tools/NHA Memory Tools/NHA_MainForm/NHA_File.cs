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

namespace NHA_Memory_Tools.NHA_MainForm{
    public partial class NHA_File : Form{

        
private void DragForm_MouseDown(object sender, MouseEventArgs e){
if (e.Button == MouseButtons.Left){
Program.MoveExtWindow(Handle);
}
}

        public NHA_File(){
            InitializeComponent();
        }
        public NHA_ProcessFinder.NHA_ProcessFinder PROFILER =new NHA_ProcessFinder.NHA_ProcessFinder();
        private void ConnectProc_Click(object sender, EventArgs e){
            if(PROFILER.Visible==false){
            PROFILER.Show();
        }}

        private void Hider_MouseDown(object s, MouseEventArgs e){
            this.Hide();
        }

    }
}
