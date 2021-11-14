using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SettingsManager;

namespace TestApp
{
    public partial class frmMain : Form
    {
        clSettingsManager stn = new clSettingsManager();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(stn.createDefaultFile()==true)
            {
                txtLog.Text += txtLog.Text + " Default file created." + Environment.NewLine;
            }else
            {
                txtLog.Text += txtLog.Text + " Default file NOT created, maybe it exists?." + Environment.NewLine;
                stn.loadFile();
                txtPath.Text = stn.readSetting("path");
                if(stn.readSetting("check1")=="1")
                {
                    chkCheck1.Checked = true;
                }else
                {
                    chkCheck1.Checked = false;
                }
                if(stn.readSetting("check2")=="1")
                {
                    chkCheck2.Checked = true;
                }else
                {
                    chkCheck2.Checked = false;
                }
                if(stn.readSetting("option1")=="1")
                {
                    optOption1.Checked = true;
                }
                if(stn.readSetting("option2")=="1")
                {
                    optOption2.Checked = true;
                }
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if(stn.existsSetting("path")==false)
            {
                stn.createSetting("path", txtPath.Text);
            }else
            {
                stn.updateSetting("path", txtPath.Text);
            }

            if(stn.existsSetting("check1")==false)
            {
                if(chkCheck1.Checked==true)
                {
                    stn.createSetting("check1", "1");
                }else
                {
                    stn.createSetting("check1", "0");
                }
            }else
            {
                if (chkCheck1.Checked == true)
                {
                    stn.updateSetting("check1", "1");
                }
                else
                {
                    stn.updateSetting("check1", "0");
                }
            }

            if(stn.existsSetting("check2")==false)
            {
                if(chkCheck2.Checked == true)
                {
                    stn.createSetting("check2", "1");
                }else
                {
                    stn.createSetting("check2", "0");
                }
            }else
            {
                if (chkCheck2.Checked == true)
                {
                    stn.updateSetting("check2", "1");
                }
                else
                {
                    stn.updateSetting("check2", "0");
                }
            }

            if(stn.existsSetting("option1")==false)
            {
                if (optOption1.Checked == true)
                {
                    stn.createSetting("option1", "1");
                }
                else
                {
                    stn.createSetting("option1", "0");
                }
                
            }else
            {
                if (optOption1.Checked == true)
                {
                    stn.updateSetting("option1", "1");
                }
                else
                {
                    stn.updateSetting("option1", "0");
                }
            }

            if(stn.existsSetting("option2")==false)
            {
                if(optOption2.Checked == true)
                {
                    stn.createSetting("option2", "1");
                }else
                {
                    stn.createSetting("option2", "0");
                }
            }else
            {
                if (optOption2.Checked == true)
                {
                    stn.updateSetting("option2", "1");
                }
                else
                {
                    stn.updateSetting("option2", "0");
                }
            }

            stn.saveSettings();
        }
    }
}
