using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ScriptRunMan
{
    public partial class frmRunScripts : Form
    {
        public frmRunScripts()
        {
            InitializeComponent();
        }

        private void PickSciptDir_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnDirPick_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog pickDir = new FolderBrowserDialog();
            {
                pickDir.Description = "Pick Location of LPM Upgrade Scripts";

                pickDir.ShowDialog();
                string selectedDir = pickDir.SelectedPath;

                if (selectedDir == null)
                {
                    return;
                }

                if (selectedDir.Trim() == "")
                {
                    return;
                }

                txtScriptDir.Text = selectedDir;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            this.RunScripts(txtScriptDir.Text);
        }

        private bool RunScripts(string scriptDir)
        {
            string runScriptsBat = txtScriptDir.Text + "\\lw_Upgrade_LPM.bat";

            if (!File.Exists(runScriptsBat))
            {
                MessageBox.Show("Upgrade bat file does not exists at:  " + runScriptsBat);
                    return false;
            }

            return true;
        }
    }
}
