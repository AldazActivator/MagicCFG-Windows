/*
 * 
 * Developed By Gerson Aldaz [ AldazActivator ]
 * if you wanna source full dm telegram @gerson_5
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicCFG
{
    public partial class iCloudUnlockCFG : Form
    {
        public iCloudUnlockCFG()
        {
            InitializeComponent();
            
        }

        private void CloseCFG_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UnlockBtn_Click(object sender, EventArgs e)
        {
            MainCFG DaTa = new MainCFG();
            if (SNText.Text == "" || WMacText.Text == "" || BMacTxt.Text == "")
            {

                MessageBox.Show("Null Arguments\n\nInsert the information requested", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            DaTa.WriteNandDataDevice("SrNm", SNText.Text);
            DaTa.WriteNandDataDevice("WMac", WMacText.Text);
            DaTa.WriteNandDataDevice("BMac", BMacTxt.Text);
            MessageBox.Show("Successfully iCloud Unlock!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
