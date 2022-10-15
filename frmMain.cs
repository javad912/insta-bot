using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstagramBot
{
    public partial class frmMain : Form
    {

        string CustumList = string.Empty ; 

        public frmMain()
        {
            InitializeComponent();
        }

        private void SelectAction(object sender , EventArgs e)
        {
            lblAction.Text = (sender as RadioButton).Text.ToString(); 
        }

      

        private void lblSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetList getList = new GetList();
            CustumList =  getList.GetCustumList(lblSelect); 
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string setting =
                txtUsername.Text.ToString() + "," +
                txtPassword.Text.ToString() + "," +
                txtTarget.Text.ToString() + "," +
                lblAction.Text.ToString() + "," +
                cbRandomize.Checked+ "," +
                cbUseRandomTags.Checked + "," +
                cbSkipTopPosts.Checked + "," +
                cbInteraction.Checked + "," +
                txtAmount.Text.ToString() + "," +
                txtTimes.Text.ToString() + "," +
                txtDelay.Text.ToString();

            setting.SaveCustumSetting("Instabot_setting.insbt");
            CustumList.SaveCustumSetting("Instabot_List.insbt");

            RunFile run = new RunFile(); 


        }
    }
}
