//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;


namespace NSUdp_server {
    
    public partial class udp_serverForm {
        public udp_serverForm() {
            InitializeComponent();
        }
        void exitClick(object sender, EventArgs ea) {
            CancelEventArgs cea = new CancelEventArgs();

            Application.Exit(cea);
            if (cea.Cancel) {
                return;
            }
            Application.Exit();
        }
        void formLoad(object sender, EventArgs ea) {
        }
        [STAThread()]
        public static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new udp_serverForm());
        }
    }
}
